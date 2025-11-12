using Microsoft.EntityFrameworkCore;
using SchoolManager.Database;
using SchoolManager.Entities;
using SchoolManager.Interfaces;
using SchoolManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class StudentListForm : Form
    {
        private StudentService _studentService;
        private SchoolSubjectService _schoolSubjectService;
        private AppDbContext _dbContext;
        private List<Student> _students;

        public StudentListForm(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _studentService = new StudentService(_dbContext);
            _schoolSubjectService = new SchoolSubjectService(_dbContext);
            _students = new List<Student>();

            InitializeComponent();
            SetupDataGrid();
        }

        /// <summary>
        /// Nastavení data gridu pro zobrazení studentů
        /// </summary>
        private void SetupDataGrid()
        {
            studentsDataGridView.AutoGenerateColumns = false;
            studentsDataGridView.AllowUserToAddRows = false;
            studentsDataGridView.Columns.Clear();

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Jméno a příjmení"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BirthDate",
                HeaderText = "Datum narození",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GradeAverage",
                HeaderText = "Průměr známek"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GradeCount",
                HeaderText = "Celkem známek"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastGradeValue",
                HeaderText = "Poslední známka"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastGradeDate",
                HeaderText = "Datum poslední známky"
            });
        }

        /// <summary>
        /// Načtení studentů
        /// </summary>
        private async Task LoadStudents()
        {
            _students = await _studentService.FindAll();
            studentsDataGridView.DataSource = _students;
        }

        /// <summary>
        /// Přidání studenta
        /// </summary>
        private async Task AddStudent()
        {
            StudentEditForm form = new StudentEditForm(_dbContext);
            form.ShowDialog();
            await LoadStudents();
        }

        /// <summary>
        /// Úprava studenta
        /// </summary>
        private async Task EditStudent()
        {
            if (studentsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve studenta, kterého chcete upravit.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = (Student)studentsDataGridView.CurrentRow.DataBoundItem;
            StudentEditForm form = new StudentEditForm(_dbContext, student);
            form.ShowDialog();
            await LoadStudents();
        }

        /// <summary>
        /// Smazání studenta
        /// </summary>
        private async Task DeleteStudent()
        {
            if (studentsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve studenta, kterého chcete smazat.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = (Student)studentsDataGridView.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete smazat studenta {student.FullName}?",
                "Potvrzení smazání",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = await _studentService.Delete(student.Id);
                    if (!success)
                    {
                        MessageBox.Show("Studenta se nepodařilo smazat.", "Chyba",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    await LoadStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při mazání studenta: {ex.Message}", "Chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Otevření seznamu předmětů
        /// </summary>
        private async Task OpenSubjectList()
        {
            SchoolSubjectListForm form = new SchoolSubjectListForm(_dbContext);
            form.ShowDialog();
            await LoadStudents();
        }

        /// <summary>
        /// Otevření seznamu známek vybraného studenta
        /// </summary>
        private async Task OpenGradeList()
        {
            if (studentsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve studenta.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<SchoolSubject> subjects = await _schoolSubjectService.FindAll();

            if (subjects.Count == 0) 
            {
                MessageBox.Show("Nejdříve je potřeba přidat předměty.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = (Student)studentsDataGridView.CurrentRow.DataBoundItem;

            GradeListForm form = new GradeListForm(_dbContext, student);
            form.ShowDialog();
            await LoadStudents();
        }


        private async void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddStudent();
        }

        private async void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await EditStudent();
        }

        private async void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DeleteStudent();
        }

        private async void showSubjectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            await OpenSubjectList();
        }

        private async void showGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await OpenGradeList();
        }

        private void studentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (studentsDataGridView.Columns[e.ColumnIndex].DataPropertyName == "LastGradeDate")
            {
                if (e.Value == null)
                {
                    e.Value = "Není k dispozici";
                    e.FormattingApplied = true;
                }
                else if (e.Value is DateTime date)
                {
                    e.Value = date.ToString("d");
                    e.FormattingApplied = true;
                }
            }

            if (studentsDataGridView.Columns[e.ColumnIndex].DataPropertyName == "LastGradeValue")
            {
                if (e.Value == null)
                {
                    e.Value = "Není k dispozici";
                    e.FormattingApplied = true;
                }
            }
        }

        private async void StudentListForm_Load(object sender, EventArgs e)
        {
            await LoadStudents();
        }
    }
}

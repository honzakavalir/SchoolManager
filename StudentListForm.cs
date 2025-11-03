using Microsoft.EntityFrameworkCore;
using SchoolManager.Core.Db;
using SchoolManager.Core.Entities;
using SchoolManager.Core.Helpers;
using SchoolManager.Core.Interfaces;
using SchoolManager.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class StudentListForm : Form, IListForm
    {
        private StudentService _studentService;
        private AppDbContext _dbContext;
        private List<Student> _students;

        public StudentListForm()
        {
            _dbContext = new AppDbContext();
            _studentService = new StudentService(_dbContext);
            _students = new List<Student>();

            InitializeComponent();
            SetupDataGrid();
            this.Load += StudentListForm_Load;
        }

        private async Task LoadStudents()
        {
            _students = await _studentService.FindAll();
            studentsDataGridView.DataSource = _students;
        }

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
                    if (success)
                    {
                        MessageBox.Show("Student byl úspěšně smazán.", "Hotovo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show("Studenta se nepodařilo smazat.", "Chyba",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při mazání studenta: {ex.Message}", "Chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SetupDataGrid()
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

        private async void StudentListForm_Load(object sender, EventArgs e)
        {
            await LoadStudents();
        }


        private async void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<StudentEditForm>(this);
            await LoadStudents();
        }

        private async void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DeleteStudent();
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
    }
}

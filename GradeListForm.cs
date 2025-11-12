using SchoolManager.Database;
using SchoolManager.Entities;
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
    public partial class GradeListForm : Form
    {
        private AppDbContext _dbContext;
        private GradeService _gradeService;
        private Student _student;
        private List<Grade> _grades;

        public GradeListForm(AppDbContext dbContext, Student student)
        {
            _dbContext = dbContext;
            _gradeService = new GradeService(_dbContext);
            _student = student;
            _grades = new List<Grade>();

            InitializeComponent();
            this.Text = $"Známky studenta {_student.FullName}";
            SetupDataGrid();
        }

        /// <summary>
        /// Nastaví DataGridView pro zobrazení známek.
        /// </summary>
        private async void SetupDataGrid()
        {
            await LoadGrades();
            gradesDataGridView.AutoGenerateColumns = false;
            gradesDataGridView.AllowUserToAddRows = false;
            gradesDataGridView.Columns.Clear();
            gradesDataGridView.DataSource = _grades;

            gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Datum",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });

            gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Value",
                HeaderText = "Známka"
            });

            gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SubjectName",
                HeaderText = "Předmět"
            });

            gradesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Note",
                HeaderText = "Poznámka ke známce"
            });
        }

        /// <summary>
        /// Načte známky studenta z databáze
        /// </summary>
        private async Task LoadGrades()
        {
            _grades = await _gradeService.FindByStudent(_student.Id);
            gradesDataGridView.DataSource = _grades;
        }

        /// <summary>
        /// Přidání známky
        /// </summary>
        private async Task AddGrade()
        {
            GradeEditForm form = new GradeEditForm(_dbContext, _student);
            form.ShowDialog();
            await LoadGrades();
        }

        /// <summary>
        /// Upravení známky
        /// </summary>
        private async Task EditGrade()
        {
            if (gradesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve známku, kterou chcete upravit.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Grade grade = (Grade)gradesDataGridView.CurrentRow.DataBoundItem;
            GradeEditForm form = new GradeEditForm(_dbContext, _student, grade);
            form.ShowDialog();
            await LoadGrades();
        }

        /// <summary>
        /// Smazání známky
        /// </summary>
        private async Task DeleteGrade()
        {
            if (gradesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve známku, kterou chcete smazat.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Grade grade = (Grade)gradesDataGridView.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete smazat známku {grade.Value} z předmětu {grade.Subject.Name} ze dne {grade.Date:d}?",
                "Potvrzení smazání",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = await _gradeService.Delete(grade.Id);
                    if (!success)
                    {
                        MessageBox.Show("Známku se nepodařilo smazat.", "Chyba",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    await LoadGrades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při mazání známky: {ex.Message}", "Chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void newGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddGrade();
        }

        private async void editGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await EditGrade();
        }

        private async void deleteGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DeleteGrade();
        }
    }
}

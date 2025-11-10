using SchoolManager.Database;
using SchoolManager.Entities;
using SchoolManager.Services;
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
    public partial class SchoolSubjectListForm : Form
    {
        private SchoolSubjectService _schoolSubjectService;
        private AppDbContext _dbContext;
        private List<SchoolSubject> _schoolSubjects;

        public SchoolSubjectListForm()
        {
            _dbContext = new AppDbContext();
            _schoolSubjectService = new SchoolSubjectService(_dbContext);
            _schoolSubjects = new List<SchoolSubject>();

            InitializeComponent();
            SetupDataGrid();
        }

        public void SetupDataGrid()
        {
            schoolSubjectsDataGridView.AutoGenerateColumns = false;
            schoolSubjectsDataGridView.AllowUserToAddRows = false;
            schoolSubjectsDataGridView.Columns.Clear();

            schoolSubjectsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Název"
            });

            schoolSubjectsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Abbr",
                HeaderText = "Zkratka"
            });

            schoolSubjectsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GradeAverage",
                HeaderText = "Průměr známek"
            });

            schoolSubjectsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GradeCount",
                HeaderText = "Celkem známek"
            });

            schoolSubjectsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Popis"
            });
        }

        private async Task LoadSchoolSubjects()
        {
            _schoolSubjects = await _schoolSubjectService.FindAll();
            schoolSubjectsDataGridView.DataSource = _schoolSubjects;
        }

        private async Task AddSchoolSubject()
        {
            SchoolSubjectEditForm form = new SchoolSubjectEditForm();
            form.ShowDialog();
            await LoadSchoolSubjects();
        }

        private async Task EditSchoolSubject()
        {
            if (schoolSubjectsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve předmět, který chcete upravit.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SchoolSubject schoolSubject = (SchoolSubject)schoolSubjectsDataGridView.CurrentRow.DataBoundItem;
            SchoolSubjectEditForm form = new SchoolSubjectEditForm();
            form.SetSchoolSubject(schoolSubject);
            form.ShowDialog();
            await LoadSchoolSubjects();
        }

        private async Task DeleteSchoolSubject()
        {
            if (schoolSubjectsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vyberte nejprve předmět, který chcete smazat.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SchoolSubject schoolSubject = (SchoolSubject)schoolSubjectsDataGridView.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete smazat předmět {schoolSubject.Name}?",
                "Potvrzení smazání",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = await _schoolSubjectService.Delete(schoolSubject.Id);
                    if (!success)
                    {
                        MessageBox.Show("Předmět se nepodařilo smazat.", "Chyba",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    await LoadSchoolSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při mazání předmětu: {ex.Message}", "Chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddSchoolSubject();
        }

        private async void editSchoolSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await EditSchoolSubject();
        }

        private async void removeSchoolSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DeleteSchoolSubject();
        }

        private async void SchoolSubjectListForm_Load(object sender, EventArgs e)
        {
            await LoadSchoolSubjects();
        }
    }
}

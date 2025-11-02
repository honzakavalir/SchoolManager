using Microsoft.EntityFrameworkCore;
using SchoolManager.Core.Db;
using SchoolManager.Core.Helpers;
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
    public partial class StudentListForm : Form
    {
        private AppDbContext _dbContext = new AppDbContext();

        public StudentListForm()
        {
            InitializeComponent();
            //LoadStudents();
        }

        private void LoadStudents()
        {
            _dbContext.Students.Load();

            studentsDataGridView.AutoGenerateColumns = false;
            studentsDataGridView.AllowUserToAddRows = false;
            studentsDataGridView.Columns.Clear();

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Jméno"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Příjmení"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BirthDate",
                HeaderText = "Datum narození"
            });

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SchoolClass.Name",
                HeaderText = "Třída"
            });

            studentsDataGridView.DataSource = _dbContext.Students.Local.ToBindingList();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<StudentEditForm>(this);
        }
    }
}

using SchoolManager.Entities;
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
    public partial class GradeListForm : Form
    {
        private Student _student;

        public GradeListForm(Student student)
        {
            InitializeComponent();
            _student = student;
            this.Text = $"Známky studenta {_student.FullName}";
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            gradesDataGridView.AutoGenerateColumns = false;
            gradesDataGridView.AllowUserToAddRows = false;
            gradesDataGridView.Columns.Clear();
        }

        private async Task AddGrade()
        {
            GradeEditForm form = new GradeEditForm(_student);
            form.ShowDialog();
        }

        private void newGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrade();
        }
    }
}

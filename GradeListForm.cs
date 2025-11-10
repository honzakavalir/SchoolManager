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
        public GradeListForm(Student student)
        {
            InitializeComponent();
            this.Text = $"Známky studenta {student.FullName}";
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            gradesDataGridView.AutoGenerateColumns = false;
            gradesDataGridView.AllowUserToAddRows = false;
            gradesDataGridView.Columns.Clear();
        }
    }
}

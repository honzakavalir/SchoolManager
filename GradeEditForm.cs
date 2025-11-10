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
    public partial class GradeEditForm : Form
    {
        private AppDbContext _dbContext;
        private SchoolSubjectService _schoolSubjectService;
        private List<SchoolSubject> _schoolSubjects;

        public GradeEditForm(Student student)
        {
            _dbContext = new AppDbContext();
            _schoolSubjectService = new SchoolSubjectService(_dbContext);
            _schoolSubjects = new List<SchoolSubject>();

            InitializeComponent();

            studentTextBox.Text = student.FullName;
            SetupGradeCombobox();
            SetupSchoolSubjectCombobox();
        }

        private void SetupGradeCombobox()
        {
            gradeComboBox.DataSource = AppConstantService.GetGrades();
            gradeComboBox.DisplayMember = "Text";
            gradeComboBox.ValueMember = "Value";
            gradeComboBox.SelectedValue = 1;
        }

        private async void SetupSchoolSubjectCombobox()
        {
            await LoadSchoolSubjects(); 
            schoolSubjectComboBox.DataSource = _schoolSubjects;
            schoolSubjectComboBox.DisplayMember = "Abbr";
            schoolSubjectComboBox.ValueMember = "Id";
        }

        private async Task LoadSchoolSubjects()
        {
            _schoolSubjects = await _schoolSubjectService.FindAll();
        }
    }
}

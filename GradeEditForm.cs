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
using System.Xml.Linq;

namespace SchoolManager
{
    public partial class GradeEditForm : Form
    {
        private AppDbContext _dbContext;
        private SchoolSubjectService _schoolSubjectService;
        private StudentService _studentService;
        private GradeService _gradeService;

        private List<SchoolSubject> _schoolSubjects;
        private Student _student;
        private Grade? _grade;

        public GradeEditForm(Student student, Grade? grade = null)
        {
            _dbContext = new AppDbContext();
            _schoolSubjectService = new SchoolSubjectService(_dbContext);
            _studentService = new StudentService(_dbContext);
            _gradeService = new GradeService(_dbContext);

            _schoolSubjects = new List<SchoolSubject>();
            _student = student;

            InitializeComponent();

            studentTextBox.Text = student.FullName;
            SetupGradeCombobox();
            SetupSchoolSubjectCombobox();

            if (grade != null)
            {
                _grade = grade;
                InsertValuesIntoFrom();
                EnableEditMode();
            }
        }

        private void InsertValuesIntoFrom()
        {
            gradeComboBox.SelectedValue = _grade!.Value;
            schoolSubjectComboBox.SelectedValue = _grade!.SubjectId;
            noteTextBox.Text = _grade!.Note;
        }

        private void EnableEditMode()
        {
            this.Text = "Upravit známku";
            saveButton.Text = "Uložit";
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

        private async Task SaveGrade()
        {
            Grade grade = new Grade
            {
                StudentId = _student.Id,
                SubjectId = (int)schoolSubjectComboBox.SelectedValue,
                Value = (int)gradeComboBox.SelectedValue,
                Date = DateTime.Now,
                Note = noteTextBox.Text
            };

            Student? student = await _studentService.FindOne(_student.Id);
            if (student != null && _grade == null)
            {
                student.Grades.Add(grade);
                await _studentService.Update(_student.Id, student);
            }

            if (_student != null && _grade != null)
            {
                _grade.Value = grade.Value;
                _grade.SubjectId = grade.SubjectId;
                _grade.Date = grade.Date;
                _grade.Note = noteTextBox.Text;
                await _gradeService.Update(_grade.Id, _grade);
            }

            Close();
        }

        private async Task LoadSchoolSubjects()
        {
            _schoolSubjects = await _schoolSubjectService.FindAll();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            await SaveGrade();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

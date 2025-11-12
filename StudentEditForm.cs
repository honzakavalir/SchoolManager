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
    public partial class StudentEditForm : Form
    {
        private StudentService _studentService;
        private AppDbContext _dbContext;
        private Student? _student;

        public StudentEditForm(AppDbContext dbContext, Student? student = null)
        {
            _dbContext = dbContext;
            _studentService = new StudentService(_dbContext);

            InitializeComponent();

            if (student != null)
            {
                _student = student;
                InsertValuesIntoFrom();
                EnableEditMode();
            }
        }

        /// <summary>
        /// Přepnutí formuláře do režimu úprav
        /// </summary>
        private void EnableEditMode()
        {
            this.Text = "Upravit studenta";
            saveButton.Text = "Uložit";

        }

        /// <summary>
        /// Vložení hodnot studenta do formuláře
        /// </summary>
        private void InsertValuesIntoFrom()
        {
            firstNameTextBox.Text = _student!.FirstName;
            lastNameTextBox.Text = _student!.LastName;
            birthDateDateTimePicker.Value = _student!.BirthDate;
        }

        /// <summary>
        /// Uložení studenta
        /// </summary>
        private async void SaveStudent()
        {
            try
            {
                string firstName = firstNameTextBox.Text.Trim();
                string lastName = lastNameTextBox.Text.Trim();
                DateTime birthDate = birthDateDateTimePicker.Value;

                if (string.IsNullOrEmpty(firstName))
                {
                    MessageBox.Show("Zadejte křestní jméno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("Zadejte příjmení.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_student == null)
                {
                    Student student = new Student(firstName, lastName, birthDate);
                    await _studentService.Create(student);
                    Close();
                } 
                else
                {
                    _student.FirstName = firstNameTextBox.Text;
                    _student.LastName = lastNameTextBox.Text;
                    _student.BirthDate = birthDateDateTimePicker.Value;
                    await _studentService.Update(_student.Id, _student);
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při ukládání studenta: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }
    }
}

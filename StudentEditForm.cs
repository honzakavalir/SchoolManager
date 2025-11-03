using SchoolManager.Core.Db;
using SchoolManager.Core.Entities;
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
    public partial class StudentEditForm : Form
    {
        private StudentService _studentService;
        private AppDbContext _dbContext;

        public StudentEditForm()
        {
            _dbContext = new AppDbContext();
            _studentService = new StudentService(_dbContext);

            InitializeComponent();
        }

        private async void CreateStudent()
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

                Student student = new Student(firstName, lastName, birthDate);
                await _studentService.Create(student);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při vytváření studenta: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CreateStudent();
        }
    }
}

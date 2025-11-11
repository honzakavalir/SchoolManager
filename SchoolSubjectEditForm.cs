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
    public partial class SchoolSubjectEditForm : Form
    {
        private SchoolSubjectService _schoolSubjectService;
        private AppDbContext _dbContext;
        private SchoolSubject? _schoolSubject;

        public SchoolSubjectEditForm(AppDbContext dbContext, SchoolSubject? schoolSubject = null)
        {
            _dbContext = dbContext;
            _schoolSubjectService = new SchoolSubjectService(_dbContext);

            InitializeComponent();

            if (schoolSubject != null)
            {
                _schoolSubject = schoolSubject;
                InsertValuesIntoFrom();
                EnableEditMode();
            }
        }

        private void EnableEditMode()
        {
            this.Text = "Upravit předmět";
            saveButton.Text = "Uložit";
        }

        private void InsertValuesIntoFrom()
        {
            nameTextBox.Text = _schoolSubject!.Name;
            abbrTextBox.Text = _schoolSubject!.Abbr;
            descriptionTextBox.Text = _schoolSubject!.Description;
        }

        private async void SaveSchoolSubject()
        {
            try
            {
                string name = nameTextBox.Text.Trim();
                string abbr = abbrTextBox.Text.Trim();
                string description = descriptionTextBox.Text.Trim();

                SchoolSubject? existingSubject = await _schoolSubjectService.FindByAbbr(abbr);

                if (existingSubject != null && (_schoolSubject == null || existingSubject.Id != _schoolSubject.Id))
                {
                    MessageBox.Show("Předmět se zadanou zkratkou již existuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Zadejte název předmětu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(abbr))
                {
                    MessageBox.Show("Zadejte zkratku předmětu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_schoolSubject == null)
                {
                    SchoolSubject schoolSubject = new SchoolSubject(name, abbr, description);
                    await _schoolSubjectService.Create(schoolSubject);
                }
                else
                {
                    _schoolSubject.Name = name;
                    _schoolSubject.Abbr = abbr;
                    _schoolSubject.Description = description;
                    await _schoolSubjectService.Update(_schoolSubject.Id, _schoolSubject);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při ukládání předmětu: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSchoolSubject();
        }
    }
}

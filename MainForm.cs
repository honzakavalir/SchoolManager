using SchoolManager.Core.Db;
using SchoolManager.Core.Helpers;

namespace SchoolManager
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private AppDbContext _dbContext = new AppDbContext();

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            _dbContext.Database.EnsureCreated();

            LoadButtonsState();
        }

        private void button_students_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<StudentListForm>(this);
        }

        private void LoadButtonsState()
        {
            studentsButton.Enabled = _dbContext.SchoolClasses.Any();
            schoolClassesButton.Enabled = _dbContext.Teachers.Any();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<TeacherListForm>(this);
        }
    }
}

using SchoolManager.Core.Db;

namespace SchoolManager
{
    public partial class MainForm : System.Windows.Forms.Form
    { 
        private AppDbContext _dbContext = new AppDbContext();

        public MainForm()
        {
            InitializeComponent();
            _dbContext.Database.EnsureCreated();
            LoadButtonsState();
        }

        private void button_students_Click(object sender, EventArgs e)
        {
            Hide();
            using (StudentListForm form = new StudentListForm())
            {
                form.ShowDialog();
            }
            Show();
        }

        private void LoadButtonsState()
        {
            studentsButton.Enabled = _dbContext.SchoolClasses.Any();
            schoolClassesButton.Enabled = _dbContext.Teachers.Any();
        }
    }
}

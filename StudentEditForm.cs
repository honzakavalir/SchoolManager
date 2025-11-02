using SchoolManager.Core.Db;
using SchoolManager.Core.Entities;
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
        private AppDbContext _dbContext = new AppDbContext();

        public StudentEditForm()
        {
            InitializeComponent();
        }

        public void CreateStudent()
        {
        }
    }
}

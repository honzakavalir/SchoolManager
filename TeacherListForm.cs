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
    public partial class TeacherListForm : Form
    {
        public TeacherListForm()
        {
            InitializeComponent();
        }

        private void closeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

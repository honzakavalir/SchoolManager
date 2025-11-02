using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Helpers
{
    public static class FormHelper
    {
        public static void OpenForm<T>(Form owner) where T : Form, new()
        {
            owner.Hide();
            using (T form = new T())
            {
                form.ShowDialog();
            }
            owner.Show();
        }
    }
}

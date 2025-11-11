

using Microsoft.EntityFrameworkCore;
using SchoolManager.Database;

namespace SchoolManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var _dbContext = new AppDbContext())
            {
                _dbContext.Database.EnsureCreated();
                Application.Run(new StudentListForm(_dbContext));
            }
        }
    }
}
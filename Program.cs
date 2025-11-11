

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

            // Vytvoøení nového kontextu databáze – zajišuje pøipojení k databázi, správu entit a komunikaci s databází.
            using (var _dbContext = new AppDbContext())
            {
                // Zajištìní, e databáze existuje.
                _dbContext.Database.EnsureCreated();

                // Spuštìní hlavního formuláøe aplikace
                Application.Run(new StudentListForm(_dbContext));
            }
        }
    }
}
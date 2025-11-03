using SchoolManager.Core.Db;

namespace SchoolManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }

            Application.Run(new StudentListForm());
        }
    }
}
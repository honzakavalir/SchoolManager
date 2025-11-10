using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager.Services
{
    public static class AppConstantService
    {
        private static readonly List<GradeItem> _grades = new()
        {
            new GradeItem(1, "1 - Výborně"),
            new GradeItem(2, "2 - Chvalitebně"),
            new GradeItem(3, "3 - Dobře"),
            new GradeItem(4, "4 - Dostatečně"),
            new GradeItem(5, "5 - Nedostatečně")
        };
        public static IReadOnlyList<GradeItem> GetGrades() => _grades.AsReadOnly();
    }

    public record GradeItem(int Value, string Text);
}

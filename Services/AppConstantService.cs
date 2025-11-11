using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager.Services
{
    /// <summary>
    /// Poskytuje statické konstanty a pomocné datové struktury pro aplikaci.
    /// </summary>
    public static class AppConstantService
    {
        /// <summary>
        /// Seznam všech možných známek používaných ve škole.
        /// </summary>
        private static readonly List<GradeItem> _grades = new()
        {
            new GradeItem(1, "1 - Výborně"),
            new GradeItem(2, "2 - Chvalitebně"),
            new GradeItem(3, "3 - Dobře"),
            new GradeItem(4, "4 - Dostatečně"),
            new GradeItem(5, "5 - Nedostatečně")
        };

        /// <summary>
        /// Vrátí seznam známek jako pouze pro čtení (ReadOnlyList).
        /// </summary>
        public static IReadOnlyList<GradeItem> GetGrades() => _grades.AsReadOnly();
    }

    /// <summary>
    /// Datová struktura pro uchování hodnoty a textového popisu známky.
    /// </summary>
    /// <param name="Value">Číselná hodnota známky.</param>
    /// <param name="Text">Textový popis známky (např. "1 - Výborně").</param>
    public record GradeItem(int Value, string Text);
}

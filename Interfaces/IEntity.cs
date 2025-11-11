using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Interfaces
{
    /// <summary>
    /// Základní rozhraní pro všechny entity v aplikaci
    /// Každá entita musí mít unikátní identifikátor
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Unikátní identifikátor entity
        /// </summary>
        int Id { get; set; }
    }
}

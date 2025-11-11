using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Interfaces
{
    /// <summary>
    /// Obecné rozhraní pro servisní třídy pracující s entitami.
    /// </summary>
    /// <typeparam name="T">Typ entity, se kterou služba pracuje (musí implementovat <see cref="IEntity"/>).</typeparam>
    public interface IService<T> where T : class, IEntity
    {
        /// <summary>
        /// Vrátí všechny entity z databáze.
        /// </summary>
        Task<List<T>> FindAll();

        /// <summary>
        /// Najde jednu entitu podle jejího ID.
        /// </summary>
        /// <param name="id">Identifikátor entity.</param>
        /// <returns>Vrátí entitu nebo <c>null</c>, pokud neexistuje.</returns>
        Task<T?> FindOne(int id);

        /// <summary>
        /// Vytvoří novou entitu v databázi.
        /// </summary>
        /// <param name="entity">Entita k uložení.</param>
        /// <returns>Vrátí vytvořenou entitu.</returns>
        Task<T> Create(T entity);

        /// <summary>
        /// Aktualizuje existující entitu podle jejího ID.
        /// </summary>
        /// <param name="id">ID entity, která se má upravit.</param>
        /// <param name="entity">Nové hodnoty entity.</param>
        /// <returns>Vrátí aktualizovanou entitu nebo <c>null</c>, pokud neexistuje.</returns>
        Task<T?> Update(int id, T entity);

        /// <summary>
        /// Odstraní entitu z databáze podle jejího ID.
        /// </summary>
        /// <param name="id">ID entity ke smazání.</param>
        /// <returns>Vrátí <c>true</c>, pokud byla entita úspěšně smazána, jinak <c>false</c>.</returns>
        Task<bool> Delete(int id);
    }
}

using MikołajRarokZad4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją
    /// z bazą danych dla tabeli BlacklistRepository
    /// </summary>
    public interface IBlacklistRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda pozwalajaca zwrocić
        /// tabelę czarnej listy
        /// </summary>
        /// <returns></returns>
        List<BlacklistViewModel> GetBlacklist();

        /// <summary>
        /// Abstrakcyjna metoda dodania osoby do czarnej listy
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        bool AddToBlacklist(string firstName, string lastName, string phoneNumber);

        /// <summary>
        /// Abstrakcyjna metoda usunięcia osoby z czarnej listy
        /// </summary>
        /// <param name="blacklistId"></param>
        bool RemoveFromBlacklist(int blacklistId);

        /// <summary>
        /// Abstrakcyjna metoda edycji danych o osobie na czarnej liście
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        bool EditBlacklistedPerson(int blacklistId, string firstName, string lastName, string phoneNumber);
    }
}

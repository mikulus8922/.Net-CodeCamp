using MikołajRarokZad4.Models.Entities;
using MikołajRarokZad4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Publiczna klasa definiująca metodody związane z czarną listą 
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class BlacklistRepository : Repository, IBlacklistRepository
    {      
        /// <summary>
        /// Metoda zwracająca tabelę
        /// czarnej listy
        /// </summary>
        /// <returns></returns>
        public List<BlacklistViewModel> GetBlacklist()
        {
            List<GuestBlacklist> guestsBlacklist = DbContext.GuestsBlacklist.ToList();
            return Mapper.Map<List<GuestBlacklist>, List<BlacklistViewModel>>(guestsBlacklist);
        }

        /// <summary>
        /// Metoda pozwalająca dodać osobę do czarnej listy
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        public bool AddToBlacklist(string firstName, string lastName, string phoneNumber)
        {
            GuestBlacklist guestBlacklistToAdd = new GuestBlacklist()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };

            DbContext.GuestsBlacklist.Add(guestBlacklistToAdd);

            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Metoda pozwalająca usunąć osobę z czarnej listy
        /// </summary>
        /// <param name="blacklistId"></param>
        public bool RemoveFromBlacklist(int blacklistId)
        {
            GuestBlacklist guestBlacklist = DbContext.GuestsBlacklist.SingleOrDefault(b => b.Id == blacklistId);
            DbContext.GuestsBlacklist.Remove(guestBlacklist);
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Metoda pozwalająca edytować dane o osobie na czarnej liście
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        public bool EditBlacklistedPerson(int blacklistId, string firstName, string lastName, string phoneNumber)
        {
            GuestBlacklist guestBlacklist = DbContext.GuestsBlacklist.SingleOrDefault(b => b.Id == blacklistId);
            if (guestBlacklist == null)
                return false;

            guestBlacklist.FirstName = firstName;
            guestBlacklist.LastName = lastName;
            guestBlacklist.PhoneNumber = phoneNumber;

            return DbContext.SaveChanges() > 0;
        }
    }
}

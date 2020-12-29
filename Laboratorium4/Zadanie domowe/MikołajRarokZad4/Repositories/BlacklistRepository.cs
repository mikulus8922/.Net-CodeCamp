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
        public DataTable GetBlacklist()
        {




            DataTable table = new DataTable();


            return table;
        }

        /// <summary>
        /// Metoda pozwalająca dodać osobę do czarnej listy
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        public void AddToBlacklist(string firstName, string lastName, string phoneNumber)
        {

        }

        /// <summary>
        /// Metoda pozwalająca usunąć osobę z czarnej listy
        /// </summary>
        /// <param name="blacklistId"></param>
        public void RemoveFromBlacklist(int blacklistId)
        {

        }

        /// <summary>
        /// Metoda pozwalająca edytować dane o osobie na czarnej liście
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        public void EditBlacklistedPerson(int Id, string firstName, string lastName, string phoneNumber)
        {

        }
    }
}

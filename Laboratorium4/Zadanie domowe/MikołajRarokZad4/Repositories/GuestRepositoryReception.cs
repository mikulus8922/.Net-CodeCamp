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
    /// Publiczna klasa definiująca metodody związane z gośćmi w wersji "admin"
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class GuestsRepositoryReception : Repository, IGuestsRepository
    {
        /// <summary>
        /// Metoda zwracająca tabelę
        /// gości w wersji "reception"
        /// </summary>
        /// <returns></returns>
        public DataTable GetGuests()
        {
           
            
            DataTable table = new DataTable();




            return table;
        }

        /// <summary>
        /// Metoda pozwalająca dodać gościa do bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="roomId"></param>
        public void AddGuest(string firstName, string lastName, string phoneNumber, int roomId)
        {
            return;
        }

        /// <summary>
        /// Metoda pozwalająca na usunięcie gościa z bazy danych
        /// </summary>
        /// <param name="guestId"></param>
        public void DeleteGuest(int guestId)
        {
            return;
        }

        /// <summary>
        /// Metoda pozwalająca na edytowanie danych o gościu w bazie danych
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="roomId"></param>
        public void EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomId)
        {
            return;
        }

        



    }
}

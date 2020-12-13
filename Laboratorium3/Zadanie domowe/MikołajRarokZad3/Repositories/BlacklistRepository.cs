using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
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
            string getBlacklistQuery = "SELECT * FROM GuestsBlacklist;";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getBlacklistQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

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
            string addToBlacklistQuery = $"INSERT INTO GuestsBlacklist VALUES ('{firstName}', '{lastName}', '{phoneNumber}');";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(addToBlacklistQuery, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();
        }

        /// <summary>
        /// Metoda pozwalająca usunąć osobę z czarnej listy
        /// </summary>
        /// <param name="blacklistId"></param>
        public void RemoveFromBlacklist(int blacklistId)
        {
            string removeFromBlacklistQuery = $"DELETE FROM GuestsBlacklist  Where Id ='{blacklistId}';";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(removeFromBlacklistQuery, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();
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
            string updateBlacklistQuery = $"UPDATE GuestsBlacklist SET FirstName='{firstName}', LastName='{lastName}', PhoneNumber='{phoneNumber}' WHERE Id='{Id}';";

            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(updateBlacklistQuery, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();
        }
    }
}

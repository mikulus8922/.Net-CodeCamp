using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public class BlacklistRepository : Repository, IBlacklistRepository
    {      
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

        public void AddToBlacklist(string firstName, string lastName, string phoneNumber)
        {
            string addToBlacklistQuery = $"INSERT INTO GuestsBlacklist VALUES ('{firstName}', '{lastName}', '{phoneNumber}');";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(addToBlacklistQuery, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();
        }


        public void RemoveFromBlacklist(int blacklistId)
        {
            string removeFromBlacklistQuery = $"DELETE FROM GuestsBlacklist  Where Id ='{blacklistId}';";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(removeFromBlacklistQuery, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();
        }


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

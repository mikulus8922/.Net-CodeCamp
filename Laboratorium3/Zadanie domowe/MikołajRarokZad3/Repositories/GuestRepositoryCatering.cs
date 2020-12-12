using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public class GuestsRepositoryCatering : Repository, IGuestsRepository
    {
        public DataTable GetGuests()
        {
            string getGuestsQuery = "SELECT Guests.Id, Guests.FirstName, Guests.LastName, Guests.PhoneNumber, GuestsCatering.Breakfast, GuestsCatering.Lunch, GuestsCatering.Dinner FROM Guests  INNER JOIN GuestsCatering ON Guests.Id=GuestsCatering.GuestId;";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getGuestsQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public void AddGuest(string firstName, string lastName, string phoneNumber, int roomId)
        {
            return;
        }



        public void DeleteGuest(int guestId)
        {
            return;
        }

        public void EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomId)
        {
            return;
        }


    }
}

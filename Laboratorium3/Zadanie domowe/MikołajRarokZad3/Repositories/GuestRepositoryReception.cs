using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public class GuestsRepositoryReception : Repository, IGuestsRepository
    {
        public DataTable GetGuests()
        {
            string getGuestsQuery = "SELECT Guests.Id, Guests.FirstName, Guests.LastName, Guests.PhoneNumber, Rooms.Number, GuestsBooking.BookedIn, GuestsBooking.BookedOut, GuestsCatering.Breakfast, GuestsCatering.Lunch, GuestsCatering.Dinner, GuestsAccess.GymAccess, GuestsAccess.SpaAccess, GuestsAccess.PoolAccess FROM Guests INNER JOIN Rooms ON Guests.RoomId=Rooms.Id INNER JOIN GuestsBooking ON Guests.Id=GuestsBooking.GuestId INNER JOIN GuestsCatering ON Guests.Id=GuestsCatering.GuestId INNER JOIN GuestsAccess ON Guests.Id=GuestsAccess.GuestId;";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getGuestsQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public void AddGuest(string firstName, string lastName, string phoneNumber, int roomId)
        {

        }



        public void DeleteGuest(int guestId)
        {
            throw new NotImplementedException();
        }

        public void EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomId)
        {
            throw new NotImplementedException();
        }


    }
}

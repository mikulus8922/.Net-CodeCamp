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
    /// Publiczna klasa definiująca metodody związane z pokojami
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class RoomsRepository : Repository, IRoomsRepository
    {

        public DataTable GetRooms()
        {
            Connection.Open();

            string getRoomsQuery = "SELECT * FROM Rooms;";
            SqlDataAdapter adapter = new SqlDataAdapter(getRoomsQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }



        /// <summary>
        /// Metoda pozwalająca zmienić rozmiar pokoju (w osobach)
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomCapacity"></param>
        public void EditRoomCapacity(int roomId, int roomCapacity)
        {
            Connection.Open();

            string updateRoomCapacityQuery = $"UPDATE Rooms SET RoomCapacity='{roomCapacity}' WHERE Id='{roomId}';";
            SqlCommand commandUpdateRoom = new SqlCommand(updateRoomCapacityQuery, Connection);
            commandUpdateRoom.ExecuteNonQuery();
            Connection.Close();

        }


    }
}

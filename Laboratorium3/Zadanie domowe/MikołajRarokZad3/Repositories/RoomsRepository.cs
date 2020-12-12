using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
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

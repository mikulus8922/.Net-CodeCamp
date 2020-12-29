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
    /// Publiczna klasa definiująca metodody związane z pokojami
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class RoomsRepository : Repository, IRoomsRepository
    {

        public DataTable GetRooms()
        {
            DataTable table = new DataTable();




            return table;
        }



        /// <summary>
        /// Metoda pozwalająca zmienić rozmiar pokoju (w osobach)
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomCapacity"></param>
        public void EditRoomCapacity(int roomId, int roomCapacity)
        {

        }


    }
}

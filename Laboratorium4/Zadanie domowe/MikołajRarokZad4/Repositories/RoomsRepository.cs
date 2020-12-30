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
    /// Publiczna klasa definiująca metodody związane z pokojami
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class RoomsRepository : Repository, IRoomsRepository
    {

        public List<RoomViewModel> GetRooms()
        {
            List<Room> rooms = DbContext.Rooms.ToList();
            return Mapper.Map<List<Room>, List<RoomViewModel>>(rooms);
        }



        /// <summary>
        /// Metoda pozwalająca zmienić rozmiar pokoju (w osobach)
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomCapacity"></param>
        public bool EditRoomCapacity(int roomId, int roomCapacity)
        {
            Room room = DbContext.Rooms.SingleOrDefault(b => b.Id == roomId);
            if (room == null)
                return false;

            room.RoomCapacity = roomCapacity;

            return DbContext.SaveChanges() > 0;
        }


    }
}

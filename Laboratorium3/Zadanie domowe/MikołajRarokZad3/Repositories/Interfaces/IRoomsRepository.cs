using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public interface IRoomsRepository
    {
        DataTable GetRoom();

        /// <summary>
        /// Metoda pozwalająca zmienić ile w danym pokoju jest miejsc
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomCapacity"></param>
        void EditRoomCapacity(int roomId, int roomCapacity);
    }
}

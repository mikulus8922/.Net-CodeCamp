using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją
    /// z bazą danych dla tabeli RoomsRepository
    /// </summary>
    public interface IRoomsRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda pozwalajaca zwrocić
        /// tabelę pokoi
        /// </summary>
        /// <returns></returns>
        DataTable GetRooms();

        /// <summary>
        /// Metoda pozwalająca zmienić ile w danym pokoju jest miejsc
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomCapacity"></param>
        void EditRoomCapacity(int roomId, int roomCapacity);
    }
}

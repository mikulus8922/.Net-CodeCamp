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
    /// z bazą danych dla tabeli GuestsRepository
    /// </summary>
    public interface IGuestsRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda pozwalajaca zwrocić
        /// tabelę gości
        /// </summary>
        /// <returns></returns>
        DataTable GetGuests();

        /// <summary>
        /// Abstrakcyjna metoda dodania gościa
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="roomId"></param>
        void AddGuest(string firstName, string lastName, string phoneNumber, int roomId);

        /// <summary>
        /// Abstrakcyjna metoda usunięcia gościa
        /// </summary>
        /// <param name="guestId"></param>
        void DeleteGuest(int guestId);

        /// <summary>
        /// Abstrakcyjna metoda edycji danych o gościu
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="roomId"></param>
        void EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomId);
    }
}

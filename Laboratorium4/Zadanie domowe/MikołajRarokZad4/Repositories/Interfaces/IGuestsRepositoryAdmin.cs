using MikołajRarokZad4.ViewModels;
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
    public interface IGuestsRepositoryAdmin
    {
        /// <summary>
        /// Abstrakcyjna metoda pozwalajaca zwrocić
        /// tabelę gości
        /// </summary>
        /// <returns></returns>
        List<GuestAdminViewModel> GetGuests();

        /// <summary>
        /// Abstrakcyjna metoda dodania gościa
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="roomNumber"></param>
        /// <param name="bookedIn"></param>
        /// <param name="bookedOut"></param>
        /// <param name="breakfast"></param>
        /// <param name="lunch"></param>
        /// <param name="dinner"></param>
        /// <param name="gymAccess"></param>
        /// <param name="spaAccess"></param>
        /// <param name="poolAccess"></param>
        /// <returns></returns>
        bool AddGuest(string firstName, string lastName, string phoneNumber, int roomNumber,
            DateTime bookedIn, DateTime bookedOut, bool breakfast, bool lunch, bool dinner,
            bool gymAccess, bool spaAccess, bool poolAccess
            );

        /// <summary>
        /// Abstrakcyjna metoda usunięcia gościa
        /// </summary>
        /// <param name="guestId"></param>
        bool DeleteGuest(int guestId);

        /// <summary>
        /// Abstrakcyjna metoda edycji danych o gościu
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="roomNumber"></param>
        /// <param name="bookedIn"></param>
        /// <param name="bookedOut"></param>
        /// <param name="breakfast"></param>
        /// <param name="lunch"></param>
        /// <param name="dinner"></param>
        /// <param name="gymAccess"></param>
        /// <param name="spaAccess"></param>
        /// <param name="poolAccess"></param>
        /// <returns></returns>
        bool EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomNumber,
            DateTime bookedIn, DateTime bookedOut, bool breakfast, bool lunch, bool dinner,
            bool gymAccess, bool spaAccess, bool poolAccess
            );
    }
}

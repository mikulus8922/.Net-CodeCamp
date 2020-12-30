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
    /// Publiczna klasa definiująca metodody związane z gośćmi w wersji "admin"
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class GuestsRepositoryAdmin : Repository, IGuestsRepositoryAdmin
    {

        /// <summary>
        /// Metoda zwracająca tabelę
        /// gości w wersji "admin"
        /// </summary>
        /// <returns></returns>
        public List<GuestAdminViewModel> GetGuests()
        {
            List<Guest> guests = DbContext.Guests.ToList();
            return Mapper.Map<List<Guest>, List<GuestAdminViewModel>>(guests);
        }


        /// <summary>
        /// Metoda pozwalająca dodać gościa do bazy danych
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
        public bool AddGuest(string firstName, string lastName, string phoneNumber, int roomNumber,
            DateTime bookedIn, DateTime bookedOut, bool breakfast, bool lunch, bool dinner,
            bool gymAccess, bool spaAccess, bool poolAccess)
        {
            GuestBooking booking = DbContext.GuestsBooking.SingleOrDefault
                (g => g.BookedIn == bookedIn && g.BookedOut == bookedOut);
            GuestCatering catering = DbContext.GuestsCatering.SingleOrDefault
                (g => g.Breakfast == breakfast && g.Lunch == lunch && g.Dinner == dinner);
            GuestAccess access = DbContext.GuestsAccess.SingleOrDefault
                (g => g.GymAccess == gymAccess && g.SpaAccess == spaAccess && g.PoolAccess == poolAccess);

            if (booking == null || catering == null || access == null)
                return false;

            Guest guestToAdd = new Guest()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                RoomId = booking.Id,
                GuestAccessId = access.Id,
                GuestBookingId = booking.Id,
                GuestCateringId = catering.Id
            };

            DbContext.Guests.Add(guestToAdd);
            return DbContext.SaveChanges() > 0;
        }


        /// <summary>
        /// Metoda pozwalająca na usunięcie gościa z bazy danych
        /// </summary>
        /// <param name="guestId"></param>
        /// <returns></returns>
        public bool DeleteGuest(int guestId)
        {
            Guest guest = DbContext.Guests.SingleOrDefault(b => b.Id == guestId);
            DbContext.Guests.Remove(guest);
            return DbContext.SaveChanges() > 0;
        }


        /// <summary>
        /// Metoda pozwalająca na edytowanie danych o gościu w bazie danych
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
        public bool EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomNumber,
            DateTime bookedIn, DateTime bookedOut, bool breakfast, bool lunch, bool dinner,
            bool gymAccess, bool spaAccess, bool poolAccess)
        {
            Guest guest = DbContext.Guests.SingleOrDefault(b => b.Id == guestId);
            if (guest == null)
                return false;

            GuestBooking booking = DbContext.GuestsBooking.SingleOrDefault
                (g => g.BookedIn == bookedIn && g.BookedOut == bookedOut);
            GuestCatering catering = DbContext.GuestsCatering.SingleOrDefault
                (g => g.Breakfast == breakfast && g.Lunch == lunch && g.Dinner == dinner);
            GuestAccess access = DbContext.GuestsAccess.SingleOrDefault
                (g => g.GymAccess == gymAccess && g.SpaAccess == spaAccess && g.PoolAccess == poolAccess);

            if (booking == null || catering == null || access == null)
                return false;


            guest.FirstName = firstName;
            guest.LastName = lastName;
            guest.PhoneNumber = phoneNumber;
            guest.RoomId = booking.Id;
            guest.GuestAccess = access;
            guest.GuestBooking = booking;
            guest.GuestCatering = catering;

            return DbContext.SaveChanges() > 0;
        }


    }
}

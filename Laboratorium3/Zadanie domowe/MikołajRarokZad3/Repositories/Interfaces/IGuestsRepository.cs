using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public interface IGuestsRepository
    {
        DataTable GetGuests();

        void AddGuest(string firstName, string lastName, string phoneNumber, int roomId);

        void DeleteGuest(int guestId);

        void EditGuest(int guestId, string firstName, string lastName, string phoneNumber, int roomId);
    }
}

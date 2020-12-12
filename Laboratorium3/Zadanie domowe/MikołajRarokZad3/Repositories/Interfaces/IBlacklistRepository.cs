using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public interface IBlacklistRepository
    {
        DataTable GetBlacklist();

        void AddToBlacklist(string firstName, string lastName, string phoneNumber);

        void RemoveFromBlacklist(int blacklistId);

        void EditBlacklistedPerson(int Id, string firstName, string lastName, string phoneNumber);
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Publiczna klasa definiująca metodody związane z logowaniem
    /// </summary>
    public class UsersRepository : Repository, IUsersRepository
    {
        /// <summary>
        /// metoda sprawdzająca hasło i pozwalająca sie zalogować
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Login(string login, string password)
        {



            /*
            if (workPosition.Equals("SystemAdmin") || workPosition.Equals("Owner"))
                return "admin";
            if (workPosition.Equals("Receptionist"))
                return "receptionist";
            if (workPosition.Equals("CateringManager"))
                return "catering";
            */
            return "brak";
        }
    }
}

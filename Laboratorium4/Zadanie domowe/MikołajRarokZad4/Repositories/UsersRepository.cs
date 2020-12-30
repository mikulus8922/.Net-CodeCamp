using MikołajRarokZad4.Models.Entities;
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

            WorkerLoginData user = DbContext.WorkersLoginData.SingleOrDefault(u => u.Login == login && u.Password == password);

            
            if (user.WorkPosition.Equals("SystemAdmin") || user.WorkPosition.Equals("Owner"))
                return "admin";
            if (user.WorkPosition.Equals("Receptionist"))
                return "receptionist";
            if (user.WorkPosition.Equals("CateringManager"))
                return "catering";
            
            return "brak";
        }

        public bool Register(string login, string password, string workPosition)
        {
            //tworzym użytkownika który zostaje dodany
            WorkerLoginData userToAdd = new WorkerLoginData()
            {
                Login = login,
                Password = password,
                WorkPosition = workPosition
            };

            //sprawdzamy czy istnieje taki użytkownik w bazie
            WorkerLoginData foundedUser = DbContext.WorkersLoginData.FirstOrDefault(u => u.Login == login);
            if (foundedUser != null)
                return false;

            //dodajem użytkownika do bazy danych
            DbContext.WorkersLoginData.Add(userToAdd);

            //zapisujemy i zwracamy czy zapytanie rpzebiegło pomyslnie
            return DbContext.SaveChanges() > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją
    /// z bazą danych dla tabeli UsersRepository
    /// </summary>
    public interface IUsersRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda logowania
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// 
        /// <returns></returns>
        string Login(string login, string password);


        bool Register(string login, string password, string workPosition);
    }
}

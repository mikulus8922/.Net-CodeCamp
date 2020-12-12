using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna posiadająca zmienne i metody z których
    /// korzystają wszystkie repozytoria
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Zmienna przechowujaca połączenie z bazą danych
        /// </summary>
        protected readonly SqlConnection Connection;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Repository()
        {
            //Inicjalizacja połączenia z bazą danych
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}

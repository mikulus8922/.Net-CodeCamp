﻿using System.Data.SqlClient;

namespace CPC2020_2_Lab3.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Zmienna przechwująca połączenie z bazą danych
        /// </summary>
        protected readonly SqlConnection Connection;

     
        public Repository()
        {
            //Inicjalizacja połączenia z bazą danych
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}

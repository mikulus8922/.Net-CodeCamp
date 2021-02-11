using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna zawierająca metody związane
    /// ze wszystkimi repozytoriami
    /// </summary>
    public abstract class Repository
    {
        protected readonly SqlConnection Connection;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Repository()
        {
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}

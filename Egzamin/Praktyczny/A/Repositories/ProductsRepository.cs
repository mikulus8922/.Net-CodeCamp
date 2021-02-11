using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Repositories
{
    /// <summary>
    /// Repozytorium odpowiedzialne za operacje na produktach
    /// </summary>
    public class ProductsRepository : Repository, IProductsRepository
    {
        /// <summary>
        /// Funkcja zwracająca DataTable wypełnione produktami w przedziale cenowym 8-22 posortowane malejąco
        /// </summary>
        /// <returns></returns>
        public DataTable GetProducts()
        {
            string getEmployeesQuery = "SELECT * FROM Products WHERE UnitPrice BETWEEN 8 AND 22 ORDER BY UnitPrice DESC;";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getEmployeesQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }
    }
}

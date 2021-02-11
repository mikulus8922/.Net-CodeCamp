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
    /// Repozytorium odpowiedzialne za operacje na pracownikach
    /// </summary>
    public class EmployeesRepository : Repository, IEmployeesRepository
    {
        /// <summary>
        /// Funkcja zwracająca DataTable wypełnione pracownikami zaczynającymi się na M
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmployees()
        {
            string getEmployeesQuery = "SELECT * FROM Employees WHERE FirstName LIKE 'M%';";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getEmployeesQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        /// <summary>
        /// Funkcja zwracająca DataTable wypełnione pracownikami którzy nie mają przełożonych
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmployeesNotIn()
        {
            string getEmployeesQuery = "SELECT * FROM Employees WHERE ReportsTo IS NULL;";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getEmployeesQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }
    }
}

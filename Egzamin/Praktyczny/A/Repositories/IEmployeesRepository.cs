using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Repositories
{
    /// <summary>
    /// Interfejs zawierający metody związane z repozytorium pracowników
    /// </summary>
    public interface IEmployeesRepository
    {
        /// <summary>
        /// Abstrakcyjna funkcja
        /// </summary>
        /// <returns></returns>
        DataTable GetEmployees();

        /// <summary>
        /// Abstrakcyjna funkcja
        /// </summary>
        /// <returns></returns>
        DataTable GetEmployeesNotIn();

    }
}

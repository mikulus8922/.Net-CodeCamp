using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Repositories
{
    /// <summary>
    /// Interfejs zawierający metody związane z repozytorium produktów
    /// </summary>
    public interface IProductsRepository
    {
        /// <summary>
        /// Abstrakcyjna funkcja
        /// </summary>
        /// <returns></returns>
        DataTable GetProducts();
    }
}

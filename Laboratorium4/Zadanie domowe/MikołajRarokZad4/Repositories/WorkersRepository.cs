using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Publiczna klasa definiująca metodody związane z pracownikami 
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class WorkersRepository : Repository, IWorkersRepository
    {
        /// <summary>
        /// Metoda zwracająca tabelę
        /// pracownikami
        /// </summary>
        /// <returns></returns>
        public DataTable GetWorkers()
        {
            DataTable table = new DataTable();


            return table;
        }

        /// <summary>
        /// Metoda pozwalająca dodać pracownika do bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="workPosition"></param>
        public void AddWorker(string firstName, string lastName, string workPosition)
        {

        }

        /// <summary>
        /// Metoda pozwalająca na usunięcie pracownika z bazy danych
        /// </summary>
        /// <param name="workerId"></param>
        public void DeleteWorker(int workerId)
        {

        }


        /// <summary>
        /// Metoda pozwalająca na edytowanie danych o pracowniku w bazie danych
        /// </summary>
        /// <param name="workerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="workPosition"></param>
        public void EditWorker(int workerId, string firstName, string lastName, string workPosition)
        {


        }
    }
}

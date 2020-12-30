using MikołajRarokZad4.Models.Entities;
using MikołajRarokZad4.ViewModels;
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
        public List<WorkerViewModel> GetWorkers()
        {
            List<Worker> workers = DbContext.Workers.ToList();
            return Mapper.Map<List<Worker>, List<WorkerViewModel>>(workers);
        }

        /// <summary>
        /// Metoda pozwalająca dodać pracownika do bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="login"></param>
        public bool AddWorker(string firstName, string lastName, string login)
        {
            WorkerLoginData workerLogin = DbContext.WorkersLoginData.SingleOrDefault(w => w.Login == login);

            if (workerLogin == null)
                return false;

            Worker workerToAdd = new Worker()
            {
                FirstName = firstName,
                LastName = lastName,
                AccountId = workerLogin.Id
            };

            DbContext.Workers.Add(workerToAdd);

            return DbContext.SaveChanges() > 0;

        }

        /// <summary>
        /// Metoda pozwalająca na usunięcie pracownika z bazy danych
        /// </summary>
        /// <param name="workerId"></param>
        public bool DeleteWorker(int workerId)
        {
            Worker worker = DbContext.Workers.SingleOrDefault(w => w.Id == workerId);
            DbContext.Workers.Remove(worker);
            return DbContext.SaveChanges() > 0;
        }


        /// <summary>
        /// Metoda pozwalająca na edytowanie danych o pracowniku w bazie danych
        /// </summary>
        /// <param name="workerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public bool EditWorker(int workerId, string firstName, string lastName)
        {
            Worker worker = DbContext.Workers.SingleOrDefault(w => w.Id == workerId);
            if (worker == null)
                return false;

            worker.FirstName = firstName;
            worker.LastName = lastName;

            return DbContext.SaveChanges() > 0;
        }

        internal void AddWorker(string firstname, string lastName, object phoneNumber, string login)
        {
            throw new NotImplementedException();
        }
    }
}

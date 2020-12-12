using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public interface IWorkersRepository
    {
        DataTable GetWorkers();

        void AddWorker(string firstName, string lastName, string workPosition);

        void DeleteWorker(int workerId);

        void EditWorker(int workerId, string firstName, string lastName, string workPosition);

    }
}

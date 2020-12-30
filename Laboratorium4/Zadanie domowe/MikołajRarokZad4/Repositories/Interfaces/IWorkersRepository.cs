using MikołajRarokZad4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{   
     /// <summary>
     /// Interfejs definiujący metody związane z komunikacją
     /// z bazą danych dla tabeli WorkersRepository
     /// </summary>
    public interface IWorkersRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda pozwalajaca zwrocić
        /// tabelę przacowników
        /// </summary>
        /// <returns></returns>
        List<WorkerViewModel> GetWorkers();
        
        /// <summary>
        /// Abstrakcyjna metoda dodania pracownika
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="login"></param>
        bool AddWorker(string firstName, string lastName, string login);

        /// <summary>
        /// Abstrakcyjna metoda usunięcia pracownika
        /// </summary>
        /// <param name="workerId"></param>
        bool DeleteWorker(int workerId);

        /// <summary>
        /// Abstrakcyjna metoda edycji danych o pracowniku
        /// </summary>
        /// <param name="workerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        bool EditWorker(int workerId, string firstName, string lastName);

    }
}

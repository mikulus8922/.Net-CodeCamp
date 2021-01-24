using MikołajRarokZad7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Services
{
    public interface IWarehouseService
    {
        /// <summary>
        /// Zwraca wszystkie magazyny
        /// </summary>
        /// <returns></returns>
        List<Warehouse> Get();

        /// <summary>
        /// Dodaje nowy magazyn
        /// </summary>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        int Post(Warehouse warehouse);

        /// <summary>
        /// Edytuje wskazany magazyn
        /// </summary>
        /// <param name="warehouse"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Put(Warehouse warehouse, int id);

        /// <summary>
        /// Usuwa wskazany magazyn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}

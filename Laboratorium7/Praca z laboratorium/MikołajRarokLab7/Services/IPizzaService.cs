using MikołajRarokLab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokLab7.Services
{
    public interface IPizzaService
    {
        /// <summary>
        /// Zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        List<Pizza> Get();

        /// <summary>
        /// Dodaje nową pizzę
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        int Post(Pizza pizza);

        /// <summary>
        /// Edytuje wskazaną pizzę
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool Put(Pizza pizza, int id);

        /// <summary>
        /// Usuwa pizzę o wskazanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}

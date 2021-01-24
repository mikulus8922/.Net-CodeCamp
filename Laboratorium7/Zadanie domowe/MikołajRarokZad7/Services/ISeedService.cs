using MikołajRarokZad7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Services
{
    public interface ISeedService
    {
        /// <summary>
        /// Zwraca wszystkie nasiona
        /// </summary>
        /// <returns></returns>
        List<Seed> Get();

        /// <summary>
        /// Dodaje nowy rodzaj nasion
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        int Post(Seed seed);

        /// <summary>
        /// Edytuje wskazany rodzaj nasion
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        int Put(Seed seed, int id);

        /// <summary>
        /// Usuwa wskazany rodzaj nasion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

    }
}

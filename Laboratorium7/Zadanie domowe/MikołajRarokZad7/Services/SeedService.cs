using MikołajRarokZad7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Services
{
    public class SeedService : ISeedService
    {

        /// <summary>
        /// Prototypowa implementacja bazy danych nasion
        /// </summary>
        public static List<Seed> seeds = new List<Seed>()
        {
            new Seed()
            {
                Id = 0,
                Name = "Apple",
                Price = 0.99F,
                PlantingSeason = "Spring",
                WarehouseId = 0, 
                Amount = 1500,
            },
            new Seed()
            {
                Id = 1,
                Name = "Grape",
                Price = 1.99F,
                PlantingSeason = "Spring",
                WarehouseId = 0,
                Amount = 750,
            },
            new Seed()
            {
                Id = 2,
                Name = "Onion",
                Price = 0.49F,
                PlantingSeason = "Autumn",
                WarehouseId = 1,
                Amount = 10000,
            },
            new Seed()
            {
                Id = 3,
                Name = "Garlic",
                Price = 0.79F,
                PlantingSeason = "Autumn",
                WarehouseId = 1,
                Amount = 5000,
            }
        };

        /// <summary>
        /// Zwraca wszystkie nasiona 
        /// </summary>
        /// <returns></returns>
        public List<Seed> Get()
        {
            return seeds;
        }

        /// <summary>
        /// Dodaje nowy rodzaj nasion 
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public int Post(Seed seed)
        {
            int id;

            if(seeds.Count() == 0)
            {
                id = 0;
            }
            else
            {
                id = seeds.Max(x => x.Id) + 1;
            }

            //Sprawdzamy czy istnieje magazyn o danym Id
            if(WarehouseService.warehouses.FirstOrDefault(x => x.Id == seed.WarehouseId) == null)
            {
                return -1;
            }

            seed.Id = id;
            seeds.Add(seed);

            return id;
        }

        /// <summary>
        /// Edytuje wskazany rodzaj nasion
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Put(Seed seed, int id)
        {
            var seedToUpdate = seeds.Where(x => x.Id == id).SingleOrDefault();

            if(seedToUpdate == null)
            {
                return -2;
            }

            //Sprawdzamy czy istnieje magazyn o danym Id
            if (WarehouseService.warehouses.FirstOrDefault(x => x.Id == seed.WarehouseId) == null)
            {
                return -1;
            }

            seedToUpdate.Name = seed.Name;
            seedToUpdate.Price = seed.Price;
            seedToUpdate.PlantingSeason = seed.PlantingSeason;
            seedToUpdate.WarehouseId = seed.WarehouseId;
            seedToUpdate.Amount = seed.Amount;

            return 0;
        }

        /// <summary>
        /// Usuwa wskazany rodzaj nasion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var seedToDelete = seeds.Where(x => x.Id == id).SingleOrDefault();

            if(seedToDelete == null)
            {
                return false;
            }

            seeds.Remove(seedToDelete);

            return true;
        }
    }
}

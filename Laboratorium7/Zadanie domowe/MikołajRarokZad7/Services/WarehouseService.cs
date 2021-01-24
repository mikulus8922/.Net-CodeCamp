using MikołajRarokZad7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Services
{
    public class WarehouseService : IWarehouseService
    {
        /// <summary>
        /// Prototypowa implementacja bazy danych magazynów
        /// </summary>
        public static List<Warehouse> warehouses = new List<Warehouse>()
        {
            new Warehouse()
            {
                Id = 0,
                Name = "Fruits",
                Location = "Wroclaw"
            },
            new Warehouse()
            {
                Id = 1,
                Name = "Vegetables",
                Location = "Warszawa"
            }
        };

        /// <summary>
        /// Zwraca wszystkie magazyny
        /// </summary>
        /// <returns></returns>
        public List<Warehouse> Get()
        {
            return warehouses;
        }

        /// <summary>
        /// Dodaje nowy magazyn 
        /// </summary>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        public int Post(Warehouse warehouse)
        {
            int id;

            if (warehouses.Count() == 0)
            {
                id = 0;
            }
            else
            {
                id = warehouses.Max(x => x.Id) + 1;
            }

            warehouse.Id = id;
            warehouses.Add(warehouse);

            return id;
        }

        /// <summary>
        /// Edytuje wskazany magazyn 
        /// </summary>
        /// <param name="warehouse"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Warehouse warehouse, int id)
        {
            var warehouseToUpdate = warehouses.Where(x => x.Id == id).SingleOrDefault();

            if (warehouseToUpdate == null)
            {
                return false;
            }

            warehouseToUpdate.Name = warehouse.Name;
            warehouseToUpdate.Location = warehouse.Location;

            return true;
        }

        /// <summary>
        /// Usuwa wskazany magazyn 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var warehouseToDelete = warehouses.Where(x => x.Id == id).SingleOrDefault();

            if (warehouseToDelete == null)
            {
                return false;
            }

            warehouses.Remove(warehouseToDelete);

            return true;
        }
    }
}

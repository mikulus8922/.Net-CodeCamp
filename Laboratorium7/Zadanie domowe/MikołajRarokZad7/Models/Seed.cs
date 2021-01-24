using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Models
{
    /// <summary>
    /// Klasa reprezentująca strukturę danych nasiona
    /// </summary>
    public class Seed
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string PlantingSeason { get; set; }

        public int WarehouseId { get; set; }

        public int Amount { get; set; }
    }
}

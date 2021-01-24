using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Models
{
    /// <summary>
    /// Klasa resprezentująca strukturę danych magazynu
    /// </summary>
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Location { get; set; }
    }
}

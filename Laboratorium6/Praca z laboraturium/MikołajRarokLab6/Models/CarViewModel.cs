using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokLab6.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="photoPath"></param>
        public CarViewModel(string model, string manufacturer, decimal price, string photoPath)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhotoPath = photoPath;
        }
        

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public decimal Price { get; set; }

        public string PhotoPath { get; set; }
    }
}

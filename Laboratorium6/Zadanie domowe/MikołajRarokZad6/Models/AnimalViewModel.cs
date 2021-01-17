using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad6.Models
{
    /// <summary>
    /// ViewModel zwierząt
    /// </summary>
    public class AnimalViewModel
    {
        /// <summary>
        /// Konstruktor zawierający podstawowe
        /// dane o zwierzęciu
        /// </summary>
        /// <param name="animalName"></param>
        /// <param name="breed"></param>
        /// <param name="ownerName"></param>
        /// <param name="picturePath"></param>
        /// <param name="isADog"></param>
        public AnimalViewModel(string animalName, string breed, string ownerName,
            string picturePath, bool isADog)
        {
            this.AnimalName = animalName;
            this.Breed = breed;
            this.OwnerName = ownerName;
            this.PicturePath = picturePath;
            this.IsADog = isADog;
        }


        public string AnimalName { get; set; }

        public string Breed { get; set; }

        public string OwnerName { get; set; }

        public string PicturePath { get; set; }

        public bool IsADog { get; set; }
    }

}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MikołajRarokZad6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad6.Controllers
{
    public class HomeController : Controller
    {

        List<AnimalViewModel> allAnimals;
        

        public HomeController(ILogger<HomeController> logger)
        {
            //Uzupełnienie bazy danych zwierząt
            this.allAnimals = new List<AnimalViewModel>();
            allAnimals.Add(new AnimalViewModel("Star", "British Shorthair", "Lilliana Massey", "~/britishShorthair.jpg", false));
            allAnimals.Add(new AnimalViewModel("Echo", "Siamese", "Troy Perez", "~/siamese.jpg", false));
            allAnimals.Add(new AnimalViewModel("Rex", "Dalmatian", "Larissa Hope", "~/dalmatian.jpg", true));
            allAnimals.Add(new AnimalViewModel("Jade", "Bengal", "Troy Perez", "~/bengal.jpg", false));
            allAnimals.Add(new AnimalViewModel("Ember", "Shih Tzu", "Cristina Rivers", "~/shihTzu.png", true));
            allAnimals.Add(new AnimalViewModel("Donald", "German Shepherd", "Chris Wilkerson", "~/germanShepherd.jpg", true));

        }

        /// <summary>
        /// Funkcja zwracająca widok strony "początkowej"
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Funkcja zwracająca widok strony głównej
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult HomePage(UserGreetingsViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;

            return View();
        }

        /// <summary>
        /// Funkcja zwracająca widok strony ze wszystkimi zwierzętami
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllAnimals()
        {
            return View(this.allAnimals);
        }

        /// <summary>
        /// Funkcja zwracająca widok strony ze wszystkimi psami
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllDogs()
        {
            return View(this.allAnimals);
        }

        /// <summary>
        /// Funkcja zwracająca widok strony ze wszystkimi kotami
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllCats()
        {
            return View(this.allAnimals);
        }

        /// <summary>
        /// Funkcja zwracająca widok z listą wszystki dostępnych ras zwierząt
        /// </summary>
        /// <returns></returns>
        public IActionResult GetListOfBreeds()
        {
            List<string> allBreeds = new List<string>();

            foreach(var animal in allAnimals)
            {
                allBreeds.Add(animal.Breed);
            }

            return View(allBreeds);
        }

        /// <summary>
        /// Funkcja zwracająca widok z danymi konkretnego zwierzęcia
        /// </summary>
        /// <param name="selectedBreed"></param>
        /// <returns></returns>
        public IActionResult GetAnimalByBreed(string selectedBreed)
        {
            var animal = allAnimals.Where(a => a.Breed.ToLower() == selectedBreed.ToLower()).FirstOrDefault();

            return View(animal);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

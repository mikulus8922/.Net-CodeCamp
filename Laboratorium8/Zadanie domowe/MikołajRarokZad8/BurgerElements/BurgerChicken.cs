using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.BurgerElements
{
    /// <summary>
    /// Klasa opisująca chickenburger
    /// </summary>
    public class BurgerChicken : IBurger
    {
        /// <summary>
        /// Funkcja dodająca chickenburger do zamówienia
        /// </summary>
        /// <returns></returns>
        public string GetBurgerType()
        {
            return $"KurczakBurger - {Prices.chickenBurgerPrice}" +
                   "\n\nDodatki:";
        }
    }
}

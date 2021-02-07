using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.BurgerElements
{
    /// <summary>
    /// Klasa opisująca BBQ burger
    /// </summary>
    public class BurgerBBQ : IBurger
    {
        /// <summary>
        /// Funkcja dodająca BBQ burger do zamówienia
        /// </summary>
        /// <returns></returns>
        public string GetBurgerType()
        {
            return $"Burger BBQ - {Prices.BBQBurgerPrice}" +
                   "\n\nDodatki:";
        }
    }
}

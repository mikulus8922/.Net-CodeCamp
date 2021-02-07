using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.BurgerElements
{
    /// <summary>
    /// Klasa opisująca standardowy burger
    /// </summary>
    public class BurgerStandard : IBurger
    {
        /// <summary>
        /// Funkcja dodająca standardowy burger do zamówienia
        /// </summary>
        /// <returns></returns>
        public string GetBurgerType()
        {
            return $"Burger Standard - {Prices.standardBurgerPrice}" +
                   "\n\nDodatki:";
        }
    }
}

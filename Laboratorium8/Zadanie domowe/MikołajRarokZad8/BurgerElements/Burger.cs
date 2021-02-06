using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.BurgerElements
{
    public class Burger : IBurger
    {
        public string GetBurgerType()
        {
            return $"Burger - {Prices.standardBurgerPrice}" +
                   "\nDodatki:";
        }
    }
}

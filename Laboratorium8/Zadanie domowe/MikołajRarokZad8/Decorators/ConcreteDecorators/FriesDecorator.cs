
using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators.ConcreteDecorators
{
    /// <summary>
    /// Dekorator dodający frytki do zamówienia
    /// </summary>
    public class FriesDecorator : BurgerDecorator
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="burger"></param>
        public FriesDecorator(IBurger burger) : base(burger) { }

        /// <summary>
        /// Funkcja dodająca frytki do zamówienia
        /// </summary>
        /// <returns></returns>
        public override string GetBurgerType()
        {
            string type = base.GetBurgerType();
            type += $"\nFrytki - {Prices.friesPrice}";
            return type;
        }
    }
}

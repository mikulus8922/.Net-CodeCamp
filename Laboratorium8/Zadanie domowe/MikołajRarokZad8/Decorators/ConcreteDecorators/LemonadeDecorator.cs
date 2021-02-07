using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators.ConcreteDecorators
{
    /// <summary>
    /// Dekorator dodający lemoniadę do zamówienia
    /// </summary>
    public class LemonadeDecorator : BurgerDecorator
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="burger"></param>
        public LemonadeDecorator(IBurger burger) : base(burger) { }

        /// <summary>
        /// Funkcja dodająca lemoniadę do zamówienia
        /// </summary>
        /// <returns></returns>
        public override string GetBurgerType()
        {
            string type = base.GetBurgerType();
            type += $"\nLemoniada - {Prices.lemonadePrice}";
            return type;
        }
    }
}


using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators.ConcreteDecorators
{
    /// <summary>
    /// Dekorator dodający pepsi do zamówienia
    /// </summary>
    public class PepsiDecorator : BurgerDecorator
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="burger"></param>
        public PepsiDecorator(IBurger burger) : base(burger) { }

        /// <summary>
        /// Funkcja dodająca pepsi do zamówienia
        /// </summary>
        /// <returns></returns>
        public override string GetBurgerType()
        {
            string type = base.GetBurgerType();
            type += $"\nPepsi - {Prices.pepsiPrice}";
            return type;
        }
    }
}

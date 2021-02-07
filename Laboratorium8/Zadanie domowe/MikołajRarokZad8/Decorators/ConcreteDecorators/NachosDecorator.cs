
using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators.ConcreteDecorators
{
    /// <summary>
    /// Dekorator dodający nachosy do zamówienia
    /// </summary>
    public class NachosDecorator : BurgerDecorator
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="burger"></param>
        public NachosDecorator(IBurger burger) : base(burger) { }

        /// <summary>
        /// Funkcja dodajaca nachosy do zamówienia
        /// </summary>
        /// <returns></returns>
        public override string GetBurgerType()
        {
            string type = base.GetBurgerType();
            type += $"\nNachosy - {Prices.nachosPrice}";
            return type;
        }
    }
}

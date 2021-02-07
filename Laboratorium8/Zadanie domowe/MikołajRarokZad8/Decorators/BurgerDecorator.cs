
using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators
{
    /// <summary>
    /// Podstawowy dekorator
    /// </summary>
    public class BurgerDecorator : IBurger
    {
        private IBurger _burger;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="burger"></param>
        public BurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }

        /// <summary>
        /// Wirtualna funkcja dodająca odpowiednie dodatki do zamówienia
        /// </summary>
        /// <returns></returns>
        public virtual string GetBurgerType()
        {
            return _burger.GetBurgerType();
        }
    }
}

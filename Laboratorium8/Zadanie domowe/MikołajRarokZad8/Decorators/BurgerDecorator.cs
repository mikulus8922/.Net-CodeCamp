
using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators
{
    public class BurgerDecorator : IBurger
    {
        private IBurger _burger;

        public BurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }

        public virtual string GetBurgerType()
        {
            return _burger.GetBurgerType();
        }
    }
}

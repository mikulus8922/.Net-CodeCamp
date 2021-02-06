using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators.ConcreteDecorators
{
    public class LemonadeDecorator : BurgerDecorator
    {
        public LemonadeDecorator(IBurger burger) : base(burger) { }

        public override string GetBurgerType()
        {
            string type = base.GetBurgerType();
            type += $"\nLemoniada - {Prices.lemonadePrice}";
            return type;
        }
    }
}

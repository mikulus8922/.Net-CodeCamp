
using MikołajRarokZad8.BurgerElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad8.Decorators.ConcreteDecorators
{
    public class FriesDecorator : BurgerDecorator
    {
        public FriesDecorator(IBurger burger) : base(burger) { }

        public override string GetBurgerType()
        {
            string type = base.GetBurgerType();
            type += $"\nFrytki - {Prices.friesPrice}";
            return type;
        }
    }
}

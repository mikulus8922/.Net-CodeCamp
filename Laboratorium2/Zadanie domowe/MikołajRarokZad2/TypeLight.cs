using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    abstract class TypeLight : Champion
    {

        /// <summary>
        /// Uses stealth doubling its dexterity
        /// </summary>
        public override void UseTypeAbility()
        {
            //do napisania
        }

        /// <summary>
        /// Returns name of this particular
        /// type ability
        /// </summary>
        /// <returns></returns>
        public override string ReturnTypeAbilityName()
        {
            return "Stealth";
        }

    }
}

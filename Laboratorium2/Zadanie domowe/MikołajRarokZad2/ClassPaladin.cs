using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassPaladin : TypeHeavy
    {


        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Paladin class constructor
        /// </summary>
        public ClassPaladin()
        {
            HeroClass = "Paladin";
            Health = random.Next(500, 601);
            Defence = random.Next(15, 21);
            Damage = random.Next(75, 126);
            Accuracy = random.Next(75, 91);
            Dexterity = random.Next(5, 16);
            Inteligence = random.Next(15, 26);
            TypeAbility = random.Next(200, 301);
            ClassAbility = random.Next(50, 101);
        }

        /// <summary>
        /// Heal your entire team
        /// for a set amount
        /// </summary>
        public override void UseClassAbility()
        {
            //do napisania
        }

        /// <summary>
        /// Returns name of this particular
        /// class ability
        /// </summary>
        /// <returns></returns>
        public override string ReturnClassAbilityName()
        {
            return "Mass heal";
        }

    }
}

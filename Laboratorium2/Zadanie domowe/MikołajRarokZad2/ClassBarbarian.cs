using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassBarbarian : TypeHeavy
    {


        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Barbarian class constructor
        /// </summary>
        public ClassBarbarian()
        {
            HeroClass = "Barbarian";
            Health = random.Next(900, 1251);
            Defence = random.Next(30, 41);
            Damage = random.Next(50, 76);
            Accuracy = random.Next(60, 76);
            Dexterity = random.Next(0, 6);
            Inteligence = random.Next(5, 11);
            TypeAbility = random.Next(250, 501);
            ClassAbility = random.Next(1, 3);
        }

        /// <summary>
        /// Taunts the enemy team
        /// doubling the chance to
        /// be targeted by enemies
        /// for a set amount of turns
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
            return "Taunt";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassPriest : TypeMagical
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Shaman class constructor
        /// </summary>
        public ClassPriest()
        {
            HeroClass = "Priest";
            Health = random.Next(150, 251);
            Defence = random.Next(0, 6);
            Damage = random.Next(50, 101);
            Accuracy = random.Next(40, 61);
            Dexterity = random.Next(5, 16);
            Inteligence = random.Next(35, 41);
            TypeAbility = random.Next(200, 251);
            ClassAbility = random.Next(300, 401);
        }

        /// <summary>
        /// Heals an ally for a set amount
        /// </summary>
        public override void UseClassAbility()
        {
            //Do napisania
        }

        /// <summary>
        /// Returns name of this particular
        /// class ability
        /// </summary>
        /// <returns></returns>
        public override string ReturnClassAbilityName()
        {
            return "Direct heal";
        }
    }
}

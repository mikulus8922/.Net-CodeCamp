using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassAssasin : TypeLight
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Assasin class constructor
        /// </summary>
        public ClassAssasin()
        {
            HeroClass = "Assasin";
            Health = random.Next(250, 351);
            Defence = random.Next(0, 6);
            Damage = random.Next(300, 401);
            Accuracy = random.Next(40, 61);
            Dexterity = random.Next(30, 51);
            Inteligence = random.Next(25, 36);
            TypeAbility = 1;
            ClassAbility = 2;
        }

        /// <summary>
        /// Deal double damage to an enemy
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
            return "Backstab";
        }

    }
}

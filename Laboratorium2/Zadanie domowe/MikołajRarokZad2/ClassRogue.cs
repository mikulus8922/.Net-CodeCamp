using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassRogue : TypeLight
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Rogue class constructor
        /// </summary>
        public ClassRogue()
        {
            HeroClass = "Rogue";
            Health = random.Next(350, 401);
            Defence = random.Next(10, 16);
            Damage = random.Next(150, 251);
            Accuracy = random.Next(60, 76);
            Dexterity = random.Next(25, 36);
            Inteligence = random.Next(20, 26);
            TypeAbility = 3;
            ClassAbility = random.Next(40, 51);
        }

        /// <summary>
        /// Uses throwing daggers
        /// dealing % of damage to 3 enemies
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
            return "Throwing daggers";
        }

    }
}

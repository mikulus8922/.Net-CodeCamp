using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassWarlock : TypeMagical
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Warlock class constructor
        /// </summary>
        public ClassWarlock()
        {
            HeroClass = "Warlock";
            Health = random.Next(300, 451);
            Defence = random.Next(5, 11);
            Damage = random.Next(100, 151);
            Accuracy = random.Next(70, 81);
            Dexterity = random.Next(5, 16);
            Inteligence = random.Next(25, 31);
            TypeAbility = random.Next(200, 251);
            ClassAbility = random.Next(150, 251);
        }

        /// <summary>
        /// Sacrifices some health from an ally
        /// and deals tripple the amount to an enemy
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
            return "Consume soul";
        }

    }
}

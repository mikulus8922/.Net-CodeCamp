using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassShaman : TypeMagical
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Shaman class constructor
        /// </summary>
        public ClassShaman()
        {
            HeroClass = "Shaman";
            Health = random.Next(250, 351);
            Defence = random.Next(0, 6);
            Damage = random.Next(50, 101);
            Accuracy = random.Next(50, 76);
            Dexterity = random.Next(15, 26);
            Inteligence = random.Next(35, 41);
            TypeAbility = random.Next(200, 301);
            ClassAbility = random.Next(150, 201);
        }

        /// <summary>
        /// Buffs the next attack of allies
        /// by the set ammount
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
            return "Buff damage";
        }
    }
}

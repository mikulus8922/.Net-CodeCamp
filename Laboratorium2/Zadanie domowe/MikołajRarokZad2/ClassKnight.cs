using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassKnight : TypeHeavy
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Knight class constructor
        /// </summary>
        public ClassKnight()
        {
            HeroClass = "Knight";
            Health = random.Next(600, 751);
            Defence = random.Next(20, 26);
            Damage = random.Next(100, 151);
            Accuracy = random.Next(80, 96);
            Dexterity = random.Next(0, 11);
            Inteligence = random.Next(5, 11);
            TypeAbility = random.Next(300, 401);
            ClassAbility = random.Next(1, 3);
        }


        /// <summary>
        /// Forces this class to shield
        /// an ally and take any damage 
        /// dealt to it instead
        /// </summary>
        public override void UseClassAbility()
        {
            //do napisania;
        }

        /// <summary>
        /// Returns name of this particular
        /// class ability
        /// </summary>
        /// <returns></returns>
        public override string ReturnClassAbilityName()
        {
            return "Protect";
        }

    }
}

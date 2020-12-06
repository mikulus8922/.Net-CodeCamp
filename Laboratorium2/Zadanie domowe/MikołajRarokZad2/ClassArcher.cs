using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassArcher : TypeLight
    {
        /// <summary>
        /// % of base damage dealt
        /// to entire enemy team
        /// </summary>
        private int volley;

        public int Volley { get => volley; set => volley = value; }

        Random random = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Archer class constructor
        /// </summary>
        public ClassArcher()
        {
            HeroClass = "Archer";
            Health = random.Next(250, 301);
            Defence = random.Next(5, 11);
            Damage = random.Next(200, 251);
            Accuracy = random.Next(70, 81);
            Dexterity = random.Next(30, 41);
            Inteligence = random.Next(10, 16);
            TypeAbility = 2;
            ClassAbility = random.Next(25, 41);
        }

        /// <summary>
        /// Ability that damages
        /// the entire enemy team
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
            return "Volley";
        }
    }
}

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

        Random random = new Random();

        /// <summary>
        /// Archer class constructor
        /// </summary>
        public ClassArcher()
        {
            Health = random.Next(250, 300);
            Defence = random.Next(5, 10);
            Damage = random.Next(200, 250);
            Accuracy = random.Next(70, 80);
            Dexterity = random.Next(30, 40);
            Inteligence = random.Next(10, 15);
            Stealth = 2;
            Volley = random.Next(25, 40);
        }

        /// <summary>
        /// Ability that damages
        /// the entire enemy team
        /// </summary>
        public void UseVolley()
        {
            //do napisania
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassAssasin : TypeLight
    {
        /// <summary>
        /// Damage multiplier
        /// </summary>
        private int Backstab;

        public int Backstab1 { get => Backstab; set => Backstab = value; }

        Random random = new Random();

        /// <summary>
        /// Assasin class constructor
        /// </summary>
        public ClassAssasin()
        {
            HeroClass = "Assasin";
            Health = random.Next(250, 350);
            Defence = random.Next(0, 5);
            Damage = random.Next(300, 400);
            Accuracy = random.Next(40, 60);
            Dexterity = random.Next(30, 50);
            Inteligence = random.Next(25, 35);
            Stealth = 1;
            Backstab = 2;
        }

        /// <summary>
        /// Deal double damage to an enemy
        /// </summary>
        public void UseBackstab()
        {
            //do napisania
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassKnight : TypeHeavy
    {
        /// <summary>
        /// Amount of turns that
        /// an ally will be shielded for
        /// </summary>
        private int shield;

        public int Shield { get => shield; set => shield = value; }

        Random random = new Random();

        /// <summary>
        /// Knight class constructor
        /// </summary>
        public ClassKnight()
        {
            HeroClass = "Knight";
            Health = random.Next(600, 750);
            Defence = random.Next(20, 25);
            Damage = random.Next(100, 150);
            Accuracy = random.Next(80, 95);
            Dexterity = random.Next(0, 10);
            Inteligence = random.Next(5, 10);
            Armor = random.Next(300, 400);
            Shield = random.Next(1, 2);
        }


        /// <summary>
        /// Function that forces this class to shield
        /// an ally and take any damage dealt to it instead
        /// </summary>
        public void UseShield()
        {
            //do napisania;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassWarlock : TypeMagical
    {
        /// <summary>
        /// Amount of ally health
        /// consumed by warlock
        /// </summary>
        private int consumeSoul;

        public int ConsumeSoul { get => consumeSoul; set => consumeSoul = value; }

        Random random = new Random();

        /// <summary>
        /// Warlock class constructor
        /// </summary>
        public ClassWarlock()
        {
            HeroClass = "Warlock";
            Health = random.Next(300, 450);
            Defence = random.Next(5, 10);
            Damage = random.Next(100, 150);
            Accuracy = random.Next(70, 80);
            Dexterity = random.Next(5, 15);
            Inteligence = random.Next(25, 30);
            Mana = random.Next(200, 250);
            ConsumeSoul = random.Next(150, 250);
        }

        /// <summary>
        /// Sacrifices some health from an ally
        /// and deals tripple the amount to an enemy
        /// </summary>
        public void UseConsumeSoul()
        {
            //do napisania
        }


    }
}

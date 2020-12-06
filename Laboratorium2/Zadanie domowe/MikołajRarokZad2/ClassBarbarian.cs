using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassBarbarian : TypeHeavy
    {
        /// <summary>
        /// Amount of turns that
        /// this class will taunt
        /// the enemy team
        /// </summary>
        private int taunt;

        public int Taunt { get => taunt; set => taunt = value; }

        Random random = new Random();

        /// <summary>
        /// Barbarian class constructor
        /// </summary>
        public ClassBarbarian()
        {
            HeroClass = "Barbarian";
            Health = random.Next(900, 1250);
            Defence = random.Next(30, 40);
            Damage = random.Next(50, 75);
            Accuracy = random.Next(60, 75);
            Dexterity = random.Next(0, 5);
            Inteligence = random.Next(5, 10);
            Armor = random.Next(250, 500);
            Taunt = random.Next(1, 2);
        }

        /// <summary>
        /// Taunts the enemy team
        /// doubling the chance to
        /// be targeted by enemies
        /// </summary>
        public void UseTaunt()
        {
            //do napisania
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassRogue : TypeLight
    {
        /// <summary>
        /// % of base damage
        /// dealt by this ability
        /// </summary>
        private int throwingDaggers;

        public int ThrowingDaggers { get => throwingDaggers; set => throwingDaggers = value; }

        Random random = new Random();

        /// <summary>
        /// Rogue class constructor
        /// </summary>
        public ClassRogue()
        {
            Health = random.Next(350, 400);
            Defence = random.Next(10, 15);
            Damage = random.Next(150, 250);
            Accuracy = random.Next(60, 75);
            Dexterity = random.Next(25, 35);
            Inteligence = random.Next(20, 25);
            Stealth = 3;
            ThrowingDaggers = random.Next(40, 50);
        }

        /// <summary>
        /// Uses throwing daggers
        /// dealing damage to 3 enemies
        /// </summary>
        public void UseThrowingDaggers()
        {
            //do napisania
        }

    }
}

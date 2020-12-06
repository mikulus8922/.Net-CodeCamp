using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassPriest : TypeMagical
    {
        /// <summary>
        /// Amount of Health points healed
        /// </summary>
        private int directHeal;

        public int DirectHeal { get => directHeal; set => directHeal = value; }

        Random random = new Random();

        /// <summary>
        /// Shaman class constructor
        /// </summary>
        public ClassPriest()
        {
            HeroClass = "Priest";
            Health = random.Next(150, 250);
            Defence = random.Next(0, 5);
            Damage = random.Next(50, 100);
            Accuracy = random.Next(40, 60);
            Dexterity = random.Next(5, 15);
            Inteligence = random.Next(35, 40);
            Mana = random.Next(200, 250);
            DirectHeal = random.Next(300, 400);
        }

        /// <summary>
        /// Heals an ally for a set amount
        /// </summary>
        public void UseDirectHeal()
        {
            //Do napisania
        }
    }
}

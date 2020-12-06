using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassPaladin : TypeHeavy
    {
        /// <summary>
        /// Amount of health that this
        /// class will heal the entire team
        /// </summary>
        private int massHeal;

        public int MassHeal { get => massHeal; set => massHeal = value; }

        Random random = new Random();

        /// <summary>
        /// Paladin class constructor
        /// </summary>
        public ClassPaladin()
        {
            HeroClass = "Paladin";
            Health = random.Next(500, 600);
            Defence = random.Next(15, 20);
            Damage = random.Next(75, 125);
            Accuracy = random.Next(75, 90);
            Dexterity = random.Next(5, 15);
            Inteligence = random.Next(15, 25);
            Armor = random.Next(200, 300);
            MassHeal = random.Next(50, 100);
        }

        /// <summary>
        /// Heal your team
        /// </summary>
        public void UseMassheal()
        {
            //do napisania
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class ClassShaman : TypeMagical
    {
        /// <summary>
        /// Amount of bonus damage
        /// </summary>
        private int buffDamage;

        public int BuffDamage { get => buffDamage; set => buffDamage = value; }

        Random random = new Random();

        /// <summary>
        /// Shaman class constructor
        /// </summary>
        public ClassShaman()
        {
            Health = random.Next(250, 350);
            Defence = random.Next(0, 5);
            Damage = random.Next(50, 100);
            Accuracy = random.Next(50, 75);
            Dexterity = random.Next(15, 25);
            Inteligence = random.Next(35, 40);
            Mana = random.Next(200, 300);
            BuffDamage = random.Next(150, 200);
        }

        /// <summary>
        /// Buffs the next attack of allies
        /// by the set ammount
        /// </summary>
        public void UseDamageBuff()
        {
            //do napisania
        }
    }
}

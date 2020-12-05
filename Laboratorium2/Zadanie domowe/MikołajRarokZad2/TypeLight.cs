using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    abstract class TypeLight : Champion
    {
        /// <summary>
        /// Amount of turns that the champion
        /// will remain stealthed
        /// </summary>
        private int stealth;

        public int Stealth { get => stealth; set => stealth = value; }

        /// <summary>
        /// Uses stealth doubling its dexterity
        /// </summary>
        public void UseStealth()
        {
            //do napisania
        }
    }
}

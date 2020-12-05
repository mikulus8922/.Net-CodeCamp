using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    abstract class TypeHeavy : Champion
    {
        /// <summary>
        /// Amount of armor (unhealable bonus health)
        /// that a champion wil start a mission with
        /// </summary>
        private int armor;

        public int Armor { get => armor; set => armor = value; }
    }


}

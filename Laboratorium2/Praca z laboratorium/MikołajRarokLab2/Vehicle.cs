using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokLab2
{

    abstract class Vehicle
    {
        /// <summary>
        /// Nazwa marki pojazdu
        /// </summary>
        public string name = "Mercedes";
        /// <summary>
        /// Prędkość maksymalna pojazdu
        /// </summary>
        public int speed = 200;
        /// <summary>
        /// Maksymalna pojemność baku
        /// </summary>
        public int fuel = 100;


        /// <summary>
        /// Funkcja ruchu
        /// </summary>
        internal void Go()
        {
            speed++;
            fuel++;
        }
    }
}

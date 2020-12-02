using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokLab2
{
    class Bus:Vehicle
    {
        /// <summary>
        /// Ilość siedzeń w autobusie
        /// </summary>
        public int numberOfSeats = 30;

        /// <summary>
        /// Funkcja zatrzymująca autobus
        /// </summary>
        internal void stop()
        {
            speed = 0;
        }

    }
}

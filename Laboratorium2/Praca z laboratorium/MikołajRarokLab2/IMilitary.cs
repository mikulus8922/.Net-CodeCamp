using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokLab2
{
    interface IMilitary
    {

        /// <summary>
        /// Funkcja odpowiadajaca za strzal
        /// </summary>
        void shoot(int power);

        /// <summary>
        /// Funkcja malujaca pojazd na kolor wojskowy
        /// </summary>
        /// <returns></returns>
        System.Drawing.Color PaintMilitary();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokLab2
{
    interface IFlying
    {

        void fly(int time);

        System.Drawing.Color maskColor(int[] colorTable);

    }
}

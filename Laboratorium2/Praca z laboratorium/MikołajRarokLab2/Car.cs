using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokLab2
{
    class Car:Vehicle, IMilitary, IFlying
    {

        /// <summary>
        /// kolor pojazdu złożony z 3 liczb rgb
        /// </summary>
        public int[] color = {200, 0, 100};
        /// <summary>
        /// typ poszycia
        /// </summary>
        public string plating = "matowe";


        //Obiekt random potrzebny do losowania kolorow
        Random random = new Random();


        /// <summary>
        /// Konstruktor bezparametrowy
        /// </summary>
        public Car()
        {

        }


        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="fuel"></param>
        public Car(string name, int speed, int fuel)
        {
            Name = name;
            Speed = speed;
            Fuel = fuel;
        }

        /// <summary>
        /// Właściwości - bariera ochronna naszej klasy, przykład enkapsulacji (zastępują gettery i settery)
        /// </summary>
        public string Name { get { return "Marka samochodu" + name; } set { name = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Fuel { get { return fuel; } set { fuel = value; } }

        /// <summary>
        /// Funkcja wywołująca funkcję go tyle razy ile przekażemy w parametrze
        /// </summary>
        /// <param name="time"></param>
        public void fly(int time)
        {
            for (int i = 0; i < time; i++)
            {
                Go();
            }
        }

        /// <summary>
        /// Funkcja zmieniająca tło programu na kolor naszego obiektu
        /// </summary>
        /// <param name="colorTable"></param>
        public System.Drawing.Color maskColor(int[] colorTable)
        {
            return System.Drawing.Color.FromArgb(colorTable[0], colorTable[1], colorTable[2]);
        }


        /// <summary>
        /// Funkcja malująca tło ekranu programu an kolor khaki
        /// </summary>
        /// <returns></returns>
        public Color PaintMilitary()
        {
            return System.Drawing.Color.DarkKhaki;
        }

        public void shoot(int power)
        {
            fuel -= power;
        }


        /// <summary>
        /// Funkcja losujaca kolor
        /// </summary>
        internal void randomiseColor()
        {
            color[0] = random.Next(0, 255);
            color[1] = random.Next(0, 255);
            color[2] = random.Next(0, 255);
        }

    }
}

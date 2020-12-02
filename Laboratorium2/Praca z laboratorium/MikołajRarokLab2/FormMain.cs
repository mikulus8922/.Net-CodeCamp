using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokLab2
{
    public partial class FormMain : Form
    {
        //Pojazd testowy
        Car car;

        //Tworzenie listy obiektów typu car
        List<Car> cars = new List<Car>();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za tworzenie nowego obiektu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //Tworzenie nowego obiektu
            car = new Car();

            RepaintParameters();
        }

        /// <summary>
        /// Funkcja odświerzająca kontrolki
        /// </summary>
        private void RepaintParameters()
        {
            //Wypełnienie kontrolek danymi obiektu
            textBoxName.Text = car.name;
            textBoxSpeed.Text = car.speed.ToString();
            textBoxFuel.Text = car.fuel.ToString();
            buttonNew.BackColor = Color.FromArgb(car.color[0], car.color[1], car.color[2]);
            textBoxPlating.Text = car.plating;
        }

        /// <summary>
        /// Przycisk odpowiedzialny za rozpoczecie ruchu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                //Funkcja poruszania się pojazdu
                car.Go();
                RepaintParameters();
            }
            catch (Exception)
            {
                Console.WriteLine("Błąd przy funkcji go");
            }


        }

        /// <summary>
        /// Przycisk odpowiedzialny za wylosowanie nowego koloru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandomColor_Click(object sender, EventArgs e)
        {
            try
            {
                car.randomiseColor();
                RepaintParameters();
            }
            catch (Exception)
            {
                Console.WriteLine("Błąd przy funkcji randomiseColor");
            }
        }
        /// <summary>
        /// Przycisk wywołujący funkcje militarne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMilitary_Click(object sender, EventArgs e)
        {
            //przypisanie koloru khaki
            BackColor = car.PaintMilitary();
            //oddanie strzału
            car.shoot(10);

            RepaintParameters();
        }

        private void buttonFlying_Click(object sender, EventArgs e)
        {
            BackColor = car.maskColor(car.color);

        }

        /// <summary>
        /// Przycisk tworzący listę obiektów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonList_Click(object sender, EventArgs e)
        {
            cars.Add(new Car("Ferrari", 300, 40));
            cars.Add(new Car("Bentley", 250, 50));
            cars.Add(new Car("Audi", 150, 60));

            dataGridViewVehicle.DataSource = cars;
        }

        /// <summary>
        /// Przycisk wyszukujący pojazd na liście
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            //Wyszukanie samochodu po nazwie zdefiniowanej w textBox
            Car carFound = cars.Where(x => x.name == textBoxName.Text).FirstOrDefault();

            //Przypisanie danych do zdefiniowanego samochodu
            textBoxSpeed.Text = carFound.Speed.ToString();
            textBoxFuel.Text = carFound.Fuel.ToString();
            textBoxPlating.Text = carFound.plating.ToString();
        }
    }
}

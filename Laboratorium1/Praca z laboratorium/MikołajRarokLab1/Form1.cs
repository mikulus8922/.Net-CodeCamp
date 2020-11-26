using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokLab1
{
    public partial class FormMain : Form
    {

        //zmienna licznika
        int counter = 0;

        //zmienna nowego okna
        FormAbout formAbout;


        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk zmieniający kolor tła programu i przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            buttonColor.BackColor = Color.FromArgb(255, 0, 0);
        }

        /// <summary>
        /// Przycisk zmieniajacy kolor tla pierwszego przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeOtherButton1_Click(object sender, EventArgs e)
        {
            buttonChangeOtherButton2.BackColor = Color.Yellow;
        }

        /// <summary>
        /// Przycisk zmieniajacy kolor tla drugiego przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeOtherButton2_Click(object sender, EventArgs e)
        {
            buttonChangeOtherButton1.BackColor = Color.FromArgb(231,54,200);
        }

        /// <summary>
        /// Dodanie wartości do zmiennej z TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Zamiana typu String na Int
            counter = counter + Int32.Parse(textBoxCounter.Text);

            if (counter >= 2000000)
                counter = 0;

            //Zamiana typu liczbowego na String
            textBoxCounter.Text = counter.ToString();
        }

        /// <summary>
        /// Przycisk zmieniajacy kolor w zaleznosci od wartosci counter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTextboxColorChange_Click(object sender, EventArgs e)
        {
            buttonTextboxColorChange.BackColor = Color.FromArgb(counter % 256, (counter + 85) % 256, (counter + 170) % 256);
        }

        /// <summary>
        /// Przycisk uruchamiający licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerCounter.Start();
        }

        /// <summary>
        /// Funkcja obslugujaca wywolanie zegarowe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //inkrementacja zmiennej licznik
            counter++;
            //przypisanie wartosci licznika do pola tekstowego
            textBoxCounter.Text = counter.ToString();

            //zmiana wielkosci pierwszego przycisku
            buttonColor.Width =  (counter * 16) % 256;
            buttonColor.Height = (counter * 9) % 144;

        }

        /// <summary>
        /// Funkcja wywolywana po kliknieciu przycisku nowego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            formAbout = new FormAbout();
            formAbout.myName = "Mikołaj";
            formAbout.Show();
        }


        /// <summary>
        /// Funkcja mnozaca liczbe w textboxie powyzej z liczba ponizej
        /// i wypisujaca ja w textboxie ponizej 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyTwoTextboxes_Click(object sender, EventArgs e)
        {
            int product;
            product = Int32.Parse(textBoxMultipy1.Text) * Int32.Parse(textBoxMultiply2.Text);
            textBoxMultiply2.Text = product.ToString();
        }

    }
}

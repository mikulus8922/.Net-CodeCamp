using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikolajRarokZad1
{
    public partial class FormEventEtrapez : Form
    {
        public FormEventEtrapez()
        {
            InitializeComponent();
        }

        public String text = "";

        FormMessage formMessage;

        /// <summary>
        /// Funkcja powodująca zamknięcie okna w przypadku
        /// zrezygnowania z uczestnictwa w evencie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNo_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        /// <summary>
        /// Funcja sprawdzajaca czy random event przeszedł pomyślnie
        /// i dodająca nagrody/kary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            if(FormMain.IsEventWon == true)
            {
                FormMain.ECTS += 25000;
                formMessage = new FormMessage();
                formMessage.text =
                    "Pobranie kursu pozwala Ci\n" +
                    "bez przeszkód zdać analizę.\n" +
                    "Zysujesz 2,5 ECTSa!";
                formMessage.Show();
            }

            else
            {
                FormMain.Money -= 10000;
                formMessage = new FormMessage();
                formMessage.text =
                    "Piracenie oprogramowania\n" +
                    "tym razem nie było najlepszym\n" +
                    "pomysłem. Tracisz 10000 pieniędzy!";
                formMessage.Show();
            }

            this.Close();
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            labelEvent.Text = text;
        }

    }
}

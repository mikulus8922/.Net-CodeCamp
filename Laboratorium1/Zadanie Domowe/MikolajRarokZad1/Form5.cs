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
    public partial class FormEventTestownik : Form
    {
        public FormEventTestownik()
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
            if (FormMain.IsEventWon == true)
            {
                FormMain.ECTS += 30000;
                formMessage = new FormMessage();
                formMessage.text =
                    "Może i nieetycznie\n" +
                    "ale udaje Ci się zdać kurs.\n" +
                    "Zysujesz 3 ECTSy!";
                formMessage.Show();
            }

            else
            {
                FormMain.ECTS = FormMain.ECTS + 20000;
                formMessage = new FormMessage();
                formMessage.text =
                    "Jak na złość prowadzący\n" +
                    "wyjątkowa kazał wysyłać całe\n" +
                    "rozwiązania zadań. Tracisz 2 ECTSy";
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


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


        private void buttonNo_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
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

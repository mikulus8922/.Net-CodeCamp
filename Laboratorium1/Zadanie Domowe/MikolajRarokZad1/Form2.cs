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
    public partial class FormMessage : System.Windows.Forms.Form
    {

        public String text = "";

        public FormMessage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja przypisujaca tresc naszej wiadomosci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMessage_Load(object sender, EventArgs e)
        {
            
            labelMessage.Text = text;
        }

        /// <summary>
        /// Przycisk zamykajacy okno pomocnicze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

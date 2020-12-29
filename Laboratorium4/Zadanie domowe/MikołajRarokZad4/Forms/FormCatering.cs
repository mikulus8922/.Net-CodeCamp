using MikołajRarokZad4.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokZad4.Forms
{
    /// <summary>
    /// Klasa odpowiedzialna za funkcjonalność
    /// okna FormCateting
    /// </summary>
    public partial class FormCatering : Form
    {
        DataTable guests;


        GuestsRepositoryCatering guestsRepositoryCatering = new GuestsRepositoryCatering();

        public FormCatering()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Funkcja odświeżająca dane o gościach
        /// </summary>
        private void RefreshDataGridViewWithGuests()
        {
            guests = guestsRepositoryCatering.GetGuests();

            dataGridViewMain.DataSource = guests;
        }

        /// <summary>
        /// Przycisk pozwalający wyświetlić dane o gościach
        /// </summary>
        private void buttonShowGuests_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithGuests();
        }


    }
}

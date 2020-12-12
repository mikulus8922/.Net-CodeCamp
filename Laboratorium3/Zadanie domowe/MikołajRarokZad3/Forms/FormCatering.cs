using MikołajRarokZad3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokZad3.Forms
{
    public partial class FormCatering : Form
    {
        DataTable guests;


        GuestsRepositoryCatering guestsRepositoryCatering = new GuestsRepositoryCatering();

        public FormCatering()
        {
            InitializeComponent();
        }


        private void ClearTextBoxes()
        {
            textBoxGuestId.Text = "";
            textBoxGuestFirstName.Text = "";
            textBoxGuestLastName.Text = "";
            textBoxPhoneNumber.Text = "";

        }


        private void RefreshDataGridViewWithGuests()
        {
            guests = guestsRepositoryCatering.GetGuests();

            dataGridViewMain.DataSource = guests;
        }

        private void buttonShowGuests_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithGuests();
        }
    }
}

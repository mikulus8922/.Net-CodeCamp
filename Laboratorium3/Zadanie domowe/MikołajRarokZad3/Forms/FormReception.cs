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
    public partial class FormReception : Form
    {
        DataTable rooms;
        DataTable blacklist;

        RoomsRepository roomsRepository = new RoomsRepository();
        BlacklistRepository blacklistRepository = new BlacklistRepository();

        public FormReception()
        {
            InitializeComponent();
        }


        private void ClearTextBoxes()
        {
            textBoxRoomId.Text = "";
            textBoxRoomNumber.Text = "";
            textBoxRoomCapacity.Text = "";
            textBoxRoomFloor.Text = "";
            textBoxRoomId.Text = "";

            textBoxBlacklistId.Text = "";
            textBoxBlacklistFirstName.Text = "";
            textBoxBlacklistLastName.Text = "";
            textBoxBlacklistPhoneNumber.Text = "";

        }

        private void RefreshDataGridViewWithRooms()
        {
            rooms = roomsRepository.GetRooms();

            dataGridViewMain.DataSource = rooms;
        }


        private void buttonShowRooms_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithRooms();
        }


        private void buttonEditRoom_Click(object sender, EventArgs e)
        {

            int roomId = int.Parse(textBoxRoomId.Text);
            int roomCapacity = int.Parse(textBoxRoomCapacity.Text);
           

            roomsRepository.EditRoomCapacity(roomId, roomCapacity);

            RefreshDataGridViewWithRooms();
            ClearTextBoxes();
            
        }
           
        private void RefreshDataGridViewWithBlacklist()
        {
            blacklist = blacklistRepository.GetBlacklist();

            dataGridViewMain.DataSource = blacklist;
        }

        private void buttonShowBlacklist_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithBlacklist();
        }

        private void buttonAddToBlacklist_Click(object sender, EventArgs e)
        {
            string firstName = textBoxBlacklistFirstName.Text;
            string lastName = textBoxBlacklistLastName.Text;
            string phoneNumber = textBoxBlacklistPhoneNumber.Text;

            blacklistRepository.AddToBlacklist(firstName, lastName, phoneNumber);

            RefreshDataGridViewWithBlacklist();
            ClearTextBoxes();
        }

        private void buttonRemoveFromBlacklist_Click(object sender, EventArgs e)
        {
            int blacklistId = int.Parse(textBoxBlacklistId.Text);


            blacklistRepository.RemoveFromBlacklist(blacklistId);

            RefreshDataGridViewWithBlacklist();
            ClearTextBoxes();
        }

        private void buttonEditBlacklist_Click(object sender, EventArgs e)
        {
            int blacklistId = int.Parse(textBoxBlacklistId.Text);
            string firstName = textBoxBlacklistFirstName.Text;
            string lastName = textBoxBlacklistLastName.Text;
            string phoneNumber = textBoxBlacklistPhoneNumber.Text;

            blacklistRepository.EditBlacklistedPerson(blacklistId, firstName, lastName, phoneNumber);

            RefreshDataGridViewWithBlacklist();
            ClearTextBoxes();
        }
    }
}

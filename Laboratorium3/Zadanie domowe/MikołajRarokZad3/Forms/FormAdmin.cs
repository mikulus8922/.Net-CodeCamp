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
    public partial class FormAdmin : Form
    {
        DataTable rooms;
        DataTable blacklist;
        DataTable workers;
        DataTable guests;

        RoomsRepository roomsRepository = new RoomsRepository();
        BlacklistRepository blacklistRepository = new BlacklistRepository();
        WorkersRepository workersRepository = new WorkersRepository();
        GuestsRepositoryAdmin guestsRepositoryAdmin = new GuestsRepositoryAdmin();

        public FormAdmin()
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

            textBoxWorkerId.Text = "";
            textBoxWorkerFirstName.Text = "";
            textBoxWorkerLastName.Text = "";
            textBoxWorkerWorkPosition.Text = "";
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

        private void RefreshDataGridViewWithWorkers()
        {
            workers = workersRepository.GetWorkers();

            dataGridViewMain.DataSource = workers;
        }

        private void buttonShowWorkers_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithWorkers();
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            
            string firstname = textBoxWorkerFirstName.Text;
            string lastName = textBoxWorkerLastName.Text;
            string workPosition = textBoxWorkerWorkPosition.Text;

            workersRepository.AddWorker(firstname, lastName, workPosition);

            RefreshDataGridViewWithWorkers();
            ClearTextBoxes();
        }

        private void buttonRemoveWorker_Click(object sender, EventArgs e)
        {
            int workerId = int.Parse(textBoxWorkerId.Text);

            workersRepository.DeleteWorker(workerId);

            RefreshDataGridViewWithWorkers();
            ClearTextBoxes();
        }

        private void buttonEditWorker_Click(object sender, EventArgs e)
        {
            int workerId = int.Parse(textBoxWorkerId.Text);
            string firstName = textBoxWorkerFirstName.Text;
            string lastName = textBoxWorkerLastName.Text;
            string workPosition = textBoxWorkerWorkPosition.Text;

            workersRepository.EditWorker(workerId, firstName, lastName, workPosition);

            RefreshDataGridViewWithWorkers();
            ClearTextBoxes();
        }


        private void RefreshDataGridViewWithGuests()
        {
            guests = guestsRepositoryAdmin.GetGuests();

            dataGridViewMain.DataSource = guests;
        }

        private void buttonShowGuests_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithGuests();
        }
    }
}

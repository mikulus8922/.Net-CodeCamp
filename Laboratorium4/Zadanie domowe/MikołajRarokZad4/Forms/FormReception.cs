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
    /// okna FormReception
    /// </summary>
    public partial class FormReception : Form
    {

        RoomsRepository roomsRepository = new RoomsRepository();
        BlacklistRepository blacklistRepository = new BlacklistRepository();
        GuestsRepositoryAdmin guestsRepositoryAdmin = new GuestsRepositoryAdmin();

        public FormReception()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja czyszcząca textboxy
        /// </summary>
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

        /// <summary>
        /// Funkcja odświeżająca dane o pokojach
        /// </summary>
        private void RefreshDataGridViewWithRooms()
        {
            dataGridViewMain.DataSource = roomsRepository.GetRooms();
        }

        /// <summary>
        /// Przycisk wyświetlający pokoje w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowRooms_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithRooms();
        }

        /// <summary>
        /// Przycisk pozwalający zmienić ilość osób w pokoju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditRoom_Click(object sender, EventArgs e)
        {

            int roomId = int.Parse(textBoxRoomId.Text);
            int roomCapacity = int.Parse(textBoxRoomCapacity.Text);
           

            roomsRepository.EditRoomCapacity(roomId, roomCapacity);

            RefreshDataGridViewWithRooms();
            ClearTextBoxes();
            
        }

        /// <summary>
        /// Funkcja odświeżająca dane o czarnej liście
        /// </summary>
        private void RefreshDataGridViewWithBlacklist()
        {
            dataGridViewMain.DataSource = blacklistRepository.GetBlacklist();
        }

        /// <summary>
        /// Przycisk pozwalający wyświetlić czarną listę
        /// </summary>
        private void buttonShowBlacklist_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewWithBlacklist();
        }

        /// <summary>
        /// Przycisk pozwalający dodać osobę do czarnej listy
        /// </summary>
        private void buttonAddToBlacklist_Click(object sender, EventArgs e)
        {
            string firstName = textBoxBlacklistFirstName.Text;
            string lastName = textBoxBlacklistLastName.Text;
            string phoneNumber = textBoxBlacklistPhoneNumber.Text;

            blacklistRepository.AddToBlacklist(firstName, lastName, phoneNumber);

            RefreshDataGridViewWithBlacklist();
            ClearTextBoxes();
        }

        /// <summary>
        /// Przycisk pozwalający usunąć osobę z czarnej listy
        /// </summary>
        private void buttonRemoveFromBlacklist_Click(object sender, EventArgs e)
        {
            int blacklistId = int.Parse(textBoxBlacklistId.Text);


            blacklistRepository.RemoveFromBlacklist(blacklistId);

            RefreshDataGridViewWithBlacklist();
            ClearTextBoxes();
        }

        /// <summary>
        /// Przycisk pozwalający zmienić dane osoby na czarnej liście
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funkcja odświeżająca dane o gościach
        /// </summary>
        private void RefreshDataGridViewWithGuests()
        {
            dataGridViewMain.DataSource = guestsRepositoryAdmin.GetGuests();
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

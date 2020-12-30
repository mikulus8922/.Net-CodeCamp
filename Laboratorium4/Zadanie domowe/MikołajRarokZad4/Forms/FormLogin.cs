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
    /// okna FormLogin
    /// </summary>
    public partial class FormLogin : Form
    {
        UsersRepository usersRepository = new UsersRepository();


        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk realizujący funkcję próby zalogowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTryToLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            string loginType = usersRepository.Login(login, password);

            if (loginType == "admin")
            {
                Program.loginType = "admin";
                Close();
            }
            if (loginType == "receptionist")
            {
                Program.loginType = "receptionist";
                Close();
            }
            if (loginType == "catering")
            {
                Program.loginType = "catering";
                Close();
            }

            MessageBox.Show("Niepoprawny login lub hasło!");
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonTryToRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string workPosition = textBoxWorkPosition.Text;

            //wywołujemy metode rejestracji i wyświetlamy stosowny komunikat w zależności d tego co zwraca
            if (usersRepository.Register(login, password, workPosition))
            {
                MessageBox.Show("Konto zostało utworzone, możesz się teraz zalogować");
            }
            else
            {
                MessageBox.Show("Taki użytkownik już istnieje");
            }
        }
    }
}

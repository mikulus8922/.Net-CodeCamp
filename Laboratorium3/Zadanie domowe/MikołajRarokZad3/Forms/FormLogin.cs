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
    public partial class FormLogin : Form
    {
        UsersRepository usersRepository = new UsersRepository();


        public FormLogin()
        {
            InitializeComponent();
        }


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
    }
}

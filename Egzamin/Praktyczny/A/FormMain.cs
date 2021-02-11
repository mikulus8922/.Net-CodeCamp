using A.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class FormMain : Form
    {
        //Zmienna przechowywująca ilość logowań
        int numberOfTries = 0;

        //Zmienne wykorzystywane przy wypełnianiu datagridview
        DataTable employees;
        DataTable products;
        EmployeesRepository employeesRepository = new EmployeesRepository();
        ProductsRepository productsRepository = new ProductsRepository();

        public FormMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Przycisk odpowiadający za logowanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "admin" && textBoxPassword.Text == "test")
            {
                labelLoggedIn.Visible = true;
            }
            else
            {
                if(numberOfTries >= 2)
                {
                    textBoxLogin.Visible = false;
                    textBoxPassword.Visible = false;
                }
                numberOfTries++;
            }
        }

        /// <summary>
        /// Przycisk rozpoczynający timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShift_Click(object sender, EventArgs e)
        {
            timerMain.Start();

        }

        /// <summary>
        /// Funkcja wykonywująca sie co jeden tick timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            buttonShift.Location = new Point(buttonShift.Location.X + 5, buttonShift.Location.Y - 5);

        }



        /// <summary>
        /// Przycisk wypełniający datagridview pracownikami o zadanych parametrach (imię na M)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            employees = employeesRepository.GetEmployees();

            dataGridViewMain.DataSource = employees;
        }

        /// <summary>
        /// Przycisk wypełniający datagridview pracownikami o zadanych parametrach (bez przełożonych)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNotIn_Click(object sender, EventArgs e)
        {
            employees = employeesRepository.GetEmployeesNotIn();

            dataGridViewMain.DataSource = employees;
        }


        /// <summary>
        /// Przycisk wypełniający datagridview produktami o zadanych parametrach (cena 8-22)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            products = productsRepository.GetProducts();
            dataGridViewMain.DataSource = products;
        }


    }
}

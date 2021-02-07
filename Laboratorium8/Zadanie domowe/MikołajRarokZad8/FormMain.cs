using MikołajRarokZad8.BurgerElements;
using MikołajRarokZad8.Decorators.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokZad8
{
    public partial class FormBurger : Form
    {

        // Pole przechowujące obiekt burgera
        IBurger burger;

        // Pola przechowujące zmienne związane z obliczaniem łącznej ceny 
        double itemPrice = 0;
        double totalPrice = 0;

        public FormBurger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja odświerzająca labele
        /// </summary>
        private void refreshLabels()
        {
            labelBurgerInfo.Text = burger.GetBurgerType();
            totalPrice += itemPrice;
            labelTotalPrice.Text = $"Razem: {totalPrice}";
        }

        /// <summary>
        /// Funkcja ustawiająca tryb wyboru dodatków
        /// </summary>
        private void enableExtras()
        {
            buttonStandardBurger.Enabled = false;
            buttonBBQBurger.Enabled = false;
            buttonChickenBurger.Enabled = false;

            buttonFries.Enabled = true;
            buttonNachos.Enabled = true;
            buttonPepsi.Enabled = true;
            buttonLemonade.Enabled = true;
            buttonNextBurger.Enabled = true;
        }

        /// <summary>
        /// Funkcja ustawiająca tryb wyboru burgerów
        /// </summary>
        private void enableBurgers()
        {
            buttonStandardBurger.Enabled = true;
            buttonBBQBurger.Enabled = true;
            buttonChickenBurger.Enabled = true;

            buttonFries.Enabled = false;
            buttonNachos.Enabled = false;
            buttonPepsi.Enabled = false;
            buttonLemonade.Enabled = false;
            buttonNextBurger.Enabled = false;
        }

        /// <summary>
        /// Funkcja ustawiająca odpowiedni tekst na przyciskach
        /// i labelach po otworzeniu programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBurger_Load(object sender, EventArgs e)
        {
            buttonStandardBurger.Text = $"Standard - {Prices.standardBurgerPrice}";
            buttonBBQBurger.Text = $"BBQ Burger - {Prices.BBQBurgerPrice}";
            buttonChickenBurger.Text = $"Kurczakburger - {Prices.chickenBurgerPrice}";

            buttonFries.Text = $"Frytki - {Prices.friesPrice}";
            buttonNachos.Text = $"Nachosy - {Prices.nachosPrice}";
            buttonPepsi.Text = $"Pepsi - {Prices.pepsiPrice}";
            buttonLemonade.Text = $"Lemoniada - {Prices.lemonadePrice}";

            labelBurgerInfo.Text = "";
            labelTotalPrice.Text = "";

            enableBurgers();
        }

        /// <summary>
        /// Przycisk dodający nowego standardowego burgera do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStandardBurger_Click(object sender, EventArgs e)
        {
            burger = new BurgerStandard();
            itemPrice = Prices.standardBurgerPrice;
            enableExtras();
            refreshLabels();
        }

        /// <summary>
        /// Przycisk dodający nowego BBQ burgera do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBBQBurger_Click(object sender, EventArgs e)
        {
            burger = new BurgerBBQ();
            itemPrice = Prices.BBQBurgerPrice;
            enableExtras();
            refreshLabels();
        }

        /// <summary>
        /// Przycisk dodający nowego kurczakburgera do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChickenBurger_Click(object sender, EventArgs e)
        {
            burger = new BurgerChicken();
            itemPrice = Prices.chickenBurgerPrice;
            enableExtras();
            refreshLabels();
        }

        /// <summary>
        /// Przycisk dodający frytki do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFries_Click(object sender, EventArgs e)
        {
            burger = new FriesDecorator(burger);
            itemPrice = Prices.friesPrice;
            refreshLabels();
        }

        /// <summary>
        /// Przycisk dodający nachosy do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNachos_Click(object sender, EventArgs e)
        {
            burger = new NachosDecorator(burger);
            itemPrice = Prices.nachosPrice;
            refreshLabels();
        }

        /// <summary>
        /// Przycisk dodający pepsi do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPepsi_Click(object sender, EventArgs e)
        {
            burger = new PepsiDecorator(burger);
            itemPrice = Prices.pepsiPrice;
            refreshLabels();
        }

        /// <summary>
        /// Przycisk dodający lemoniadę do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLemonade_Click(object sender, EventArgs e)
        {
            burger = new LemonadeDecorator(burger);
            itemPrice = Prices.lemonadePrice;
            refreshLabels();
        }

        /// <summary>
        /// Przycisk umożliwiający wybranie kolejnego burgera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextBurger_Click(object sender, EventArgs e)
        {
            enableBurgers();
            labelBurgerInfo.Text = "";
        }

        /// <summary>
        /// Przycisk kończący zamówienie (w obecnej implementacji wyłącza program)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFinalize_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        IBurger burger;

        double itemPrice = 0;
        double totalPrice = 0;

        public FormBurger()
        {
            InitializeComponent();
        }

        private void refreshLabels()
        {
            labelBurgerInfo.Text = burger.GetBurgerType();
            totalPrice += itemPrice;
            labelTotalPrice.Text = $"Razem: {totalPrice}";
        }

        private void FormBurger_Load(object sender, EventArgs e)
        {
            buttonStandardBurger.Text = $"Standard - {Prices.standardBurgerPrice}";

            buttonFries.Text = $"Frytki - {Prices.friesPrice}";
            buttonNachos.Text = $"Nachosy - {Prices.nachosPrice}";
            buttonPepsi.Text = $"Pepsi - {Prices.pepsiPrice}";
            buttonLemonade.Text = $"Lemoniada - {Prices.lemonadePrice}";

            labelBurgerInfo.Text = "";
            labelTotalPrice.Text = "";
        }

        private void buttonStandardBurger_Click(object sender, EventArgs e)
        {
            burger = new Burger();
            itemPrice = Prices.standardBurgerPrice;
            refreshLabels();
        }

        private void buttonFries_Click(object sender, EventArgs e)
        {
            burger = new FriesDecorator(burger);
            itemPrice = Prices.friesPrice;
            refreshLabels();
        }

        private void buttonNachos_Click(object sender, EventArgs e)
        {
            burger = new NachosDecorator(burger);
            itemPrice = Prices.nachosPrice;
            refreshLabels();
        }

        private void buttonPepsi_Click(object sender, EventArgs e)
        {
            burger = new PepsiDecorator(burger);
            itemPrice = Prices.pepsiPrice;
            refreshLabels();
        }

        private void buttonLemonade_Click(object sender, EventArgs e)
        {
            burger = new LemonadeDecorator(burger);
            itemPrice = Prices.lemonadePrice;
            refreshLabels();
        }
    }
}

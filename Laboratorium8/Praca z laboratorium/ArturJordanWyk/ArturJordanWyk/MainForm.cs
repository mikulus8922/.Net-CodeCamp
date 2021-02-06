using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArturJordanWyk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wzorzec projektowy budowniczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuilder_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat.Builder().Name("Mruczek").Description("Kot domowy").Build();
            Console.WriteLine(cat);
        }

        /// <summary>
        /// Wzorzec projektowy fasada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFacade_Click(object sender, EventArgs e)
        {
            //Utowrzenie zmiennych z przykładowymi systemami
            ComplexSystemA complexSystemA = new ComplexSystemA();
            ComplexSystemB complexSystemB = new ComplexSystemB();

            // tworzenie obiektu fasady
            Facade facade = new Facade(complexSystemA, complexSystemB);
            
            //wykonanie zredukowanych operacji
            string result = facade.Operation();
            Console.WriteLine(result);
        }
    }
}

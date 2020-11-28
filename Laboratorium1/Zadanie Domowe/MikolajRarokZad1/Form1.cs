using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikolajRarokZad1
{
    public partial class FormMain : Form
    {
       
        // Statystyki
        double ECTS = 0;
        double ECTSPerClick = 1;
        double ECTSPerTick = 0;

        double Money = 300;
        double MoneyPerClick = 10;
        double MoneyPerTick = 0;

        double RandomBoost = 0;

        // Poziomy ulepszeń        
        int ECTSPerClickLvl = 0;
        int ECTSPerTickLvl = 0;

        int MoneyPerClickLvl = 0;
        int MoneyPerTickLvl = 0;

        int RandomBoostLvl = 0;

        // Tablice związane z kosztami ulepszeń w formacie
        // {{KosztEctsLvl1,KosztPieniedzyLvl1},
        // {KosztEctsLvl2, KosztPieniedzyLvl2}}
        double[,] ECTSPerClickCosts = new double[5, 2] {
        {50, 0},
        {250, 500},
        {1000, 2500},
        {5000, 10000},
        {10000, 300000}
        };

        double[,] ECTSPerTickCosts = new double[5, 2] {
        {50, 0},
        {250, 0},
        {1000,0},
        {5000,0},
        {10000,2000}
        };

        double[,] MoneyPerClickCosts = new double[5, 2] {
        {50, 0},
        {250, 0},
        {1000,0},
        {5000,0},
        {10000,2000}
        };

        double[,] MoneyPerTickCosts = new double[5, 2] {
        {50, 0},
        {250, 0},
        {1000,0},
        {5000,0},
        {10000,2000}
        };

        double[,] RandomBoostCosts = new double[5, 2] {
        {50, 0},
        {250, 0},
        {1000,0},
        {5000,0},
        {10000,2000}
        };




        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Główna pętla gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            ECTS += ECTSPerTick;
            Money += MoneyPerTick;

            CheckForAvailableGameEvents();
        }

        /// <summary>
        /// Funkcja sprawdzajaca i wywołująca eventy
        /// </summary>
        private void CheckForAvailableGameEvents()
        {

        }

        /// <summary>
        /// Podstawowy przycisk zwiekszajacy nasze ECTSy po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonECTS_Click(object sender, EventArgs e)
        {
            ECTS += ECTSPerClick;
        }

        /// <summary>
        /// Podstawowy przycisk zwiekszajacy nasze pieniądze po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click(object sender, EventArgs e)
        {
            Money += MoneyPerClick;
        }

        /// <summary>
        /// Przejście do okna kasyna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCasino_Click(object sender, EventArgs e)
        {
            ///Do napisania
        }

        /// <summary>
        /// Przycisk zwiększający ilość ECTSów po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonECTSPerClickUpgrade_Click(object sender, EventArgs e)
        {
            if(ECTSPerClickLvl >= 5)
            {
                // Wypisz w konsoli "Osiągnięto maksymalny poziom"
            } 
            else if(ECTS <= ECTSPerClickCosts[ECTSPerClickLvl,0] && Money <= ECTSPerClickCosts[ECTSPerClickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTSPerClickLvl++;
            }

        }

        /// <summary>
        /// Przycisk zwiększający ilość ECTSów po ticku zegara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonECTSPerTickUpgrade_Click(object sender, EventArgs e)
        {
            if (ECTSPerTickLvl >= 5)
            {
                // Wypisz w konsoli "Osiągnięto maksymalny poziom"
            }
            else if (ECTS <= ECTSPerTickCosts[ECTSPerTickLvl, 0] && Money <= ECTSPerTickCosts[ECTSPerTickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTSPerTickLvl++;
            }
        }

        /// <summary>
        /// Przycisk zwiększający nasze szanse w wydarzeniach losowych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandomBoostUpgrade_Click(object sender, EventArgs e)
        {
            if (RandomBoostLvl >= 5)
            {
                // Wypisz w konsoli "Osiągnięto maksymalny poziom"
            }
            else if (ECTS <= RandomBoostCosts[RandomBoostLvl, 0] && Money <= RandomBoostCosts[RandomBoostLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                RandomBoostLvl++;
            }
        }

        /// <summary>
        /// Przycisk zwiększający ilość pieniędzy po ticku zegara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoneyPerTickUpgrade_Click(object sender, EventArgs e)
        {
            if (MoneyPerTickLvl >= 5)
            {
                // Wypisz w konsoli "Osiągnięto maksymalny poziom"
            }
            else if (ECTS <= MoneyPerTickCosts[MoneyPerTickLvl, 0] && Money <= MoneyPerTickCosts[MoneyPerTickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                MoneyPerTickLvl++;
            }
        }

        /// <summary>
        /// Przycisk zwiększający ilość pieniedzy po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoneyPerClickUpgrade_Click(object sender, EventArgs e)
        {
            if (MoneyPerClickLvl >= 5)
            {
                // Wypisz w konsoli "Osiągnięto maksymalny poziom"
            }
            else if (ECTS <= MoneyPerClickCosts[MoneyPerClickLvl, 0] && Money <= MoneyPerClickCosts[MoneyPerClickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                MoneyPerClickLvl++;
            }
        }
    }
}

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
        double ECTS = 100000;
        double ECTSPerClick = 10;


        double Money = 30000;
        double MoneyPerClick = 10;


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
        {5000, 1000},
        {1000, 300}
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
        {100,200}
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
            

            ECTS += ECTSPerTick();
            Money += MoneyPerTick();

            labelECTS.Text = (ECTS/10000).ToString();
            labelMoney.Text = Money.ToString();

            CheckForAvailableGameEvents();
        }

        /// <summary>
        /// Funkcja zwarająca ilość ECTSów które należy dodać po jednym ticku zegara
        /// </summary>
        /// <returns></returns>
        private double ECTSPerTick()
        {
            switch(ECTSPerTickLvl)
            {
                case 0:
                    return 0;
                case 1:
                    return 10;
                case 2:
                    return 25;
                case 3:
                    return 50;
                case 4:
                    return 100;
                case 5:
                    return 250;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Funkcja zwarająca ilość pieniędzy które należy dodać po jednym ticku zegara
        /// </summary>
        /// <returns></returns>
        private double MoneyPerTick()
        {
            switch (MoneyPerTickLvl)
            {
                case 0:
                    return 0;
                case 1:
                    return 100;
                case 2:
                    return 250;
                case 3:
                    return 500;
                case 4:
                    return 1000;
                case 5:
                    return 2500;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Funkcja sprawdzajaca i wywołująca eventy
        /// </summary>
        private void CheckForAvailableGameEvents()
        {
            //Do napisania
        }

        /// <summary>
        /// Podstawowy przycisk zwiekszajacy nasze ECTSy po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonECTS_Click(object sender, EventArgs e)
        {
            ECTS += ECTSPerClick;
            labelECTS.Text = (ECTS/10000).ToString();
        }

        /// <summary>
        /// Podstawowy przycisk zwiekszajacy nasze pieniądze po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click(object sender, EventArgs e)
        {
            Money += MoneyPerClick;
            labelMoney.Text = Money.ToString();
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
            else if(ECTS < ECTSPerClickCosts[ECTSPerClickLvl,0] || Money < ECTSPerClickCosts[ECTSPerClickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTS -= ECTSPerClickCosts[ECTSPerClickLvl, 0];
                Money -= ECTSPerClickCosts[ECTSPerClickLvl, 1];
                ECTSPerClickLvl++;

                labelECTS.Text = (ECTS/10000).ToString();
                labelMoney.Text = Money.ToString();
                labelECTSPerClickLvl.Text = ECTSPerClickLvl.ToString();
                if (ECTSPerClickLvl < 5)
                {
                    buttonECTSPerClickUpgrade.Text =
                        "Zainwestuj w kolejny do\n" +
                        "kurs eTrapeza\n" +
                        ECTSPerClickCosts[ECTSPerClickLvl, 0] + " ECTS\n" +
                        ECTSPerClickCosts[ECTSPerClickLvl, 1] + " Pieniedzy";
                }
                else
                {
                    buttonECTSPerClickUpgrade.Text =
                        "Odblokowałeś\n" +
                        "wszystkie kursy!\n";
                }
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
            else if (ECTS < ECTSPerTickCosts[ECTSPerTickLvl, 0] || Money < ECTSPerTickCosts[ECTSPerTickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTS -= ECTSPerTickCosts[ECTSPerTickLvl, 0];
                Money -= ECTSPerTickCosts[ECTSPerTickLvl, 1];
                ECTSPerTickLvl++;

                labelECTS.Text = (ECTS / 10000).ToString();
                labelMoney.Text = Money.ToString();
                labelECTSPerTickLvl.Text = ECTSPerTickLvl.ToString();
                if (ECTSPerTickLvl < 5)
                {
                    buttonECTSPerTickUpgrade.Text =
                        "Napisz/Ulepsz bota do\n" +
                        "wyszukiwania gotowców na necie\n" +
                        ECTSPerTickCosts[ECTSPerTickLvl, 0] + " ECTS\n" +
                        ECTSPerTickCosts[ECTSPerTickLvl, 1] + " Pieniedzy";
                }
                else
                {
                    buttonECTSPerTickUpgrade.Text =
                        "Stałeś się mistrzem\n" +
                        "odkopywania przydatnych\n" +
                        "informacji!\n";
                }
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
            else if (ECTS < RandomBoostCosts[RandomBoostLvl, 0] || Money < RandomBoostCosts[RandomBoostLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTS -= RandomBoostCosts[RandomBoostLvl, 0];
                Money -= RandomBoostCosts[RandomBoostLvl, 1];
                labelECTS.Text = (ECTS / 10000).ToString();
                labelMoney.Text = Money.ToString();
                RandomBoostLvl++;
                labelRandomBoostLvl.Text = RandomBoostLvl.ToString();
                if (RandomBoostLvl < 5)
                {
                    buttonRandomBoostUpgrade.Text =
                        "Wizyta u\n" +
                        "wróżbity\n" +
                        RandomBoostCosts[RandomBoostLvl, 0] + " ECTS\n" +
                        RandomBoostCosts[RandomBoostLvl, 1] + " Pieniedzy";
                }
                else
                {
                    buttonRandomBoostUpgrade.Text =
                        "Po pięciu sesjach\n" +
                        "stałeś się wyrocznią!\n";
                }

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
            else if (ECTS < MoneyPerTickCosts[MoneyPerTickLvl, 0] || Money < MoneyPerTickCosts[MoneyPerTickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTS -= MoneyPerTickCosts[MoneyPerTickLvl, 0];
                Money -= MoneyPerTickCosts[MoneyPerTickLvl, 1];
                MoneyPerTickLvl++;
                labelECTS.Text = (ECTS / 10000).ToString();
                labelMoney.Text = Money.ToString();
                labelMoneyPerTickLvl.Text = MoneyPerTickLvl.ToString();
                if (MoneyPerTickLvl < 5)
                { 
                buttonMoneyPerTickUpgrade.Text =
                    "Ukończ kurs na\n" +
                    "lepiej płatną parcę\n" +
                    MoneyPerTickCosts[MoneyPerTickLvl, 0] + " ECTS\n" +
                    MoneyPerTickCosts[MoneyPerTickLvl, 1] + " Pieniedzy";
                }
                else
                {
                    buttonMoneyPerTickUpgrade.Text =
                        "Masz najlepszą dostępną\n" +
                        "pracę studencką!\n";
                }
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
            else if (ECTS < MoneyPerClickCosts[MoneyPerClickLvl, 0] || Money < MoneyPerClickCosts[MoneyPerClickLvl, 1])
            {
                // Wypisz w konsoli "Za mało statystyk"
            }
            else
            {
                ECTS -= MoneyPerClickCosts[MoneyPerClickLvl, 0];
                Money -= MoneyPerClickCosts[MoneyPerClickLvl, 1];
                MoneyPerClickLvl++;
                labelECTS.Text = (ECTS / 10000).ToString();
                labelMoney.Text = Money.ToString();
                labelMoneyPerClickLvl.Text = MoneyPerClickLvl.ToString();
                if (MoneyPerClickLvl < 5)
                {
                    buttonMoneyPerClickUpgrade.Text =
                        "Ulepsz koparkę\n" +
                        "kryptowalut\n" +
                        MoneyPerClickCosts[MoneyPerClickLvl, 0] + " ECTS\n" +
                        MoneyPerClickCosts[MoneyPerClickLvl, 1] + " Pieniedzy";
                } 
                else
                {
                    buttonMoneyPerClickUpgrade.Text =
                        "Masz najlepszą dostępną\n" +
                        "koparkę kryptowalut!\n";
                }
            }
        }

    }
}

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
    public partial class FormMain : System.Windows.Forms.Form
    {

        // Zmienne okien pomocniczych
        public FormMessage formMessage;
        public FormEventEtrapez formEventEtrapez;
        public FormEventWolfram formEventWolfram;
        public FormEventTestownik formEventTestownik;



        // Statystyki
        public static double ECTS = 0;
        public static double Money = 250;


        // Poziomy ulepszeń        
        int ECTSPerClickLvl = 0;
        int ECTSPerTickLvl = 0;

        int MoneyPerClickLvl = 0;
        int MoneyPerTickLvl = 0;

        public int RandomBoostLvl = 0;


        // Tablice związane z kosztami ulepszeń w formacie
        // {{KosztEctsLvl1,KosztPieniedzyLvl1},
        // {KosztEctsLvl2, KosztPieniedzyLvl2}}
        double[,] ECTSPerClickCosts = new double[5, 2] {
        {50, 0},
        {250, 500},
        {1000, 2500},
        {5000, 10000},
        {10000, 30000}
        };

        double[,] ECTSPerTickCosts = new double[5, 2] {
        {50, 0},
        {250, 1000},
        {1000,5000},
        {5000,25000},
        {10000,50000}
        };

        double[,] MoneyPerClickCosts = new double[5, 2] {
        {50, 0},
        {500, 0},
        {5000, 0},
        {10000, 5000},
        {25000, 10000}
        };

        double[,] MoneyPerTickCosts = new double[5, 2] {
        {50, 100},
        {250, 2500},
        {1000,5000},
        {5000,7500},
        {10000,10000}
        };

        double[,] RandomBoostCosts = new double[5, 2] {
        {0, 1000},
        {0, 2500},
        {0,5000},
        {0,7500},
        {0,10000}
        };


        // Zmienne zwiazane z wydarzeniami
        Random random = new Random();
        public static bool IsEventWon;

        bool IsGameWon = false;

        bool IsETrapezEventDone = false;
        bool IsWolframEventDone = false;
        bool IsTestownikEventDone = false;



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
        /// Funkcja zwarająca ilość ECTSów które należy dodać po jednym kliknięciu
        /// </summary>
        /// <returns></returns>
        private double ECTSPerClick()
        {
            switch (ECTSPerClickLvl)
            {
                case 0:
                    return 1;
                case 1:
                    return 10;
                case 2:
                    return 25;
                case 3:
                    return 50;
                case 4:
                    return 100;
                case 5:
                    return 500;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Funkcja zwarająca ilość pieniędzy które należy dodać po jednym kliknięciu
        /// </summary>
        /// <returns></returns>
        private double MoneyPerClick()
        {
            switch (MoneyPerClickLvl)
            {
                case 0:
                    return 10;
                case 1:
                    return 100;
                case 2:
                    return 250;
                case 3:
                    return 500;
                case 4:
                    return 1000;
                case 5:
                    return 5000;
                default:
                    return 0;
            }
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
                    return 500;
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
                    return 5000;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Funkcja kalkulujaca czy gra losowa zostala wygrana
        /// </summary>
        /// <param name="chancetolose"></param>
        /// <param name="boostModifier"></param>
        /// <returns></returns>
        public bool IsRandomGameWon(int chancetolose, int boostModifier)
        {
            int randomValue = random.Next(100) + boostModifier * RandomBoostLvl;

            if (randomValue >= chancetolose)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Funkcja sprawdzajaca i wywołująca eventy
        /// </summary>
        private void CheckForAvailableGameEvents()
        {
            if(ECTS >= 300000 && IsGameWon == false)
            {
                IsGameWon = true;
                formMessage = new FormMessage();
                formMessage.text =
                    "Gratulacje!\n" +
                    "Udało Ci się\n" +
                    "zdać semestr!";
                formMessage.Show();
            }

            if(ECTS >= 10000 && IsETrapezEventDone == false)
            {
                IsETrapezEventDone = true;
                IsEventWon = IsRandomGameWon(70, 10);

                formEventEtrapez = new FormEventEtrapez();
                formEventEtrapez.text=
                    "Masz możliwość\n" +
                    "pobrania nielegalnej\n" +
                    "wersji eTrapeza";
                formEventEtrapez.Show();

            }
            if (ECTS >= 5000 && IsTestownikEventDone == false)
            {
                IsTestownikEventDone = true;
                IsEventWon = IsRandomGameWon(20, 2);

                formEventTestownik = new FormEventTestownik();
                formEventTestownik.text =
                    "Słyszałeś od starszych roczników\n" +
                    "że następne kolokwium można bez\n" +
                    "problemów zdać testownikiem";
                formEventTestownik.Show();
            }

            if (ECTS >= 50000 && IsWolframEventDone == false)
            {
                IsWolframEventDone = true;
                IsEventWon = IsRandomGameWon(20, 2);

                formEventWolfram = new FormEventWolfram();
                formEventWolfram.text =
                    "W związu ze zdalnym nauczaniem\n" +
                    "możesz liczyć na możliwość uzupełnienia\n" +
                    "odpowiedzi na kolokwium wynikami z WolframaAlpha";
                formEventWolfram.Show();
            }

        }

        /// <summary>
        /// Podstawowy przycisk zwiekszajacy nasze ECTSy po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonECTS_Click(object sender, EventArgs e)
        {
            ECTS += ECTSPerClick();
            labelECTS.Text = (ECTS/10000).ToString();
        }

        /// <summary>
        /// Podstawowy przycisk zwiekszajacy nasze pieniądze po kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click(object sender, EventArgs e)
        {
            Money += MoneyPerClick();
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
                formMessage = new FormMessage();
                formMessage.text = 
                    "Osiągnięto maksymalny\n" +
                    "poziom ulepszenia";
                formMessage.Show();

            } 
            else if(ECTS < ECTSPerClickCosts[ECTSPerClickLvl,0] || Money < ECTSPerClickCosts[ECTSPerClickLvl, 1])
            {
                formMessage = new FormMessage();
                formMessage.text =
                    "Niestety nie stać\n" +
                    "cię na to ulepszenie";
                formMessage.Show();
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
                        "Zainwestuj w kolejny\n" +
                        "kurs eTrapeza\n" +
                        (ECTSPerClickCosts[ECTSPerClickLvl, 0] / 10000) + " ECTS\n" +
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
                formMessage = new FormMessage();
                formMessage.text =
                    "Osiągnięto maksymalny\n" +
                    "poziom ulepszenia";
                formMessage.Show();
            }
            else if (ECTS < ECTSPerTickCosts[ECTSPerTickLvl, 0] || Money < ECTSPerTickCosts[ECTSPerTickLvl, 1])
            {
                formMessage = new FormMessage();
                formMessage.text =
                    "Niestety nie stać\n" +
                    "cię na to ulepszenie";
                formMessage.Show();
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
                        (ECTSPerTickCosts[ECTSPerTickLvl, 0] / 10000) + " ECTS\n" +
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
                formMessage = new FormMessage();
                formMessage.text =
                    "Osiągnięto maksymalny\n" +
                    "poziom ulepszenia";
                formMessage.Show();
            }
            else if (ECTS < RandomBoostCosts[RandomBoostLvl, 0] || Money < RandomBoostCosts[RandomBoostLvl, 1])
            {
                formMessage = new FormMessage();
                formMessage.text =
                    "Niestety nie stać\n" +
                    "cię na to ulepszenie";
                formMessage.Show();
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
                        (RandomBoostCosts[RandomBoostLvl, 0]/10000) + " ECTS\n" +
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
                formMessage = new FormMessage();
                formMessage.text =
                    "Osiągnięto maksymalny\n" +
                    "poziom ulepszenia";
                formMessage.Show();
            }
            else if (ECTS < MoneyPerTickCosts[MoneyPerTickLvl, 0] || Money < MoneyPerTickCosts[MoneyPerTickLvl, 1])
            {
                formMessage = new FormMessage();
                formMessage.text =
                    "Niestety nie stać\n" +
                    "cię na to ulepszenie";
                formMessage.Show();
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
                    "Ulepsz koparkę\n" +
                    "kryptowalut\n" +
                    (MoneyPerTickCosts[MoneyPerTickLvl, 0] / 10000) + " ECTS\n" +
                    MoneyPerTickCosts[MoneyPerTickLvl, 1] + " Pieniedzy";
                }
                else
                {
                    buttonMoneyPerTickUpgrade.Text =
                        "Masz najlepszą dostępną\n" +
                        "koparkę kryptowalut!\n";
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
                formMessage = new FormMessage();
                formMessage.text =
                    "Osiągnięto maksymalny\n" +
                    "poziom ulepszenia";
                formMessage.Show();
            }
            else if (ECTS < MoneyPerClickCosts[MoneyPerClickLvl, 0] || Money < MoneyPerClickCosts[MoneyPerClickLvl, 1])
            {
                formMessage = new FormMessage();
                formMessage.text =
                    "Niestety nie stać\n" +
                    "cię na to ulepszenie";
                formMessage.Show();
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
                        "Ukończ kurs na\n" +
                        "lepiej płatną parcę\n" +
                        (MoneyPerClickCosts[MoneyPerClickLvl, 0] / 10000) + " ECTS\n" +
                        MoneyPerClickCosts[MoneyPerClickLvl, 1] + " Pieniedzy";
                } 
                else
                {
                    buttonMoneyPerClickUpgrade.Text =
                        "Masz najlepszą dostępną\n" +
                        "pracę studencką!\n";
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonECTSPerClickUpgrade.Text =
                "Zainwestuj w kolejny\n" +
                "kurs eTrapeza\n" +
                (ECTSPerClickCosts[ECTSPerClickLvl, 0] / 10000) + " ECTS\n" +
                ECTSPerClickCosts[ECTSPerClickLvl, 1] + " Pieniedzy";
            buttonECTSPerTickUpgrade.Text =
                "Napisz/Ulepsz bota do\n" +
                "wyszukiwania gotowców na necie\n" +
                (ECTSPerTickCosts[ECTSPerTickLvl, 0] / 10000) + " ECTS\n" +
                ECTSPerTickCosts[ECTSPerTickLvl, 1] + " Pieniedzy";
            buttonRandomBoostUpgrade.Text =
                "Wizyta u\n" +
                "wróżbity\n" +
                (RandomBoostCosts[RandomBoostLvl, 0] / 10000) + " ECTS\n" +
                RandomBoostCosts[RandomBoostLvl, 1] + " Pieniedzy";
            buttonMoneyPerTickUpgrade.Text =
                "Ulepsz koparkę\n" +
                "kryptowalut\n" +
                (MoneyPerTickCosts[MoneyPerTickLvl, 0] / 10000) + " ECTS\n" +
                MoneyPerTickCosts[MoneyPerTickLvl, 1] + " Pieniedzy";
            buttonMoneyPerClickUpgrade.Text =
                "Ukończ kurs na\n" +
                "lepiej płatną parcę\n" +
                (MoneyPerClickCosts[MoneyPerClickLvl, 0] / 10000) + " ECTS\n" +
                MoneyPerClickCosts[MoneyPerClickLvl, 1] + " Pieniedzy";
        }
    }
}


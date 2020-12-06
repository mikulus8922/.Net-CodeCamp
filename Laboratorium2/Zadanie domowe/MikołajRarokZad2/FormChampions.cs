using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokZad2
{
    public partial class FormChampions : Form
    {
        Utility utility = new Utility();

        public FormChampions()
        {
            InitializeComponent();
        }





        private void buttonGenerateNewChampions_Click(object sender, EventArgs e)
        {
            utility.ClearNewChampionsList();
            utility.GenerateNewChampionsList();
            dataGridViewNewChampions.DataSource = null;
            dataGridViewNewChampions.DataSource = utility.ChampionRecruitment;
        }

        private void dataGridViewNewChampions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = 1;

            switch (selectedRow) 
            {
                case 0:
                    utility.ChampionRoster.Add(utility.ChampionRecruitment[0]);
                    break;
                case 1:
                    utility.ChampionRoster.Add(utility.ChampionRecruitment[1]);
                    break;
                case 2:
                    utility.ChampionRoster.Add(utility.ChampionRecruitment[2]);
                    break;
                default:
                    break;
            }
            dataGridViewRoster.DataSource = null;
            dataGridViewRoster.DataSource = utility.ChampionRoster;
            dataGridViewNewChampions.DataSource = null;

        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            dataGridViewNewChampions.DataSource = utility.ChampionRecruitment;
        }
    }
}

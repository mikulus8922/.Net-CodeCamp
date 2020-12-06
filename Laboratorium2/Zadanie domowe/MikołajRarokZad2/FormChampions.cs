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

        internal Utility Utility { get => utility; set => utility = value; }

        public FormChampions()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Opens a new form used to
        /// recruit new champions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerateNewChampions_Click(object sender, EventArgs e)
        {
            FormNewChampions formNewChampions = new FormNewChampions();
            formNewChampions.Show();
        }



        /// <summary>
        /// Refreshes dataGridView
        /// </summary>
        public void RefreshRoster()
        {
            dataGridViewRoster.DataSource = null;
            dataGridViewRoster.DataSource = Utility.ChampionRoster;
        }


        


        /// <summary>
        /// Deletes the champion that is currently selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteSelectedChampions_Click(object sender, EventArgs e)
        {
            Champion championToRemove = null;
            foreach(Champion champion in utility.ChampionRoster)
            {
                if (champion.HeroClass == labelChampionClass.Text &&
                    champion.Health.ToString() == labelChampionHealth.Text &&
                    champion.Defence.ToString() == labelChampionDefence.Text &&
                    champion.Damage.ToString() == labelChampionDamage.Text &&
                    champion.Accuracy.ToString() == labelChampionAccuracy.Text &&
                    champion.Dexterity.ToString() == labelChampionDexterity.Text &&
                    champion.Inteligence.ToString() == labelChampionInteligence.Text &&
                    champion.TypeAbility.ToString() == labelChampionTypeAbility.Text &&
                    champion.ClassAbility.ToString() == labelChampionClassAbility.Text)
                {
                    championToRemove = champion; 
                }
            }
            if(championToRemove != null)
                utility.ChampionRoster.Remove(championToRemove);

            RefreshRoster();
        }

        /// <summary>
        /// Selects and writes inormation to labels
        /// about a champion that is currently selected
        /// by left clicking a row in a dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectHero_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewRoster.SelectedRows.Count == 1)
            {
                int rowindex = dataGridViewRoster.CurrentCell.RowIndex;
                int columnindex = dataGridViewRoster.CurrentCell.ColumnIndex;

                labelChampionClass.Text = dataGridViewRoster.Rows[rowindex].Cells[0].Value.ToString();
                labelChampionHealth.Text = dataGridViewRoster.Rows[rowindex].Cells[1].Value.ToString();
                labelChampionDefence.Text = dataGridViewRoster.Rows[rowindex].Cells[2].Value.ToString();
                labelChampionDamage.Text = dataGridViewRoster.Rows[rowindex].Cells[3].Value.ToString();
                labelChampionAccuracy.Text = dataGridViewRoster.Rows[rowindex].Cells[4].Value.ToString();
                labelChampionDexterity.Text = dataGridViewRoster.Rows[rowindex].Cells[5].Value.ToString();
                labelChampionInteligence.Text = dataGridViewRoster.Rows[rowindex].Cells[6].Value.ToString();
                labelChampionTypeAbility.Text = dataGridViewRoster.Rows[rowindex].Cells[7].Value.ToString();
                labelChampionClassAbility.Text = dataGridViewRoster.Rows[rowindex].Cells[8].Value.ToString();

                if(labelChampionClass.Text == "Knight")
                {
                    labelTypeAbilityName.Text = "Shield";
                    labelClassAbilityName.Text = "Protect";
                }
                if (labelChampionClass.Text == "Paladin")
                {
                    labelTypeAbilityName.Text = "Shield";
                    labelClassAbilityName.Text = "Mass heal";
                }
                if (labelChampionClass.Text == "Barbarian")
                {
                    labelTypeAbilityName.Text = "Shield";
                    labelClassAbilityName.Text = "Taunt";
                }
                if (labelChampionClass.Text == "Archer")
                {
                    labelTypeAbilityName.Text = "Stealth";
                    labelClassAbilityName.Text = "Volley";
                }
                if (labelChampionClass.Text == "Rogue")
                {
                    labelTypeAbilityName.Text = "Stealth";
                    labelClassAbilityName.Text = "Throwing daggers";
                }
                if (labelChampionClass.Text == "Assasin")
                {
                    labelTypeAbilityName.Text = "Stealth";
                    labelClassAbilityName.Text = "Backstab";
                }
                if (labelChampionClass.Text == "Warlock")
                {
                    labelTypeAbilityName.Text = "Mana";
                    labelClassAbilityName.Text = "Consume soul";
                }
                if (labelChampionClass.Text == "Shaman")
                {
                    labelTypeAbilityName.Text = "Mana";
                    labelClassAbilityName.Text = "Buff damage";
                }
                if (labelChampionClass.Text == "Priest")
                {
                    labelTypeAbilityName.Text = "Mana";
                    labelClassAbilityName.Text = "Direct heal";
                }

            }
        }

    }
}

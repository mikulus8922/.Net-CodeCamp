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
    public partial class FormNewChampions : Form
    {

        Utility utility;

        /// <summary>
        /// Reference to the main form
        /// </summary>
        FormChampions formChampions = (FormChampions)Application.OpenForms[0];



        public FormNewChampions()
        {
            InitializeComponent();
            utility = formChampions.Utility;
        }

        /// <summary>
        /// Loads stats of 
        /// 3 random champions
        /// to correct labels
        /// and buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNewChampions_Load(object sender, EventArgs e)
        {
            utility.ClearNewChampionsList();
            utility.GenerateNewChampionsList();


            labelChampionClass1.Text = utility.ChampionRecruitment[0].HeroClass;
            labelChampionClass2.Text = utility.ChampionRecruitment[1].HeroClass;
            labelChampionClass3.Text = utility.ChampionRecruitment[2].HeroClass;

            //

            labelChampionHealth1.Text = utility.ChampionRecruitment[0].Health.ToString();
            labelChampionHealth2.Text = utility.ChampionRecruitment[1].Health.ToString();
            labelChampionHealth3.Text = utility.ChampionRecruitment[2].Health.ToString();

            //

            labelChampionDefence1.Text = utility.ChampionRecruitment[0].Defence.ToString();
            labelChampionDefence2.Text = utility.ChampionRecruitment[1].Defence.ToString();
            labelChampionDefence3.Text = utility.ChampionRecruitment[2].Defence.ToString();

            //

            labelChampionDamage1.Text = utility.ChampionRecruitment[0].Damage.ToString();
            labelChampionDamage2.Text = utility.ChampionRecruitment[1].Damage.ToString();
            labelChampionDamage3.Text = utility.ChampionRecruitment[2].Damage.ToString();

            //

            labelChampionAccuracy1.Text = utility.ChampionRecruitment[0].Accuracy.ToString();
            labelChampionAccuracy2.Text = utility.ChampionRecruitment[1].Accuracy.ToString();
            labelChampionAccuracy3.Text = utility.ChampionRecruitment[2].Accuracy.ToString();

            //

            labelChampionDexterity1.Text = utility.ChampionRecruitment[0].Dexterity.ToString();
            labelChampionDexterity2.Text = utility.ChampionRecruitment[1].Dexterity.ToString();
            labelChampionDexterity3.Text = utility.ChampionRecruitment[2].Dexterity.ToString();

            //

            labelChampionInteligence1.Text = utility.ChampionRecruitment[0].Inteligence.ToString();
            labelChampionInteligence2.Text = utility.ChampionRecruitment[1].Inteligence.ToString();
            labelChampionInteligence3.Text = utility.ChampionRecruitment[2].Inteligence.ToString();

            //

            labelTypeAbilityName1.Text = utility.ChampionRecruitment[0].ReturnTypeAbilityName();
            labelTypeAbilityName2.Text = utility.ChampionRecruitment[1].ReturnTypeAbilityName();
            labelTypeAbilityName3.Text = utility.ChampionRecruitment[2].ReturnTypeAbilityName();

            labelChampionTypeAbility1.Text = utility.ChampionRecruitment[0].TypeAbility.ToString();
            labelChampionTypeAbility2.Text = utility.ChampionRecruitment[1].TypeAbility.ToString();
            labelChampionTypeAbility3.Text = utility.ChampionRecruitment[2].TypeAbility.ToString();

            //

            labelClassAbilityName1.Text = utility.ChampionRecruitment[0].ReturnClassAbilityName();
            labelClassAbilityName2.Text = utility.ChampionRecruitment[1].ReturnClassAbilityName();
            labelClassAbilityName3.Text = utility.ChampionRecruitment[2].ReturnClassAbilityName();

            labelChampionClassAbility1.Text = utility.ChampionRecruitment[0].ClassAbility.ToString();
            labelChampionClassAbility2.Text = utility.ChampionRecruitment[1].ClassAbility.ToString();
            labelChampionClassAbility3.Text = utility.ChampionRecruitment[2].ClassAbility.ToString();

            //

            buttonChoose1.Text = "Choose " + utility.ChampionRecruitment[0].HeroClass;
            buttonChoose2.Text = "Choose " + utility.ChampionRecruitment[1].HeroClass;
            buttonChoose3.Text = "Choose " + utility.ChampionRecruitment[2].HeroClass;

        }

        /// <summary>
        /// Adds the hero on the left
        /// to the roster and closes
        /// the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChoose1_Click(object sender, EventArgs e)
        {
            utility.ChampionRoster.Add(utility.ChampionRecruitment[0]);
            formChampions.RefreshRoster();
            this.Close();
            utility.ClearNewChampionsList();
        }

        /// <summary>
        /// Adds the hero in the middle
        /// to the roster and closes
        /// the form
        /// </summary>
        private void buttonChoose2_Click(object sender, EventArgs e)
        {
            utility.ChampionRoster.Add(utility.ChampionRecruitment[1]);
            formChampions.RefreshRoster();
            this.Close();
            utility.ClearNewChampionsList();
        }

        /// <summary>
        /// Adds the hero on the right
        /// to the roster and closes
        /// the form
        /// </summary>
        private void buttonChoose3_Click(object sender, EventArgs e)
        {
            utility.ChampionRoster.Add(utility.ChampionRecruitment[2]);
            formChampions.RefreshRoster();
            this.Close();
            utility.ClearNewChampionsList();
        }
    }
}

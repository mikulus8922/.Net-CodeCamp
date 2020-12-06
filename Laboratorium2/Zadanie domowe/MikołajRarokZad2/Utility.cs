using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    class Utility
    {
        private List<Champion> championRoster = new List<Champion>();
        private List<Champion> championRecruitment = new List<Champion>();

        public List<Champion> ChampionRoster { get => championRoster; set => championRoster = value; }
        public List<Champion> ChampionRecruitment { get => championRecruitment; set => championRecruitment = value; }



        Random random = new Random();
        int randomClass;

        /// <summary>
        /// Adds 3 random champions to recruitment list
        /// </summary>
        public void GenerateNewChampionsList()
        {
            for (int i = 0; i < 3; i++)
            {
                randomClass = random.Next(1, 10);

                switch (randomClass)
                {
                    case 1:
                        ChampionRecruitment.Add(new ClassKnight());
                        break;
                    case 2:
                        ChampionRecruitment.Add(new ClassPaladin());
                        break;
                    case 3:
                        ChampionRecruitment.Add(new ClassBarbarian());
                        break;
                    case 4:
                        ChampionRecruitment.Add(new ClassArcher());
                        break;
                    case 5:
                        ChampionRecruitment.Add(new ClassRogue());
                        break;
                    case 6:
                        ChampionRecruitment.Add(new ClassAssasin());
                        break;
                    case 7:
                        ChampionRecruitment.Add(new ClassWarlock());
                        break;
                    case 8:
                        ChampionRecruitment.Add(new ClassShaman());
                        break;
                    case 9:
                        ChampionRecruitment.Add(new ClassPriest());
                        break;
                    default:
                        break;
                }
            }
        }




        /// <summary>
        /// Clear the recruitment list
        /// </summary>
        public void ClearNewChampionsList()
        {
            ChampionRecruitment.Clear();
        }



    }
}

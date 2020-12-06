using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad2
{
    abstract class Champion
    {
        private String heroClass;
        private int health;
        private int defence;
        private int damage;
        private int accuracy;       
        private int dexterity;
        private int inteligence;


        public string HeroClass { get => heroClass; set => heroClass = value; }
        public int Health { get => health; set => health = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Inteligence { get => inteligence; set => inteligence = value; }
        

        internal enum CharacterTraits
        {
            optimistic,
            happy,
            sad,
            depressive
        }
    }
}

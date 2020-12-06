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
        private int typeAbility;
        private int classAbility;


        public string HeroClass { get => heroClass; set => heroClass = value; }
        public int Health { get => health; set => health = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Inteligence { get => inteligence; set => inteligence = value; }
        public int TypeAbility { get => typeAbility; set => typeAbility = value; }
        public int ClassAbility { get => classAbility; set => classAbility = value; }


        /// <summary>
        /// Abstract method overriden in
        /// types of champions
        /// </summary>
        public abstract void UseTypeAbility();

        /// <summary>
        /// Abstract method overriden in
        /// classes of champions
        /// </summary>
        public abstract void UseClassAbility();

        /// <summary>
        /// Abstract method overriden in
        /// types of champions
        /// </summary>
        public abstract String ReturnTypeAbilityName();

        /// <summary>
        /// Abstract method overriden in
        /// classes of champions
        /// </summary>
        public abstract String ReturnClassAbilityName();


    }
}

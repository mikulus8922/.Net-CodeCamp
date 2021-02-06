using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturJordanWyk
{
    public class Cat
    {
        /// <summary>
        /// Imię kota 
        /// </summary>
        private String name;
        /// <summary>
        /// Opis kota 
        /// </summary>
        private String description;

        public class Builder
        {
            /// <summary>
            /// Imię kota w klasie budującej
            /// </summary>
            private String name;
            /// <summary>
            /// Opis kota w klasie budującej
            /// </summary>
            private String description;

            /// <summary>
            /// Przypisanie imienia
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public Builder Name(String name)
            {
                this.name = name;
                return this;
            }
            /// <summary>
            /// Przypisanie opisu
            /// </summary>
            /// <param name="description"></param>
            /// <returns></returns>
            public Builder Description(String description)
            {
                this.description = description;
                return this;
            }

            /// <summary>
            /// Tworzenie obiektu w klasie budującej
            /// </summary>
            /// <returns></returns>
            public Cat Build()
            {
                if (name == ""|| name == null)
                {
                    throw new Exception("Name cannot be empty");
                }

                Cat cat = new Cat();
                cat.name = this.name;
                cat.description = this.description;
                return cat;
            }

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArturJordanWyk
{
    // Fasada udostępnia uproszczone interfejsu dla użytkownika
    public class Facade
    {
        /// <summary>
        /// zmienna przechowująca obiekt złożonego systemu A
        /// </summary>
        public ComplexSystemA complexSystemA;
        /// <summary>
        /// zmienna przechowująca obiekt złożonego systemu B
        /// </summary>
        public ComplexSystemB complexSystemB;

        /// <summary>
        /// Konstruktor pobierający instancje systemów
        /// </summary>
        /// <param name="complexSystemA"></param>
        /// <param name="complexSystemB"></param>
        public Facade(ComplexSystemA complexSystemA, ComplexSystemB complexSystemB)
        {
            this.complexSystemA = complexSystemA;
            this.complexSystemB = complexSystemB;
        }

        /// <summary>
        /// Dopasowana metoda z wykorzystaniem wzorca fasady
        /// </summary>
        public string Operation()
        {
            string result = 
                " wynik systemu A: " + complexSystemA.OperationEasy() + 
                " wynik systemu B: " + complexSystemB.OperationEasy();
            return result;
        }
    }
}

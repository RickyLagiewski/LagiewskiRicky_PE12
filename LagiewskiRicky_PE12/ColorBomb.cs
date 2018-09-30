using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagiewskiRicky_PE12
{
    class ColorBomb : Candy
    {
        private string candyTaste = "It's taste is that of the necter of the gods";
        private string candyColor = "";
        public new string CandyColor
        {
            get { return candyColor; }
            set { candyColor = value; }
        }
        private int numberCandy = 0;
        private string candyPower = "";
        public new string CandyPower
        {
            get { return candyPower; }
            set { candyPower = value; }
        }
        public void Print()
        {
            Console.WriteLine("Made a " + candyColor + " candy");
            Console.WriteLine("The " + candyColor + " candy requires 5 matched candies to spawn");
            Console.WriteLine(candyColor + ": " + candyPower);
            Console.WriteLine(candyTaste);
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");
        }
    }
}

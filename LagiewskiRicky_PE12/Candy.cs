using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagiewskiRicky_PE12
{
    class Candy
    {
        private string candyColor = "";
        private int numberCandy = 0;
        private string candyPower = "";

        public string CandyColor
        {
            get
            {
                return candyColor;
            }
            set
            {
                candyColor = value;
            }
        }
        public int NumberColor
        {
            get
            {
                return numberCandy;
            }
            set
            {
                numberCandy = value;
            }
        }
        public string CandyPower
        {
            get
            {
                return candyPower;
            }
            set
            {
                candyPower = value;
            }
        }
        public void CandyBase(string p_candyColor)
        {
            candyColor = p_candyColor;
            numberCandy = 0;
            candyPower = "Match 3 in a row to earn points";
            Console.WriteLine("Made a " + candyColor + " candy!");
        }
        public void PrintCandy()
        {

        }
    }
}

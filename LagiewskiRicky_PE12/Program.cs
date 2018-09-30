using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagiewskiRicky_PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapped mainWrapped = new Wrapped();
            ((Wrapped)mainWrapped).CandyColor = "Green";
            ((Wrapped)mainWrapped).CandyPower = "Drops a nuclear warhead!";
            mainWrapped.Print();

            Striped mainStriped = new Striped();
            ((Striped)mainStriped).CandyColor = "Mix of orange and white";
            ((Striped)mainStriped).CandyPower = "Gives you V-Bucks!";
            mainStriped.Print();

            ColorBomb mainColorBomb = new ColorBomb();
            ((ColorBomb)mainColorBomb).CandyColor = "splash of memes";
            ((ColorBomb)mainColorBomb).CandyPower = "Proves that Han shot first!";
            mainColorBomb.Print();

            Regular mainRegular = new Regular();
            ((Regular)mainRegular).CandyColor = "Red";
            ((Regular)mainRegular).CandyPower = "Literally does nothing";
            mainRegular.Print();
        }
    }
}

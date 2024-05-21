using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score1, score2;

            Console.Write("enter an integrer number: ");
            score1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a second integrer number: ");
            score2 = Convert.ToInt32(Console.ReadLine());

            if (score1 > 100 && score2 > 100)
            {
                Console.WriteLine("youre scores are GREATER than 100!!");
            }

            if (score1 > 100 || score2 > 100)
            { Console.WriteLine("One of your scores are GREATER than 100"); }

            if (score1 < 100 && score2 < 100)
            { Console.WriteLine("Both of your scores are LOWER than 100"); }

            if (score1 > score2 && score2 > 125) { Console.WriteLine("the first score"); }
            if (score1 == 100 || score2 == 100) { }
            if ((score1 == 100 && score2 == 100) && !(score1 == 100 && score2 == 100)) { }
            if ((score1 >= 10 && score1 <= 20) && (score2 >= 10 && score2 <= 20)) { }
            if (!(score1 >= 10 && score1 <= 20) && !(score2 >= 10 && score2 <= 20)) { }



            Console.WriteLine("press any key to exit this program");
            Console.ReadLine();



        }
    }
}

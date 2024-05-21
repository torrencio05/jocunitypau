using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperació
{
    internal class casella
    {
        private ConsoleColor color { get; set; }
        private char symbol { get; set; }

        public casella(char symbol, ConsoleColor color)
        {
            symbol = symbol;
            color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(symbol);
            Console.ResetColor();
        }
    }

   

    public static void Draw()
    {

    }
}

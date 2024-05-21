using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs, cats, rats;

            // tots 3 diferents
           if (dogs != cats && cats != rats && dogs != rats) { }
            // almenys 2 de 3 iguals
           if (!(dogs != cats && cats != rats && dogs != rats)) { }
            //nomes 2 dels tres son iguals
           if ((cats == rats) && (cats != dogs)) { }




        }
    }
}

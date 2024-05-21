using System;

namespace Ex2_Fireworks
{
    class Firewroks
    {
        static void Main(string[] args)
        {
            int almigthy, magic, nonMagic;
            int total;
            int elementOne, elementTwo;

            //Random alea = new Random();
            Random alea = new ChargedDie(); // use this to reproduce the sequences show in the exam paper

            Console.WriteLine("NEW YEAR'S FIREWOKS SHOW");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            /* COMPLETE */

            Console.ResetColor();
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("The show is over. Press any key to exit");
            Console.ReadKey(true);

        }
       
        static void WriteRocket (int d1, int d2)
        {
           if (d1==d2) {
                if (d1==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                }
                else if (d1==1 || d1==6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
           }
           else {
                Console.ForegroundColor = ConsoleColor.White;
           }
           Console.Write($"({d1} {d2}) ");
           Console.ResetColor();
        }
    }


    // do not modify this code.
    class ChargedDie : Random
    {
        private static string[] seqs = {
            "23000011253366662598745612722634871133552299881236697485966215776688774416524876623642530880001166",
            "78253674156678259810872398772355600373094853032677523972061175532000116666119911886622334466449900"
        };

        private int pos = 0;
        private string sequence;


        public ChargedDie()
        {
            int seqNum;
            Console.Write("Enter sequence number (1 or 2)>");
            Console.ForegroundColor = ConsoleColor.Green;
            seqNum = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            sequence = seqs[seqNum - 1];
        }

        public override int Next(int lower, int upper)
        {
            int value;

            value = Convert.ToInt32(sequence.Substring(pos, 1));

            pos = (pos + 1) % sequence.Length;
            return value;
        }

        public override int Next (int upper)
        {
            return Next(0, upper);
        }
    } // ChargedDie ends here
}

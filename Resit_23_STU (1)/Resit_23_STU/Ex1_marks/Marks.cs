using System;

namespace Ex1_marks
{
    class Marks
    {
        static void Main(string[] args)
        {
            double pa1, pa2;
            double ex1, ex2, ex3;
            char paCategory;
            double examsMark, finalMark;

            Console.WriteLine("JAN. 2024 MARK CALCULATOR");
            Console.WriteLine("-------------------------");
            Console.WriteLine();


            Console.Write("Enter mark for first exam: ");
            ex1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark for second exam: ");
            ex2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark for third exam: ");
            ex3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter mark for first practical assigment: ");
            pa1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark for second practical assigment: ");
            pa2 = Convert.ToDouble(Console.ReadLine());


            




            double Pacategory(double a, double b, double c, int purpose)
            {

                if (pa1<=5 && pa2<=5)
                {

                    if (pa1 > 4 && pa2 > 4)
                    {

                        Console.WriteLine("PA Category: A");



                    }
                    else if (pa1 <= 4 && pa2 > 4)

                    {

                        Console.WriteLine(" PA Category: B");



                    }
                    else if (pa1 > 3 && pa2 > 3 && pa1 < 5 && pa2 < 5)
                    {

                        Console.WriteLine("PA Category: C");
                    }else
                    {
                        Console.WriteLine("PA Category: D");
                    }





                }
                



                return paCategory;
                Console.ReadLine();

            }
            Console.ReadLine() ;

        }
    }
}
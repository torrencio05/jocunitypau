using System;


namespace Ex_03_MatrixProcessing
{
    internal class MatrixProcessing
    {
        static void Main(string[] args)
        {

            string[] students;
            string[] subjects;
            double[,] marks;

            int group;
            int NUMBER_OF_GROUPS = 3;

            Console.WriteLine("MARKS PROCESSING");
            Console.WriteLine("----------------");
            Console.WriteLine();

            group = ReadGroupNumber(NUMBER_OF_GROUPS);
            TestData.FillData(group, out students, out subjects, out marks);
            Console.WriteLine();

            // for each student show number of failed subjects
            Console.WriteLine("\nFAILED SUBJECTS");
            Console.WriteLine("--------------");
            for (int idxStu = 0; idxStu < students.Length; idxStu++)
            {
                Console.Write(students[idxStu] + ": ");
                Console.ForegroundColor = ConsoleColor.Red;

                /* COMPLETE */
               
            }

            Console.WriteLine();

            // for each subject show the name of its "best student"
            Console.WriteLine("BEST STUDENT");
            Console.WriteLine("------------");
            for (int idxSub = 0; idxSub < subjects.Length; idxSub++)
            {
                Console.Write(subjects[idxSub] + ": ");
                Console.ForegroundColor = ConsoleColor.Green;

                /* COMPLETE */
                
            }



            Console.WriteLine();
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }


        static int CountFailPerStudent(double[,] marks, int student)
        {
            /* Given an array of marks and the index of a student, determines (counts)
             * hom many subjects that sutudent has failed (mark < 5) */

            /* COMPLETE */

        }

        static int bestStudent(double[,] marks, int subject)
        {
            /* Given an array of marks and the index of a subject, determines the
             index of the student with the highest mark in that subject. If there is
             more than one, provides the first (lowest index) */

            /* COMPLETE */

        }




        // -----------------------------------------------------

        static int ReadGroupNumber(int ng)
        {
            int result;
            Console.Write("Please enter the number of the group that has to be processed(1-{0}): ", ng);
            result = Convert.ToInt32(Console.ReadLine());
            while (!(result >= 1 && result <= ng))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    Incorrect number it must be between 1 and {0}", ng);
                Console.ResetColor();
                Console.Write("Enter again the number of the group that has to be processed(1-{0}): ", ng);
                result = Convert.ToInt32(Console.ReadLine());
            }
            // when here result>=1 && result<=ng
            return result;
        }
    }
}

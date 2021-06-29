using System;

namespace TriangleSolverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }

        public static void RunMenu()
        {

            int option = 0;
            int firstSide, secondSide, thirdSide;

            do
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Enter triangle dimenstions");
                    Console.WriteLine("2. Exit");
                    Console.Write("Choose option: ");

                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            // Get input for 3 sides
                            Console.Write("Enter 1st integer: ");
                            firstSide = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter 2nd integer: ");
                            secondSide = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter 3rd integer: ");
                            thirdSide = Convert.ToInt32(Console.ReadLine());

                            // Call to Analyze
                            Console.WriteLine("Result: {0}", TriangleSolver.Analyze(firstSide, secondSide, thirdSide));

                            break;

                        default:
                            if (option != 2)
                            {
                                Console.WriteLine("Please input within the menu options.");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect input. " + e.Message);
                    Console.WriteLine("Please input again");
                }

            } while (option != 2);
        }
    }
}

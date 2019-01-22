using System;

namespace Conditional_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What percent grade do you expect to get in this class?");

            try
            {
                string input = Console.ReadLine();

                int grade = int.Parse(input);

                if (grade >= 98)
                {
                    Console.WriteLine("Your letter grade is A+.");
                }
                else if ((grade >= 92) && (grade < 98))
                {
                    Console.WriteLine("Your letter grade is A.");
                }
                else if ((grade >= 90) && (grade < 92))
                {
                    Console.WriteLine("Your letter grade is A-.");
                }
                else if ((grade >= 88) && (grade < 90))
                {
                    Console.WriteLine("Your letter grade is B+.");
                }
                else if ((grade >= 82) && (grade < 88))
                {
                    Console.WriteLine("Your letter grade is B.");
                }
                else if ((grade >= 80) && (grade < 82))
                {
                    Console.WriteLine("Your letter grade is B-.");
                }
                else if ((grade >= 78) && (grade < 80))
                {
                    Console.WriteLine("Your letter grade is C+.");
                }
                else if ((grade >= 72) && (grade < 78))
                {
                    Console.WriteLine("Your letter grade is C.");
                }
                else if ((grade >= 70) && (grade < 72))
                {
                    Console.WriteLine("Your letter grade is C-.");
                }
                else if ((grade >= 68) && (grade < 70))
                {
                    Console.WriteLine("Your letter grade is D+.");
                }
                else if ((grade >= 62) && (grade < 68))
                {
                    Console.WriteLine("Your letter grade is D.");
                }
                else if ((grade >= 60) && (grade < 62))
                {
                    Console.WriteLine("Your letter grade is D-.");
                }
                else
                {
                    Console.WriteLine("Your letter grade is F.");
                }
            }
            catch
            {
                Console.WriteLine("Please use an integer data type for your grade.");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);
        }
    }
}

using CSharp_Basic_Exercises.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic_Exercises
{
    public class MathematicalProblems
    {
        public static void MathExercise()
        {
            Console.Clear();
            DisplayMenu();

            int choice = InputValidators.GetValidatedChoice("Choose from the menu: ", 1, Utils.MathExercises.Length);

            switch (choice)
            {
                case 1: ChoiceA(); break;
                case 2: ChoiceB(); break;
                default:
                    Console.WriteLine("Work in progress...");
                    Console.ReadKey();
                    break;
            }

        }

        static void DisplayMenu()
        {
            Console.WriteLine(@"Menu:");

            for (int i = 0; i < Utils.MathExercises.Length; i++) {
                Console.WriteLine($"{i + 1}. {Utils.MathExercises[i]}");
            }
        }

        static void ChoiceA()
        {
            Console.Clear();
            Console.WriteLine("=========== Specified Operations Results ===========");

            int count = InputValidators.GetValidatedChoice("How many numbers do you want to calculate? ", 2, 10);


            Console.Clear();
            Console.WriteLine("\nSelect an operation:");
            for (int i = 0; i < Utils.MathOperations.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Utils.MathOperations[i]}");
            }

            int opChoice = InputValidators.GetValidatedChoice("Select operation", 1, Utils.MathOperations.Length);

            double[] numbers = new double[count];
            for(int i = 0; i < count; i++)
            {
                while(true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    if(double.TryParse(Console.ReadLine(), out numbers[i])) { break; }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry! Please enter a valid decimal or integer.");
                    Console.ResetColor();
                }
            }

            double result = numbers[0];
            for(int i = 1; i < count; i++)
            {
                switch (opChoice)
                {
                    case 1: result += numbers[i]; break;
                    case 2: result -= numbers[i]; break;
                    case 3: result *= numbers[i]; break;
                    case 4:
                        if (numbers[i] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWarning: Skip division by zero at index {i + 1}.");
                            Console.ResetColor();
                        }
                        else 
                        { 
                            result /= numbers[i]; 
                        } 
                        break;
                    case 5:
                        if (numbers[i] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nWarning: Skip modulo by zero at index {i + 1}.");
                            Console.ResetColor();
                        }
                        else
                        {
                            result %= numbers[i];
                        }
                        break;
                }
            }

            Console.WriteLine($"\nResult:{result:F2}"); 

        }


        //ChoiceB
        static void ChoiceB()
        {
            Console.Clear();
            Console.WriteLine("=========== Swap Numbers ===========");
        }

        //ChoiceC
        static void ChoiceC()
        {
            Console.Clear();
            Console.WriteLine("=========== Arithmetic Operations ===========");
        }

        //ChoiceD
        static void ChoiceD()
        {
            Console.Clear();
            Console.WriteLine("=========== Average of Numbers ===========");
        }

        //ChoiceE
        static void ChoiceE()
        {
            Console.Clear();
            Console.WriteLine("=========== Sum of First 500 Primes ===========");
        }

        //ChoiceF
        static void ChoiceF()
        {
            Console.Clear();
            Console.WriteLine("=========== Print Odd Numbers 1 to 99 ===========");
        }
    }
}

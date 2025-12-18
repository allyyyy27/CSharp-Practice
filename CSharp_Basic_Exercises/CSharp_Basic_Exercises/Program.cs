using CSharp_Basic_Exercises.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Basic_Exercises
{
   class Program
    {
        public static void Main(string[] args)
        {
            /* 1. Get the name */
            string name = InputValidators.GetValidateName();
            Console.Clear();
            Console.WriteLine($"Hello, {name} !\n");

            /* 2. Display the menu */
            DisplayMenu();

            /* 3. Choose from the menu */
            int choice = GetValidatedChoice(1, Utils.MainMenu.Length);

            Console.ReadKey();
        }


        /* Function to get validated name */
        

        /* List of exercises */

        /* Function to Display the menu */
        static void DisplayMenu()
        {
            Console.WriteLine(@"Listed below are the C# exercises:");
            for(int i = 0; i < Utils.MainMenu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Utils.MainMenu[i]}");
            }
        }
        
        /* Function to get choice from menu */
        static int GetValidatedChoice(int min, int max)
        {
            int choice;
            bool isValid;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSelect an Exercise [1-5]: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.Trim();
                isValid = int.TryParse(input, out choice) && choice >= min && choice <= max;

                if (!isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: Please enter number between {min} & {max}.");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();

                    DisplayMenu();
                }

            }
            while (!isValid);


            switch (choice)
            {
                case 1:
                    MathematicalProblems.MathExercise(); // Calls the other file!
                    break;
                default:
                    Console.WriteLine("Feature coming soon...");
                    Console.ReadKey();
                    break;
            }

            return choice;
        }

    }
}

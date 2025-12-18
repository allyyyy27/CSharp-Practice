using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic_Exercises.Helpers
{
    public class InputValidators
    {
        //Validate input choice
        public static int GetValidatedChoice(string prompt, int min, int max)
        {
            int choice;
            bool isValid;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{prompt} [{min}-{max}]: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.Trim();
                isValid = int.TryParse(input, out choice) && choice >= min && choice <= max;

                if (!isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: Please enter a number between {min} & {max}.");
                    Console.ResetColor();
                }
            } while (!isValid);

            return choice;
        }

        //Validate inputted name
        public static string GetValidateName()
        {
            string name;
            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Name cannot be empty.");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            while (string.IsNullOrWhiteSpace(name));

            return name;
        }
    }
}

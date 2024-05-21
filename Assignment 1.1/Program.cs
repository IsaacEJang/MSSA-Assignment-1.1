using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name;
            decimal age;
            string address;

            // PART 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 1\n");

            // name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nHello " + name + "! Nice to meet you!");

            Console.WriteLine(); // spacer

            // age
            Console.WriteLine("Please enter your age: ");
            age = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nI can't believe you are only " + age + " years young!");

            Console.WriteLine(); // spacer

            // addresss
            Console.WriteLine("Please enter your address: ");
            address = Console.ReadLine();
            Console.WriteLine("\nYour address is " + address + ". I heard that is a great neighborhood!");

            Console.WriteLine(); // spacer

            // Transition
            Console.WriteLine("Press any key to continue to Part 2\n");
            Console.ReadKey();




            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 2\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Below are the min and max values for int, float, decimal, and double!\n");

            // int
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The minimum value of int is " + int.MinValue + ".");
            Console.WriteLine("The maximum value of int is " + int.MaxValue + ".");

            Console.WriteLine(); // spacer

            // float
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The minimum value of float is " + float.MinValue + ".");
            Console.WriteLine("The maximum value of float is " + float.MaxValue + ".");

            Console.WriteLine(); // spacer

            // decimal
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The minimum value of decimal is " + decimal.MinValue + ".");
            Console.WriteLine("The maximum value of decimal is " + decimal.MaxValue + ".");

            Console.WriteLine(); // spacer

            // double
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The minimum value of double is " + double.MinValue + ".");
            Console.WriteLine("The maximum value of double is " + double.MaxValue + ".");

            Console.WriteLine(); // spacer

            // Transition
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue to Part 3 & 4\n");
            Console.ReadKey();




            // PART 3 & 4
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 3 & 4\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter two numbers and I will tell you their sum and quotient!\n");

            // First number
            Console.WriteLine("Please enter your first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(); // spacer

            // Second number
            Console.WriteLine("Please enter your second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            // Math functions
            decimal sum = num1 + num2;
            decimal quo = num1 / num2;

            Console.WriteLine(); // spacer

            // Print Results
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your sum is " + sum + "!\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Your quotient is " + quo + "!");

            Console.ReadKey();
        }
    }
}

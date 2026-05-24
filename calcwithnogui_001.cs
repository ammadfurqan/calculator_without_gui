using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cal_opt = new List<string>
            {
                " Standard Options",
                " Advanced Options",
                " Converter Options"
            };
            int index_001 = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Select An Option\n");
                for (int i = 0; i < cal_opt.Count; i++)
                {
                    if (i == index_001)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"> {cal_opt[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {cal_opt[i]}");
                    }
                }
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    index_001--;
                    if (index_001 < 0) index_001 = cal_opt.Count - 1;
                }
                if (key == ConsoleKey.DownArrow)
                {
                    index_001++;
                    if (index_001 >= cal_opt.Count) index_001 = 0;
                }
                if (key == ConsoleKey.Enter) break;
            }

            Console.Clear();

            // Standard Options
            if (cal_opt[index_001] == " Standard Options")
            {
                List<string> stand_opt = new List<string>
                {
                    " Addition",
                    " Subtraction",
                    " Multiplication",
                    " Division"
                };
                int index_002 = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Standard Calculator - Please Select An Option\n");
                    for (int i = 0; i < stand_opt.Count; i++)
                    {
                        if (i == index_002)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine($"> {stand_opt[i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"  {stand_opt[i]}");
                        }
                    }
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        index_002--;
                        if (index_002 < 0) index_002 = stand_opt.Count - 1;
                    }
                    if (key == ConsoleKey.DownArrow)
                    {
                        index_002++;
                        if (index_002 >= stand_opt.Count) index_002 = 0;
                    }
                    if (key == ConsoleKey.Enter) break;
                }

                Console.Clear();
                Console.WriteLine($"You selected: {stand_opt[index_002]}\n");

                double num1 = 0, num2 = 0, result = 0;
                bool validInput = false;

                // Get first number
                while (!validInput)
                {
                    Console.Write("Enter first number: ");
                    if (double.TryParse(Console.ReadLine(), out num1))
                        validInput = true;
                    else
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                }

                validInput = false;
                // Get second number
                while (!validInput)
                {
                    Console.Write("Enter second number: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                        validInput = true;
                    else
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                }

                Console.WriteLine();

                switch (stand_opt[index_002])
                {
                    case " Addition":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case " Subtraction":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case " Multiplication":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} × {num2} = {result}");
                        break;
                    case " Division":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} ÷ {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                        }
                        break;
                }
            }

            // Advanced Options
            else if (cal_opt[index_001] == " Advanced Options")
            {
                List<string> adv_opt = new List<string>
                {
                    " Power (x^y)",
                    " Square Root",
                    " Percentage",
                    " Modulus"
                };
                int index_003 = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Advanced Calculator - Please Select An Option\n");
                    for (int i = 0; i < adv_opt.Count; i++)
                    {
                        if (i == index_003)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine($"> {adv_opt[i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"  {adv_opt[i]}");
                        }
                    }
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        index_003--;
                        if (index_003 < 0) index_003 = adv_opt.Count - 1;
                    }
                    if (key == ConsoleKey.DownArrow)
                    {
                        index_003++;
                        if (index_003 >= adv_opt.Count) index_003 = 0;
                    }
                    if (key == ConsoleKey.Enter) break;
                }

                Console.Clear();
                Console.WriteLine($"You selected: {adv_opt[index_003]}\n");

                double num1 = 0, num2 = 0, result = 0;
                bool validInput = false;

                switch (adv_opt[index_003])
                {
                    case " Power (x^y)":
                        // Get base number
                        while (!validInput)
                        {
                            Console.Write("Enter base number: ");
                            if (double.TryParse(Console.ReadLine(), out num1))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        validInput = false;
                        // Get exponent
                        while (!validInput)
                        {
                            Console.Write("Enter exponent: ");
                            if (double.TryParse(Console.ReadLine(), out num2))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        result = Math.Pow(num1, num2);
                        Console.WriteLine($"\nResult: {num1}^{num2} = {result}");
                        break;

                    case " Square Root":
                        while (!validInput)
                        {
                            Console.Write("Enter a number: ");
                            if (double.TryParse(Console.ReadLine(), out num1))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        if (num1 >= 0)
                        {
                            result = Math.Sqrt(num1);
                            Console.WriteLine($"\nResult: √{num1} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Cannot calculate square root of a negative number!");
                        }
                        break;

                    case " Percentage":
                        while (!validInput)
                        {
                            Console.Write("Enter the total value: ");
                            if (double.TryParse(Console.ReadLine(), out num1))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        validInput = false;
                        while (!validInput)
                        {
                            Console.Write("Enter the percentage to calculate: ");
                            if (double.TryParse(Console.ReadLine(), out num2))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        result = (num2 / 100) * num1;
                        Console.WriteLine($"\nResult: {num2}% of {num1} = {result}");
                        break;

                    case " Modulus":
                        while (!validInput)
                        {
                            Console.Write("Enter first number: ");
                            if (double.TryParse(Console.ReadLine(), out num1))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        validInput = false;
                        while (!validInput)
                        {
                            Console.Write("Enter second number: ");
                            if (double.TryParse(Console.ReadLine(), out num2))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }

                        if (num2 != 0)
                        {
                            result = num1 % num2;
                            Console.WriteLine($"\nResult: {num1} % {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Cannot calculate modulus with zero!");
                        }
                        break;
                }
            }

            // Converter Options
            else if (cal_opt[index_001] == " Converter Options")
            {
                List<string> conv_opt = new List<string>
                {
                    " Celsius to Fahrenheit",
                    " Fahrenheit to Celsius",
                    " Kilometers to Miles",
                    " Miles to Kilometers"
                };
                int index_004 = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Unit Converter - Please Select An Option\n");
                    for (int i = 0; i < conv_opt.Count; i++)
                    {
                        if (i == index_004)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine($"> {conv_opt[i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"  {conv_opt[i]}");
                        }
                    }
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        index_004--;
                        if (index_004 < 0) index_004 = conv_opt.Count - 1;
                    }
                    if (key == ConsoleKey.DownArrow)
                    {
                        index_004++;
                        if (index_004 >= conv_opt.Count) index_004 = 0;
                    }
                    if (key == ConsoleKey.Enter) break;
                }

                Console.Clear();
                Console.WriteLine($"You selected: {conv_opt[index_004]}\n");

                double input = 0, result = 0;
                bool validInput = false;

                switch (conv_opt[index_004])
                {
                    case " Celsius to Fahrenheit":
                        while (!validInput)
                        {
                            Console.Write("Enter temperature in Celsius: ");
                            if (double.TryParse(Console.ReadLine(), out input))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }
                        result = (input * 9 / 5) + 32;
                        Console.WriteLine($"\n{input}°C = {result}°F");
                        break;

                    case " Fahrenheit to Celsius":
                        while (!validInput)
                        {
                            Console.Write("Enter temperature in Fahrenheit: ");
                            if (double.TryParse(Console.ReadLine(), out input))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }
                        result = (input - 32) * 5 / 9;
                        Console.WriteLine($"\n{input}°F = {result}°C");
                        break;

                    case " Kilometers to Miles":
                        while (!validInput)
                        {
                            Console.Write("Enter distance in kilometers: ");
                            if (double.TryParse(Console.ReadLine(), out input))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }
                        result = input * 0.621371;
                        Console.WriteLine($"\n{input} km = {result} miles");
                        break;

                    case " Miles to Kilometers":
                        while (!validInput)
                        {
                            Console.Write("Enter distance in miles: ");
                            if (double.TryParse(Console.ReadLine(), out input))
                                validInput = true;
                            else
                                Console.WriteLine("Invalid input! Please enter a valid number.");
                        }
                        result = input * 1.60934;
                        Console.WriteLine($"\n{input} miles = {result} km");
                        break;
                }
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
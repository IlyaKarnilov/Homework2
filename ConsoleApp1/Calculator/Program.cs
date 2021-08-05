using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }
        static void Calculator()
        {
            double first, second;
            Console.Clear();
            Console.WriteLine("Choose operation: \nsum of two numbers = \"+\" \nsum of a series of numbers = \"+++\" \ndiff of two numbers = \"-\" " +
                              "\nmultiplication of two numbers = \"*\" \ndividing of two numbers = \"/\" \nexponentiation numbers = \"^\" " +
                              "\nfactorial = \"!\" \nequation = \"equ\" \nto stop - \"stop\"" );
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+": 
                    Console.WriteLine("First value");
                    first = InputDoubleValue();
                    Console.WriteLine("Second value");
                    second = InputDoubleValue();
                    Console.WriteLine($"{first} + {second} = {first+second}");break;
                case "-":
                    Console.WriteLine("First value");
                    first = InputDoubleValue();
                    Console.WriteLine("Second value");
                    second = InputDoubleValue();
                    Console.WriteLine($"{first} - {second} = {first-second}");break;
                case "*":
                    Console.WriteLine("First value");
                    first = InputDoubleValue();
                    Console.WriteLine("Second value");
                    second = InputDoubleValue();
                    Console.WriteLine($"{first} * {second} = {first*second}");break;
                case "^":
                    Console.WriteLine("First value");
                    first = InputDoubleValue();
                    Console.WriteLine("Second value");
                    second = InputDoubleValue();
                    Console.WriteLine ($"{first} ^ {second} = {Math.Pow(first, second)}");break;
                case "!":
                    Console.WriteLine("value");
                    first = InputDoubleValue();
                    second = Factorial(first);
                    if (second != 0)
                    {
                        Console.WriteLine($"!{first} = {second}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid value");
                    }
                    break;
                case "/":
                    Console.WriteLine("First value");
                    first = InputDoubleValue();
                    Console.WriteLine("Second value");
                    second = InputDoubleValue();
                    Console.WriteLine($"{first} / {second} = {first/second}");break;
                case "+++": Console.WriteLine("to stop enter 0");
                        double sum = 0;
                        double value = 1;
                        while (value != 0)
                        {
                            value = InputDoubleValue();
                            sum += value;
                        } 
                        Console.WriteLine($"sum = {sum}");
                        break;
                case "equ":
                    Console.WriteLine("Enter equation (value operation value)");
                    string line = Console.ReadLine();
                    string eqe = EquationInput(line);
                    if (eqe == null)
                    {
                        break;
                    }
                    Console.WriteLine($"{line} = {eqe}");
                    break;
                case "stop":Console.Clear(); return;
                default: Console.WriteLine("Incorrect operation");break;
            }
            Console.WriteLine("To continue press any button");
            Console.ReadLine();
            Console.Clear();
            Calculator();
        }
        static string EquationInput(string line)
        {
            string[] words = line.Split(' ');
            if (words.Length != 3)
            {
                Console.WriteLine("Incorrect equation");
            }
            double sum = 0;
            double first;
            if (!double.TryParse(words[0], out first))
            {
                Console.WriteLine("Incorrect equation");
                return null;
            }
            double second;
            if (!double.TryParse(words[2], out second))
            {
                Console.WriteLine("Incorrect equation");
                return null;
            }

            switch (words[1])
            {
                case "+" : sum = first + second;break;
                case "-" : sum = first - second;break;
                case "*" : sum = first * second;break;
                case "/" :
                    if (second != 0) sum = first / second;
                    else return null;break;
            }
            string strSum = sum.ToString();
            return strSum;
        }// Vvodit' prostoe yrovnenie tipa "12 + 3"
        static double Factorial(double value)
        {
            if (value == 0){return 1;}
            else if (value < 0) { return 0;}
            else {return value * Factorial(value - 1);}
        }
        static double InputDoubleValue()
        {
            double a;
            Console.WriteLine("Input value");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid value! Try again");
            }
            return a;
        }
    }
}
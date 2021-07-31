using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Are you want to see TRIANGLE????\nOr UsE CalcUlAtOr?");
            string answer = String.Empty;
            
            while (answer != "stop")
            {
                string stop= string.Empty;
                Console.WriteLine(" This is commands that can be used:\n" +
                                  " -first ex\n -second ex\n -TRIANGLE\n -calculator\n -stop");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "first ex":
                        while (stop!="stop")
                        {
                             FirstEx();
                             Console.WriteLine("To escape enter \"stop\", to continue press any button");
                             stop = Console.ReadLine();
                        }break;
                    case "second ex":
                        while (stop!="stop")
                        {
                            SecondEx();
                            Console.WriteLine("To escape enter \"stop\", to continue press any button");
                            stop = Console.ReadLine();
                        }break;
                    case "TRIANGLE":
                        while (stop!="stop")
                        {
                            Triangle();
                            Console.WriteLine("To escape enter \"stop\", to continue press any button");
                            stop = Console.ReadLine();
                        }break;
                    case "calculator":
                        while (stop!="stop")
                        {
                            Calculator();
                            Console.WriteLine("To escape enter \"stop\", to continue press any button");
                            stop = Console.ReadLine();
                        }break;
                    case "stop":break;
                    default:
                        Console.WriteLine("Invalid command");break;
                }
                Console.Clear();
            }
            
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
        private static void FirstEx(double sum = 0, int counter=0)
        {
            double value = InputDoubleValue();
            if (value == 0)
            {
                var average=sum / counter;
                Console.WriteLine("Number of enters: "+counter+"\nSumm: "+sum+"\nAverage value: "+average);
                return;
            }
            else
            {
                sum += value;
                counter++;
                FirstEx(sum,counter);
            }
        }
        static void SecondEx()
        {
            Console.WriteLine("First int");
            int first = Convert.ToInt32(InputDoubleValue());
            Console.WriteLine("Second int");
            int second = Convert.ToInt32(InputDoubleValue());
            int sum = 0;
            for (int i = first; i <= second; i++)
            {
                if (i % 2 != 0) sum+=i;
            }
            Console.WriteLine(sum);
        }
        static void Triangle()
        {
            Console.WriteLine("Enter int value");
          int value = Convert.ToInt32(Console.ReadLine());
                      if (value<=0)
                      {
                          Console.WriteLine("invalid value");
                          return ;
                      }
                      int row = 0;
                      for (int i = 0; i < value; i++)
                      {
                          if (i % 2 == 0) row++;
                      }
                      int first,last;
                      last = first = row;
                      if (value % 2 == 0) value--;
                      for (int i =0; i<row; i++)
                      {
                          for (int j=0;j<value+1;j++)
                          {
                              if (j >= first && j<=last) Console.Write('^');
                              else Console.Write(' ');
                          }
                          first--;
                          last++;
                          Console.WriteLine();
                      }  
        }
        static void Calculator()
        {
            double first, second;
            Console.Clear();
            Console.WriteLine("Choose operation: \nsum of two numbers = \"+\" \nsum of a series of numbers = \"+++\" \ndiff of two numbers = \"-\" " +
                              "\nmultiplication of two numbers = \"*\" \ndividing of two numbers = \"/\" \nexponentiation numbers = \"^\" \nfactorial = \"!\" \nequation = \"equ\"");
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
                default: Console.WriteLine("Incorrect operation");break;
            }
        }
        static double Factorial(double value)
        {
            if (value == 0){return 1;}
            else if (value < 0) { return 0;}
            else {return value * Factorial(value - 1);}
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
        } // Vvodit' prostoe yrovnenie tipa "12 + 3"  
    }
}
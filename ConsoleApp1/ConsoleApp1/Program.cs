﻿using System;

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
                              "\nmultiplication of two numbers = \"*\" \ndividing of two numbers = \"/\" ");
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
                default: Console.WriteLine("Incorrect operation");break;
            }
        }
    }
}
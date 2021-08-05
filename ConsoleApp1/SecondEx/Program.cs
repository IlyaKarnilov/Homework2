using System;

namespace SecondEx
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondEx();
        }
        static void SecondEx()
        {
            Console.WriteLine("First int");
            int first = Convert.ToInt32(InputDoubleValue());
            Console.WriteLine("Second int");
            int second = Convert.ToInt32(InputDoubleValue());
            int sum = 0;
            if (first < second)
            {
                for (int i = first; i <= second; i++)
                {
                    if (i % 2 != 0) sum+=i;
                }
            }
            else
            {
                for (int i = second; i <= first; i++)
                {
                    if (i % 2 != 0) sum+=i;
                }
            }
            Console.WriteLine($"сумма нечетных чисел в выбранном промежутке = {sum}");
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
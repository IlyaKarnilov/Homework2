using System;

namespace FirstEx
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstEx();
        }
        static void FirstEx(double sum = 0, int counter=0)
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
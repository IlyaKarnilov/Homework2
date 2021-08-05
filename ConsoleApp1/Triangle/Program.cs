using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle();
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
    }
}
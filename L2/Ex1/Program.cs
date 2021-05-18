using System;

namespace Ex1
{
    class Program
    {
        static Int32 min(int a, int b, int c)
        {
            int min = 0;
            if (a < b)
            {
                if (a < c)
                {
                    min = a;
                }
                else min = c;
            }
            else if (b < c)
            {
                min = b;
            }
            else min = c;
            return min;
        }
             
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите первое число ");
            int fNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите второе число ");
            int sNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите третье число ");
            int tNumber = int.Parse(Console.ReadLine());
            //min(fNumber, sNumber, tNumber);
            Console.WriteLine("Минимальное число из трех: " + min(fNumber, sNumber, tNumber));
            

        }
    }
}

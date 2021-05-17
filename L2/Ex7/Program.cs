using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 число");
            int fNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("2 число");
            int sNumber = int.Parse(Console.ReadLine());
            if (fNumber > sNumber)
            {
                int a = sNumber;
                int b = fNumber;
                Loop(a, b);
                
                Console.WriteLine($" {Sum(a, b)} ");
            }
            else
            {
                int a = fNumber;
                int b = sNumber;
                Loop(a, b);
                
                Console.WriteLine($" {Sum(a, b)} ");
            }

        }
        static void Loop(int a, int b)
        {
            Console.Write("{0,4}", a);
            if (a < b)
                Loop(a + 1, b);
        }
        static Int32 Sum(int a, int b)
        {
            int sum = a;
            for (int i = 0; i <= b; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }   
}

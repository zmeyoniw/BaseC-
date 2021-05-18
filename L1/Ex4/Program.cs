using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);

            Console.WriteLine("Введите первое число ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            int e = int.Parse(Console.ReadLine());
            d = d + e;
            e = d - e;
            d = d - e;
            Console.WriteLine(d + " " + e);
        }
    }
}

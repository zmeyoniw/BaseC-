using System;

namespace Ex2
{
    class Program
    {
        static int length(int a)
        {
            int ind = 0;
            do
            {
                a = a / 10;
                ind++;
            } while (a > 0);
            return ind;
        } 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе: {length(number)}");
            Console.ReadLine();
        }
    }
}

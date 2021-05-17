using System;

namespace Ex3
{
    class Program
    {

        
        static void Main(string[] args)
        {
            int a=2;
            int sum = 0;
            while(a!=0) 
            {
                Console.WriteLine("Введите число: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0)
                    sum = sum + a;
            }                
            Console.WriteLine("сумма нечетных чисел: " + sum);
                 
            
        }
    }
}

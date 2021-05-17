using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост ");
            double h = double.Parse(Console.ReadLine()) / 100;
            double l = m / (h * h);
            Console.WriteLine("Индекс массы тела(ИМТ) равен " + l);

        }
    }
}

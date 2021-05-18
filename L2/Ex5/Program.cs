using System;

namespace Ex5
{
    class Program
    {
        static Double Weigth(double h, double m)
        {
            double value = 0;
            double mNormal = (h * h) * 22;
            if (m > mNormal)
            {
                value = m - mNormal;
                
            }
            else if (m < mNormal)
            {
                value = mNormal - m;
                
            }
            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу тела: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост: ");
            double h = double.Parse(Console.ReadLine()) / 100;
            double l = m / (h * h);
            if (l >= 18.5 && l <= 25)
                Console.WriteLine("Вы в прекрасной форме");
            else if (l < 18.5)
                Console.WriteLine("Вам стоит поправится на " + Math.Round( Weigth(h, m),1) + "кг");
            else if (l > 25)
                Console.WriteLine("Вам стоит похудеть на " + Math.Round(Weigth(h, m), 1) + "кг.");
        }
    }
}

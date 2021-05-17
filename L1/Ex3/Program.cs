using System;

namespace Ex3
{
    class Program
    {
        static double dist(double a1, double a2, double b1, double b2)
        {
            double r = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2));
            return r;
        }
        static void Main(string[] args)
        {
           //#region a
           // Console.WriteLine("Введите горизонтальную координату первой точки");
           // double aX = double.Parse(Console.ReadLine());
           // Console.WriteLine("Введите вертикальную координату первой точки");
           // double aY = double.Parse(Console.ReadLine());
           // Console.WriteLine("Введите горизонтальную координату второй точки");
           // double bX = double.Parse(Console.ReadLine());
           // Console.WriteLine("Введите вертикальную координату второй точки");
           // double bY = double.Parse(Console.ReadLine());
           // double r = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2));
           // Console.WriteLine("Растояние между точками " + "{0:F2}", r);
           // #endregion

            #region b
            Console.WriteLine("Введите горизонтальную координату первой точки");
            double aX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную координату первой точки");
            double aY = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите горизонтальную координату второй точки");
            double bX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную координату второй точки");
            double bY = double.Parse(Console.ReadLine());            
            double r =  dist (aX, aY, bX, bY );
            Console.WriteLine("Растояние между точками " + "{0:F2}", r);
            #endregion

        }
    }
}

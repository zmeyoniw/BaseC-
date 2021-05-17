using System;

namespace Ex5
{
    class Program
    {
        static void message (string a,string b,string c)
        {
            string d = a + " " + b + " " + c;
            int centerX = (Console.WindowWidth / 2) - (d.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(d);
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя ");
            string name = Console.ReadLine();
            Console.WriteLine("Введиет фамилию ");
            string sName = Console.ReadLine();
            Console.WriteLine("Введите город ");
            string city = Console.ReadLine();
            message(name, sName, city);
        }
    }
}

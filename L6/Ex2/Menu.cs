using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    
    class Menu
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Вывод минимума функции.\n для функции 'f(x)=x*x-50*x+10' нажмите q.\n для функции 'f(x)=x*x*x' нажмите w.\n для функции 'f(x)=y*(x*x)' нажмите e.\n для функции 'f(x)=y*sin(x)' нажмите r.\n для выхода нажмите Escape.");
                switch (Console.ReadKey(true).Key)
                {
                    
                    case ConsoleKey.Q:
                        Console.WriteLine("Введите начало интервала: ");
                        double start = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите конец интервала: ");
                        double end = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите шаг: ");
                        double step = Double.Parse(Console.ReadLine());
                        SaveLoad.SaveFunc("data.bin", new Fun(Function.F), start, end, step);
                        Console.WriteLine(SaveLoad.Load("data.bin"));
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("Введите начало интервала: ");
                        start = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите конец интервала: ");
                        end = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите шаг: ");
                        step = Double.Parse(Console.ReadLine());
                        SaveLoad.SaveFunc("data.bin", new Fun(Function.FuncCube), start, end, step);
                        Console.WriteLine(SaveLoad.Load("data.bin"));
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Введите начало интервала: ");
                        start = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите конец интервала: ");
                        end = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите шаг: ");
                        step = Double.Parse(Console.ReadLine());
                        SaveLoad.SaveFunc("data.bin", new Fun(Function.Func), start, end, step);
                        Console.WriteLine(SaveLoad.Load("data.bin"));
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("Введите начало интервала: ");
                        start = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите конец интервала: ");
                        end = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите шаг: ");
                        step = Double.Parse(Console.ReadLine());
                        SaveLoad.SaveFunc("data.bin", new Fun(Function.FuncSin), start, end, step);
                        Console.WriteLine(SaveLoad.Load("data.bin"));
                        break;
                    case ConsoleKey.Escape:
                        return;

                }
            }
        }
    }
}

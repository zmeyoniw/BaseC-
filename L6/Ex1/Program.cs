using System;
using Ex1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица функции x^3");
        Tables.Table(new Fun(Function.FuncCube), -2, 2);
        Console.WriteLine("Таблица функции a*x^2");
        Tables.Table(new Fun(Function.Func), -2, 2);
        Console.WriteLine("Таблица функции a*sin(x)");
        Tables.Table(new Fun(Function.FuncSin), -2, 2);      
    }
}


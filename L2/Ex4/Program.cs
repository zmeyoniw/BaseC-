using System;

namespace Ex4
{
    class Program
    {
        static void check(string a, string b)
        {
            int count = 3;
            do
            {
                string rigthLog = "root";
            string rigthPas = "GeekBrains";
            if (a == rigthLog)
            {
                if (b == rigthPas)
                {
                    Console.WriteLine("Все верно.");
                    return;
                }

                else
                    Console.WriteLine("Неверный пароль.");
                    count--;
                }
            else
                Console.WriteLine("Неверный логин");
                count--;
            } while (count > 0);
        }
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите логин: ");
                string log = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string pas = Console.ReadLine();
                check(log, pas);
        }
    }
}

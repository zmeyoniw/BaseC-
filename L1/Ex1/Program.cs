using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            string sName = Console.ReadLine();
            Console.Write("Возраст ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Рост ");
            int heigth = int.Parse(Console.ReadLine());
            Console.Write("Вес ");
            int weigth = int.Parse(Console.ReadLine());

            //a склеивание
            Console.WriteLine(sName + " " + name + " " + age + " " + heigth + " " + weigth);
            //b форматированый вывод
            Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", sName, name, age, heigth, weigth));
            //c вывод со знаком $
            Console.WriteLine($"{ sName} {name} { age} { heigth} { weigth}");
        }
    }
}

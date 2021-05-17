using System;
using System.IO;
using ArrayLibrary;


namespace Ex2
{
    
    
    static class GreatArray
    {
        public static int [] FixArray(int n, int min, int max)
        {
            int[] a;
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            Div.Div3(a);
            return a;
        }
        public static int[] MakeArray(int n, int f, int s)
        {
            int[] a;
            a = new int[n];
            a[0] = f;
            for (int i = 1; i < n; i++)
                a[i] = a[i] + s;
            return a;
        }
    }
    static class Div
    {
        public static int Div3(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0 && a[i + 1] % 3 != 0)
                    count++;
            }
            Console.WriteLine(count);
            return count;
        }
    }
    public static class ReadFile
    {
        public static void CheckFile()
        {
            string path = @"C:\Users\Юлия\source\repos\Bases-C-\HomeWorkBasicC\HomeWorkBasicC\L4\Ex2\file.txt";
            if (File.Exists(path))
                ReadArray(path);
            else
                Console.WriteLine("Ошибка.Файл не найден");
        }
        public static int[] ReadArray(string filename)
        {
            int[] a;
            string[] ss = File.ReadAllLines(filename);
            a = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
                a[i] = int.Parse(ss[i]);
            Div.Div3(a);
            return a;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            GreatArray.FixArray(20, -10000, 10000);
            ReadFile.CheckFile();
            
            //в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция )

            Console.WriteLine("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый элемент массива: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число на которое будет увеличиватся элемент массива: ");
            int s = int.Parse(Console.ReadLine());
            GreatArray.MakeArray(n, f, s);
            Console.WriteLine("На какое число умножить элементы массива : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Calc.Inverse(GreatArray.MakeArray(n, f, s))}");
            Console.WriteLine($"{Calc.Multy(GreatArray.MakeArray(n, f, s),b)}");
        }
    }
}

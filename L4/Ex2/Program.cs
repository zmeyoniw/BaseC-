using System;
using System.IO;

namespace Ex2
{
    class FixArray
    {
        public int[] a;
        public FixArray(int n,int min,int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            Div.Div3(a);
        }
    }
    static class Div 
    { 
        
        public static int Div3(int[]a)
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
            FixArray a = new FixArray(20, -10000, 10000);
            ReadFile.CheckFile();
           
        }
    }
}

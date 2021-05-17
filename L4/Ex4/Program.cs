using System;
using System.IO;

namespace Ex4
{
    struct Account
    {
        //public string[] c;
        public static string[,] UserAnswer(string a, string b)
        {
            string[,] c = { a, b };

            return c;
        }
        static string[,] account;
        public static void CheckFile()
        {
            string path = @"C:\Users\Юлия\source\repos\Bases-C-\HomeWorkBasicC\HomeWorkBasicC\L4\Ex4\file.txt";
            if (File.Exists(path)) ReadFile(path);
            else Console.WriteLine("Ошибка.Файл не найден");
            return;
        }
        public static string[,] ReadFile(string a)
        {
            string[] s = File.ReadAllLines(a);
            account = new string[s.Length, s[0].Split(' ').Length];
            for (int i = 0; i < s.Length; i++)
            {
                string[] Temp = s[i].Split(' ');
                for (int j = 0; j < s.Length; j++)
                    account[i, j] = Temp[j];
            }
            return account;
        }
            public void Check(string a)
            {
            for (int i = 0; i < account.Length; i++)
            {
                for (int j = 0; j < account.Length; j++)
                    if (a[b,c] == account[i,j])
                    {
                        Console.WriteLine("Welcome");
                    }
                    else Console.WriteLine("Неверный логин или пароль");
            }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("");
                string a = Console.ReadLine();
                Console.WriteLine("");
                string b = Console.ReadLine();
                Account.CheckFile();
                Account.UserAnswer(a, b);
                Account.Check();

            }
        }
     
}

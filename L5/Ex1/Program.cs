using System;

namespace Ex1
{
    class Login
    {
        public static void Cheak(string a)
        {
            a.ToCharArray();
            if (Char.IsLetter(a[0]))
                if(a.Length > 2 && a.Length < 10)
                    for (int i = 0; i < a.Length; i++) if (Char.IsDigit(a[i]) || a[i] >= 'a' && a[i] <= 'z' || a[i] >= 'A' && a[i] <= 'Z') Console.WriteLine("Все ок");
            else Console.WriteLine("Некорректный Логин");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин. \nОт 2 до 10 символов. \nТолько латинские буквы и цифры. \nПервый символ не может быть цифрой.\n");
            Login.Cheak(Console.ReadLine());
        }
    }
}

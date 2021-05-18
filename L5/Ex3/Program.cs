using System;

namespace Ex3
{
    class CompareWords
    {
        public static double ArraySum(char[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++) sum += Char.GetNumericValue(a[i]);
            return sum;
        }
        public static void Compare(double a, double b)
        {
            if (a == b) Console.WriteLine("Является перестановкой");
            else Console.WriteLine("Не является перестановкой");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                // *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
                //Например: badc являются перестановкой abcd.
                string a = "badc";
                string b = "abcd";
                CompareWords.Compare(CompareWords.ArraySum(a.ToCharArray()), CompareWords.ArraySum(b.ToCharArray()));
        }
    }
}

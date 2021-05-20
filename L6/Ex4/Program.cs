using System;


namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileSpace = @"C:\Users\Юлия\source\repos\Bases-C-\HomeWorkBasicC\HomeWorkBasicC\L6\Ex4\TextFile1.txt";
            Console.WriteLine(Read.SR(FileSpace));
            Console.ReadKey();
            Console.Clear();
            foreach (var a in Read.BS(FileSpace)) Console.WriteLine($"{a} ");
            Console.ReadKey();
            Console.Clear();
            foreach (var a in Read.FS(FileSpace)) Console.WriteLine($"{a} ");
            Console.ReadKey();
            Console.Clear();
            foreach (var a in Read.BR(FileSpace)) Console.WriteLine($"{a} ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

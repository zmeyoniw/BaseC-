using System;

namespace Ex4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GenList.Generate();
            foreach (var e in new Repo().Sort().Print().BadStudent()) Console.WriteLine(e);
        }
    }
}

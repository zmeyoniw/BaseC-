using System;

namespace Ex6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i < 1000; i++)
                if (goodNumber(i))
                {
                    count++;
                }
            Console.WriteLine(DateTime.Now - start);
            Console.WriteLine(count);
        }
        static bool goodNumber(int a)
        {

            if (a % Sum(a) == 0)
                return true;
            else return false;
        }
        static Int32 Sum(int a)
        {
            if (a == 0)
                return 0;
            else return Sum(a / 10) + a % 10;
        }
    }
}

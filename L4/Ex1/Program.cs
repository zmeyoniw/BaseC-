using System;

namespace Ex1
{
    class FixArray
    {
        int[] a;
        public FixArray(int n, int min, int max)
        {
            
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
          
        }
        public int Div3
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 3 == 0 && a[i + 1] % 3 != 0)
                        count++;
                }
                return count;
            }
        }
        }

    
    class Program 
    { 
        static void Main(string[] args)
        {
            FixArray a = new FixArray(20, -10000, 10000);
            
            Console.WriteLine(a.Div3);
               
        }
    }
}

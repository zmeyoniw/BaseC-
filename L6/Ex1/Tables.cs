using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Tables
    {
        public static void Table(Fun F, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (a <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", a, F(a, b));
                a += 1;
            }
            Console.WriteLine("---------------------");
        }
    }
}

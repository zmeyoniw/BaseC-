using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public delegate double Fun(double a, double b);
    public class Function
    {
        public static double F(double x,double y)
        {
            return x * x - 50 * x + 10;
        }
        public static double FuncCube(double x, double y)
        {
            return x * x * x;
        }
        public static double Func(double x, double y)
        {
            return y * (x * x);
        }
        public static double FuncSin(double x, double y)
        {
            return y * Math.Sin(x);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex2
{
    class SaveLoad
    {
        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new(fs);
            while (a <= b)
            {
                bw.Write(F(a, b));
                a += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
    }
}

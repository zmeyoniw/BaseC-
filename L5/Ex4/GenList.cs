using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex4
{
    class GenList
    {
        static public void Generate(string path = "db.txt",int count = 100)
        {
            File.Delete(path);
            Random r = new Random();
            System.IO.File.AppendAllText(path, $"{count}\n");
            for(int i =0; i< count; i++)
            {
                System.IO.File.AppendAllText(path, $"Фамилия_{i+1} Имя_{i + 1} {r.Next(1,6)} {r.Next(1, 6)} {r.Next(1, 6)}\n");
            }
        }
    }
}

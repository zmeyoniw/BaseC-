using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Ex4
{
    public class Read
    {
        public static string SR(string path)
        {
            StreamReader sr = new (path);
            string line = sr.ReadToEnd();
            return line;
            
        }
        public static int[] BR(string path)
        {
            int[] a;
            using FileStream fs = File.OpenRead(path);
            a = new int[fs.Length];
            using BinaryReader br = new (fs);
            for (int i = 0; i < fs.Length; i++)
                a[i] = br.Read();
                     return a;
        } 
        public static byte[] FS(string path)
        {
            using FileStream fs = File.OpenRead(path);
            byte[] b = new byte[fs.Length];
            fs.Read(b, 0, b.Length);
            return b;
        }
        public static byte[] BS(string path)
        {
            FileStream fs = File.OpenRead(path) ;
            byte[] b = new byte[fs.Length];
            BufferedStream bs = new (fs) ;
            bs.Read(b, 0, b.Length);
            return b;
        }
    }
}

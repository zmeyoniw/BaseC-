using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class GenerateList
    {
        static public List<Student> Gen(int count = 100)
        {
            List<Student> result = new();
            Random r = new();
            for(int i = 0; i < count; i++)
            {
                result.Add(new Student($"фамилия_{i + 1}",$"имя_{ i + 1 }",$"универ_{i + 1}",$"факультет_{ i + 1}", $"департ_{i + 1}",r.Next(1,6), r.Next(16,25), r.Next(1,6), $"город_{i + 1}"));
            }
            return result;
        }
    }
    
    
}

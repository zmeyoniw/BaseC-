using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Repo
    {
        int count;
        Student[] students;
        public Repo(string path = "db.txt")
        {
            using(StreamReader sr = new StreamReader(path))
            {
                this.count = Convert.ToInt32(sr.ReadLine());
                this.students = new Student[this.count];
                for(int i = 0; i< this.count; i++)
                {
                    var args = sr.ReadLine().Split(' ');
                    this.students[i] = new Student(lName: args[0], fName: args[1], Marks: new int[] { Convert.ToInt32(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]) });
                }
            }
        }
        public Repo Print()
        {
            Console.WriteLine("\n----------------\n");
            foreach(var e in this.students)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\n----------------\n");
            return this;
        }
        public Student[] BadStudent()
        {
            Student[] temp;
            int k = 0, length = 0;
            for(int i = 1; i< this.students.Length; i++)
            {
                if (this.students[i].avMark != this.students[i - 1].avMark) k++;
                if (k == 3) { length = i;break; }
            }
            temp = new Student[length];
            Array.Copy(this.students, temp, length);
            return temp;
        }
        public Repo Sort()
        {
            Array.Sort(this.students, SortMethod);
            return this;
        }
        int SortMethod(Student x,Student y)
        {
            return x.avMark < y.avMark ? -1 : 1;
        }
    }
}

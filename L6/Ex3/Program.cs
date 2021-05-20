using System;
using System.Collections.Generic;

namespace Ex3
{
    class Program
    {
        static void Print(List<Student> db)
        {
            for (int i = 0; i < db.Count; i++) Console.WriteLine($"{i,3}. {db[i]}");
            Console.WriteLine();
        }
        static int A(List<Student> db)
        {
            int result = 0;
            foreach(var a in db) if (a.course >= 5) result++; return result;
        }
        static Dictionary<int, int> B(List<Student> db)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 1; i <= 6; i++) result.Add(i, 0);
            foreach (var a in db) if (a.age >= 18 && a.age <= 20) result[a.course]++; return result;
        }
        static void C(List<Student> db)
        {
            int start = 0;
            int i = 0;
            for(i = 0; i < db.Count; i++)
            {
                if(db[i].course != db[start].course)
                {
                    Sort(db, start, i);
                    start = i;
                }
            }
            Sort(db, start, i);
        }
        static void minAge(List<Student> db)
        {
            for(int i = 0; i < db.Count; i++)
            {
                int min = db[i].age;
                int pos = i;
                for(int j = i; j < db.Count; j++)
                {
                    if(db[j].age < min)
                    {
                        min = db[j].age;
                        pos = j;
                    }
                }
                Student t = db[i];
                db[i] = db[pos];
                db[pos] = t;
            }
        }
        static void minCourse(List<Student> db)
        {
            for(int i = 0; i < db.Count; i++)
            {
                int min = db[i].course;
                int pos = i;
                for (int j = i; j < db.Count; j++)
                {
                    if (db[j].course < min)
                    {
                        min = db[j].course;
                        pos = j;
                    }
                }
                Student t = db[i];
                db[i] = db[pos];
                db[pos] = t;
            }
        }
        static void Sort(List<Student> db,int start,int end)
        {
            for( int i= start; i < end; i++)
            {
                int min = db[i].age;
                int pos = i;
                for(int j = i+1; j < end; j++)
                {
                    if(db[j].age < min)
                    {
                        min = db[j].course;
                        pos = j;
                    }

                }
            Student t = db[i];
            db[i] = db[pos];
            db[pos] = t;
            }
        }
        static void Main(string[] args)
        {
            List<Student> students= GenerateList.Gen(10);
            Print(students);
            Console.WriteLine($"{A(students)}");
            foreach (var a in B(students)) Console.WriteLine(a);
            minAge(students);
            Print(students);
            minCourse(students);
            C(students);
            Print(students);
        }
    }
}

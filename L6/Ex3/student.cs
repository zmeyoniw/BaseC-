using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Student
    {
        public Student(string fName, string lName, string uni, string f, string dep, int course, int age, int group, string city)
        {
            this.fName = fName;
            this.lName = lName;
            this.uni = uni;
            this.f = f;
            this.dep = dep;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
        public string fName { get; set; }
        public string lName { get; set; }
        public string uni { get; set; }
        public string f { get; set; }
        public string dep { get; set; }
        public int course{ get; set; }
        public int age { get; set; }
        public int group { get; set; }
        public string city { get; set; }
        public override string ToString()
        {
            return $"{this.fName,20}{this.lName,15}{this.uni,20}{this.f,20}{this.dep,20}{this.course,3}{this.age,3}{this.group,3}{this.city,20}";
        }
    }
}

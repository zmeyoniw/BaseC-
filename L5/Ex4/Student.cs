using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Student
    {
        public Student(string lName, string fName, params int[] Marks)
        {
            if (Marks.Length < 3) throw new Exception("оценок нет");
            this.fName = fName;
            this.lName = lName;
            this.Mark1 = Marks[0];
            this.Mark2 = Marks[1]; 
            this.Mark3 = Marks[2];
        }
        public string fName { get; set; }
        public string lName { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public double avMark
        {
            get
            {
                return Math.Round(((double)(this.Mark1 + this.Mark2 + this.Mark3)) / 3, 2);
            }
        }
        public override string ToString()
        {
            return $"{this.fName,20} {this.lName,15} {this.Mark1,3} {this.Mark2,3} {this.Mark3,3} {this.avMark,3}";
        }
    }
}

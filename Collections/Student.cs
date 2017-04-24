using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Student
    {
        public string Name { get; set; } = "";
        public int AverageMark { get; set; } = 0;

        public Student()
        {
        }
        public Student(string name, int averageMark)
        {
            Name = name;
            AverageMark = averageMark;
        }
        public override string ToString() => string.Format("{0} - {1}", Name, AverageMark);
        public override int GetHashCode() => ToString().GetHashCode();
    }
}

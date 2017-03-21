using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Worker
    {
        private double mark;
        public double Mark
        {
            get
            {
                return mark;
            }
            set
            {
                if(value > 100)
                {
                    throw new ArgumentOutOfRangeException("value", 100, "Mark cannot be grater than 100");
                }
                mark = value;
            }
        }
        public Student(string name,  double mark, uint id): base(name, id)
        {
            Mark = mark;
        }
        public Student(string name, double mark = 0.0): base(name)
        {
            Mark = mark;
        }
        public override string ToString()
        {
            return base.ToString() + " Average mark: " + Mark;
        }
        public override uint payWage()
        {
            uint reward = 0;
            if(Mark >= 90)
            {
                reward = 10;
            }
            return base.payWage()/3 + reward;
        }
    }
}

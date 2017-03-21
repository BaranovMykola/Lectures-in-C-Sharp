using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Worker
    {
        private uint Standing { get; set; }
        public Teacher(string name, uint standing, uint id): base(name, id)
        {
            Standing = standing;
        }
        public Teacher(string name, uint standing = 0): base(name)
        {
            Standing = standing;
        }
        public override string ToString()
        {
            return base.ToString() + " Standing: " + Standing + "Salary: " + payWage();
        }
        public override uint payWage()
        {
            return (uint)(base.payWage() * Standing * 1.02);
        }
    }
}

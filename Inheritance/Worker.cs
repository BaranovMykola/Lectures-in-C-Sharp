using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Worker
    {
        public string Name { get; set; }
        public uint ID { get; set; }
        static uint minimumWage;
        public Worker()
        {
        }
        public Worker(string name, uint id)
        {
            Name = name;
            ID = id;
        }
        public Worker(string name) : this(name, (uint)(new Random()).Next())
        {
        }
        static Worker()  //static constructor
        {
            minimumWage = 300;
        }
        public virtual uint payWage()
        {
            return minimumWage;
        }
        public override string ToString()
        {
            return "Worker: " + Name + " ID: " + ID;
        }
    }
}

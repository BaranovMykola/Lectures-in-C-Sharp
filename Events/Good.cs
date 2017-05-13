using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Good
    {
        //Properies
        public string Name { get; set; } = string.Empty;
        public uint Price { get; set; } = 0;

        //Constructors
        public Good(string name, uint price)
        {
            Name = name;
            Price = price;
        }
        public Good()
        {

        }

        //Methods
        public override string ToString() => $"Name {Name}\tPrice{Price}";

    }
}

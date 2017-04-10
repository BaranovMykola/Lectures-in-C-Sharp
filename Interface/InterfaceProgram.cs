using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{


    class InterfaceProgram
    {
        static void Main(string[] args)
        {
            IShape r = new Rectangle(3, 4);
            Console.WriteLine((r as ICounterVertex)?.Vertex);
            Console.ReadKey();
        }
    }
}

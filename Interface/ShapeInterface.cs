using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IShape
    {
        string Name { get; set; }
        double Square();
        double Perimeter();
        void Draw();
    }

    public interface ICounterVertex
    {
        int Vertex { get; }
    }

    public interface I3DDraw
    {
        void Draw();
    }
}

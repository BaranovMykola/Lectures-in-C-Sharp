using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Circle : IShape
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be bigger than zero");
                }
                radius = value;
            }
        }

        public virtual string Name { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
            Name = "Circle";
        }

        public virtual double Square() => Math.Pow(Radius, 2) * Math.PI;

        public virtual double Perimeter() => 2 * Math.PI * Radius;

        public virtual void Draw()
        {
            Console.WriteLine("Draw {0} (Radius: {1})", Name, Radius);
        }

    }

    public class Cylinder : Circle, I3DDraw
    {
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be bigger than zero");
                }
                height = value;
            }
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = value;
            }
        }

        public Cylinder(int radius, int height) : base(radius)
        {
            Height = height;
            Name = "Cylinder";
        }

        void I3DDraw.Draw() => Console.WriteLine("Draw {0} in 3D", Name);
    }

    public class Rectangle : IShape, ICounterVertex
    {
        public int A { get; set; }
        public int B { get; set; }

        public string Name { get; set; }

        public int Vertex => 4;

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
            Name = "Rectangle";
        }

        public double Square() => A * B;

        public double Perimeter() => (A + B) * 2;

        public void Draw() => Console.WriteLine("Draw {1} with sides {1} & {2}", Name, A, B);
    }
}

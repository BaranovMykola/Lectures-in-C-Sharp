using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {

        static void Main(string[] args)
        {
            double[] arr = { 1.2, 3.5, 6.1, -7.005, 8.4 };
            double min = arr[0] - Math.Round(arr[0]);
            int index = 0;
            for(int i=0;i<arr.Length;++i)
            {
                double part = Math.Round(arr[i]);
                if (min > Math.Abs(arr[i] - part))
                {
                    min = Math.Abs(arr[i] - part);
                    index = i;
                }
            }
            foreach(double i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("Min double part in {0} index ({1})", index, arr[index]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

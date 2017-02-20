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
            //double[] arr = { 1.2, 3.5, 6.1, -7.005, 8.4 };
            //double min = arr[0] - Math.Round(arr[0]);
            //int index = 0;
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    double part = Math.Round(arr[i]);
            //    if (min > Math.Abs(arr[i] - part))
            //    {
            //        min = Math.Abs(arr[i] - part);
            //        index = i;
            //    }
            //}
            //foreach (double i in arr)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine("Min double part in {0} index ({1})", index, arr[index]);
            //string instr = Console.ReadLine();
            //string[] arrStr = instr.Split(' ');
            //double[] arrDouble = new double[arrStr.Length];
            //int minIndex = 0;
            //int maxIndex = 0;
            //for (int i = 0; i < arrStr.Length; ++i)
            //{
            //    arrDouble[i] = double.Parse(arrStr[i]);
            //    if (arrDouble[maxIndex] < arrDouble[i])
            //    {
            //        maxIndex = i;
            //    }
            //    if (arrDouble[minIndex] > arrDouble[i])
            //    {
            //        minIndex = i;
            //    }
            //}
            //double sum = 0;
            //if (minIndex > maxIndex)
            //{
            //    int temp = maxIndex;
            //    maxIndex = minIndex;
            //    minIndex = temp;
            //}
            //Console.WriteLine("Min: {0}, max: {1}", minIndex, maxIndex);
            //for (; minIndex <= maxIndex; ++minIndex)
            //{
            //    sum += arrDouble[minIndex];
            //}
            //Console.WriteLine("Sum is {0}", sum);
            //DateTime user = DateTime.Parse(Console.ReadLine());
            //int year = DateTime.Now.Year - user.Year;
            //--year;
            //if(user.Month < DateTime.Now.Month || user.Month <= DateTime.Now.Month && user.Day < DateTime.Now.Day)
            //{
            //    ++year;
            //}
            //Console.WriteLine("{0} years old", year);
            //DateTime userSata = DateTime.Parse(Console.Read)
            int n = 3;
            int m = 2;
            int[,] matrix = new int[n,m];
            for(int i=0;i<n;++i)
            {
                string[] row = Console.ReadLine().Split(' ');
                Array.Resize<string>(ref row, m);
                for(int j=0;j<m;++j)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
            int _i;
            int _j;
            int maxEl = maxElement(matrix, n, m, out _i, out _j);
            Console.WriteLine("Max {0} in [{1},{2}]", maxEl, _i, _j);
            Console.ReadKey();
        }
        public static int maxElement(int[,] matrix, int n, int m, out int i, out int j)
        {
            i = 0;
            j = 0;
            int max = matrix[0, 0];
            for(int _i = 0;_i<n;++_i)
            {
                for(int _j = 0;_j<m;++_j)
                {
                    if(max < matrix[_i,_j])
                    {
                        i = _i;
                        j = _j;
                        max = matrix[_i, _j];
                    }
                }
            }
            return max;
        }
    }
}

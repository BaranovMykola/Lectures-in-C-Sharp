using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritance
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Worker first = new Student("worker1", 80.0);
            Console.WriteLine("First worker: {0} Salary: {1}", first as Student, first.payWage());
            string[] fileData = File.ReadAllLines("workers.txt");
            Worker[] workers = new Worker[fileData.Length];


            for(int i=0;i<fileData.Length;++i)
            {
                string[] line = fileData[i].Split(' ');
                switch(line[0])
                {
                    case "Student":
                        {
                            workers[i] = new Student(line[1], double.Parse(line[2]), uint.Parse(line[3]));
                        }
                        break;
                    case "Teacher":
                        {
                            workers[i] = new Teacher(line[1], uint.Parse(line[2]), uint.Parse(line[3]));
                        }
                        break;
                    default:break;
                }
            }
            Console.ReadKey();
        }
    }
}

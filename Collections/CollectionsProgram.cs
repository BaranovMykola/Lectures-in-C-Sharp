using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class CollectionsProgram
    {
        public static void foo(StreamReader sr)
        {
            Console.WriteLine(sr.ReadLine());
        }
        static void Main(string[] args)
        {
            var library = Book.ReadFromFile("Library.txt");
            foreach (var item in library)
            {
                Console.WriteLine("{0}\t\t{1}", item.Key, item.Value);
            }

            int maxItems = 300;

            Console.WriteLine("Removing all books, with items > {0}", maxItems);
            library =
                (from item in library
                 where item.Value <= maxItems
                 select item).ToDictionary(s => s.Key, v => v.Value);

            Console.WriteLine("Done!");

            foreach (var item in library)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            StreamReader sr = new StreamReader("../../Faculty.txt");
            var f = Faculty.Read(sr);
            f.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            Dictionary<Faculty, int> excellent = new Dictionary<Faculty, int>();
            foreach (var item in f)
            {
                excellent.Add(item, item.ExcelentPupils());
                Console.WriteLine(item);
                Console.WriteLine("{0} {1}", excellent.Last().Key.Name, excellent.Last().Value);
            }

            
            Console.ReadKey();
        }
    }
}

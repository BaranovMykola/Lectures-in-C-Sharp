using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class CollectionsProgram
    {
        static void Main(string[] args)
        {
            var library = Book.ReadFromFile("Library.txt");
            foreach (var item in library)
            {
                Console.WriteLine("{0}\t\t{1}", item.Key, item.Value);
            }

            int maxItems = 300;

            Console.WriteLine("Removing all books, with items > {0}", maxItems);
            bool wasRemoved = true;
            while (wasRemoved)
            {
                foreach (var item in library)
                {
                    wasRemoved = false;
                    if (item.Value < maxItems)
                    {
                        library.Remove(item.Key);
                        wasRemoved = true;
                        break;
                    }
                }
            }

            Console.WriteLine("Done!");

            foreach (var item in library)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Student s1 = new Student("name1", 5);
            Student s2 = new Student("name2", 5);
            Student[] arrStd = { s1, s2 };
            Group grp = new Group("Group1", arrStd);

            Console.WriteLine(grp);

            Console.ReadKey();
        }
    }
}

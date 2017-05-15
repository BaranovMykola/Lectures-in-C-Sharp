using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LINQ
{
    class LINQProgram
    {
        public static void SerilizeDictionary()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("abc", "123");
            XmlSerializer xml = new XmlSerializer(typeof(Dictionary<string, string>));
            xml.Serialize(File.Open("../../file.txt", FileMode.OpenOrCreate), d);
        }
        public static void LINQToArray()
        {
            int[] arr = { 1,4,3,2,5,6,7,8,9,10 };
            string sentence = "If you already knew the new value, then typically";
            Console.WriteLine($"Words array:\t{sentence}");
            string[] strArray = sentence.Split(' ');
            Console.Write("Arr: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            MoreFive(arr);
            FirstEven(arr);
            EvensAndOdds(arr);
            FirstStringWithLenghtMoreN(strArray);
            AllWordsFollowedBy(strArray);
            Console.WriteLine();
        }
        public static void LINQToClass()
        {
            List<Student> std = new List<Student>()
            {
                new Student { Name = "Name1", LastName = "LName1", City = "City1", Mark = 4},
                new Student { Name = "Name2", LastName = "LName2", City = "City2", Mark = 5},
                new Student { Name = "Name3", LastName = "LName3", City = "City3", Mark = 6}
            };
            List<Teacher> tch = new List<Teacher>()
            {
                new Teacher{ Name = "Name1", LastName = "LName1", City = "City1", Degree = "seqrqe"},
                new Teacher{ Name = "Name2", LastName = "LName2", City = "City2", Degree = "Fdfd"},
                new Teacher{ Name = "Name3", LastName = "LName3", City = "City3", Degree = "fdfd"}
            };

            var res =
                from teacher in tch
                join student in std on teacher.City equals student.City
                select $"{teacher.Name} {student.Name} {student.City}";
            Console.WriteLine(string.Join("\n", res));
        }
        #region LINQToArray
        static void MoreFive(int[] arr)
        {
            var more5 =
                from item in arr
                where item > 5
                select item;
            Console.Write("Only more 5 items:\t");
            foreach (var item in more5)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void FirstEven(int[] arr)
        {
            var res =
                (from item in arr
                 where item % 2 == 0
                 select item).First();
            Console.WriteLine($"First even: {res}");
        }
        static void EvensAndOdds(int[] arr)
        {
            var res =
                from item in arr
                orderby item % 2 == 0, item
                select item;
            //var res = arr.Where(item => item % 2 == 0).OrderByDescending(item => item);
            Console.Write("All evens and odds (sorted):\t");
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void FirstStringWithLenghtMoreN(string[] str)
        {
            var res =
                (from item in str
                 where item.Length > 5
                 select item).First();
            Console.WriteLine($"First string with lenght > 5: \t{res}");
        }
        static void AllWordsFollowedBy(string[] str)
        {
            var res =
                (from item in str
                where char.IsLetter(item.Last())
                select item).TakeWhile(s => s.Length < 5);
            Console.WriteLine($"All elements before word with lenght > 5 with last character isn't digit:\t{string.Join(" ", res)}");
        }
        #endregion
        static void Main(string[] args)
        {
            LINQToArray();
            LINQToClass();
            Console.ReadKey();
        }
    }
}

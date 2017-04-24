using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Book
    {
        public string Name { get; set; } = "";
        public string Author { get; set; } = "";
        public int Year { get; set; } = 0;
        public Book()
        {
        }

        public Book(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }

        public override string ToString() => string.Format("Name: {0}\tAuthor: {1}\tYear: {2}", Name, Author, Year);

        public static Dictionary<Book, int> ReadFromFile(string fileName)
        {
            try
            {
                string[] allLines = File.ReadAllLines(fileName);
                Dictionary<Book, int> library = new Dictionary<Book, int>();
                foreach (var item in allLines)
                {
                    try
                    {
                        string[] certainLine = item.Split(' ');
                        Book newBook = new Book(certainLine[0], certainLine[1], int.Parse(certainLine[2]));
                        library.Add(newBook, int.Parse(certainLine[3]));
                        //library[newBook] = int.Parse(certainLine[3]);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("Some error occured:");
                        Console.WriteLine(error.Message);
                    }
                }
                return library;
            }
            catch(Exception error)
            {
                Console.WriteLine("Error while reading from file: {0}", error.Message);
            }
            return new Dictionary<Book, int>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Book)) return false;
            Book compare = obj as Book;
            return (Name == compare.Name && Author == compare.Author && Year == compare.Year);
        }

        public override int GetHashCode() => ToString().GetHashCode();

    }
}

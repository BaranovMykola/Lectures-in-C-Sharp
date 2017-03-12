using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes
{
    class Student : IComparer<Student>
    {
        double mark;

        public string Surname { get; set; }//automatic property
        public DateTime Born { get; set; }
        public Gender GenderType { get; set; }

        public enum Gender { Male, Female }
        /*single property*/
        //public string Surname
        //{
        //    get
        //    {
        //        return surname;
        //    }
        //    set
        //    {
        //        surname = value;
        //    }
        //}
        public double Mark
        {
            get
            {
                return mark;
            }
            set
            {
                //can containt extra conditions;
                if (value < 0 || value > 100)
                {
                    throw new Exception("Incorrect value");
                }
                mark = value;
            }
        }
        public Student(string _sruname, DateTime _born, double _mark, Gender _genderType)
        {
            Surname = _sruname;
            Born = _born;
            Mark = _mark;
            GenderType = _genderType;
        }
        public Student(string _surname, DateTime _born) : this(_surname, _born, 0, Student.Gender.Male)  //chain of constructor
        {
        }
        public Student() { Surname = "name3"; }
        public override string ToString()
        {
            //return Surname+" "+Mark.ToString()+" "+Born.Year.ToString()+" "+GenderType.ToString();
            return string.Format("{0} {1} {2} {3}", Surname, Mark, Born.Year, GenderType);
        }
        int IComparer<Student>.Compare(Student x, Student y)
        {
            return string.Compare(x.Surname, y.Surname);
        }
    }
    class Classes
    {
        static void Main(string[] args)
        {
            var st = new Student("name", new DateTime(1998, 2, 25));
            Console.WriteLine(st);
            st.Mark = 100;
            Console.WriteLine(st);
            Student st2 = new Student(_born: new DateTime(1999, 2, 3), _surname: "name");
            Console.WriteLine(st2);
            Student st3 = new Student() { Born = new DateTime(2000, 1, 1), GenderType = Student.Gender.Female, Mark = 34, Surname = "name"};
            Console.WriteLine(st3);
            string[] arr = File.ReadAllLines("StudentLst.txt");
            Student[] lst = new Student[arr.Length];
            int index = 0;
            foreach(var i in arr)
            {
                string[] spl = i.Split(' ');
                Student.Gender male = Student.Gender.Female;
                if(spl[3] == Student.Gender.Male.ToString())
                {
                    male = Student.Gender.Male;
                }
                lst[index++] = new Student(spl[0], DateTime.Parse(spl[1]), double.Parse(spl[2]), male);
            }
            Console.WriteLine();
            IComparer<Student> ic = (IComparer<Student>)new Student("", new DateTime());
            Array.Sort(lst, ic);
            foreach(var i in lst)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

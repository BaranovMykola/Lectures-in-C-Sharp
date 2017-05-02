using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Group
    {
        public string Name { get; set; } = "";
        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        public Group()
        {
            students = new List<Student>();
        }
        public Group(string name, IEnumerable<Student> students)
        {
            Name = name;
            this.students = new List<Student>(students);
        }
        public override string ToString()
        {
            string output = string.Format("Group: {0}\n", Name);
            output += string.Format("{0,-5}{1,-20}{2}\n\n", null, "[Name]", "[Mark]");
            var studentFormat =
                from item in Students
                select string.Format("{0,-5}{1,-20}", null, item);
            output += string.Join("\n", studentFormat);
            return output;
        }
        public override int GetHashCode() => ToString().GetHashCode();
        public int ExcellentPupils()
        {
            int count = 0;
            foreach (var item in Students)
            {
                if(item.IsExcellent())
                {
                    ++count;
                }
            }
            return count;
        }
    }
}

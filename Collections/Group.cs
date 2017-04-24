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
            protected set { students = value; }
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
            string output = string.Format("Group: {0}\tStudents:\n", Name)
            output += string.Join("\n", Students);
            return output;
        }
        public override int GetHashCode() => ToString().GetHashCode();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Faculty
    {
        public string Name { get; set; } = "";
        private List<Group> students;

        public List<Group> Groups
        {
            get { return students; }
            protected set { students = value; }
        }
        public Faculty()
        {
            students = new List<Group>();
        }
        public Faculty(string name, IEnumerable<Group> groups)
        {
            Name = name;
            this.students = new List<Group>(groups);
        }
        public override string ToString()
        {
            string output = string.Format("Faculty: {0}\n", Name);
            var groupFormat =
                from item in Groups
                select string.Format("{0,-5}{1}", null, item);
            output += string.Join("\n\n", groupFormat);
            return output;
        }
        public override int GetHashCode() => ToString().GetHashCode();
        public static List<Faculty> Read(StreamReader sr)
        {
            List<Faculty> f = new List<Faculty>();
            string line;
            Faculty newF = new Faculty();
            while((line = sr.ReadLine()) != null)
            {
                if(line.Trim() == "[")
                {
                    newF.Name = sr.ReadLine();
                    continue;
                }
                if (line.Trim() == "{")
                {
                    newF.Groups.Add( ReadGroup(sr));
                    continue;
                }
                if(line.Trim() == "]")
                {
                    f.Add(newF);
                    newF = new Faculty();
                }
            }
            return f;
        }
        public static Group ReadGroup(StreamReader sr)
        {
            Group g = new Group();
            g.Name = sr.ReadLine();
            sr.ReadLine();
            g.Students = ReadStudents(sr);
            return g;
        }
        public static List<Student> ReadStudents(StreamReader sr)
        {
            string line;
            List<Student> std = new List<Student>();
            while((line = sr.ReadLine()).Trim() != ")")
            {
                var raw = line.Trim().Split(' ');
                std.Add(new Student(raw[0], int.Parse(raw[1])));
            }
            return std;
        }
        public int ExcelentPupils()
        {
            int count = 0;
            foreach (var item in Groups)
            {
                count += item.ExcellentPupils();
            }
            return count;
        }
    }
}

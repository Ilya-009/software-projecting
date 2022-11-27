using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msvload.Entities
{
    public enum Subject
    {
        History,
        Social_Studies,
        Foreign_Language,
        Literature
    }


    public class Teacher
    {
        public int ID { get; set; }

        public Subject Subject { get; set; }

        public List<Student> Students { get; set; }

        public Teacher() {}

        public Teacher(Subject subject)
        {
            Subject = subject;
        }

        public static string[] GetSubjects()
        {
            return Enum.GetNames(typeof(Subject)).Cast<string>().ToArray();
        }
    }
}

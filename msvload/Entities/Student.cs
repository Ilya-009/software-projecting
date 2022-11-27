using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msvload.Entities
{
    public class Student
    {
        public int ID { get; set; }

        public List<Work> UserTasks { get; set; }
    }
}

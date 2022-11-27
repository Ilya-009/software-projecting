using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msvload.Entities
{
    public class Work
    {
        public int ID { get; set; }

        [Required]
        public string TaskName { get; set; }

        [Required]
        public string Question { get; set; }

        //can be null
        public string CorrectAnswer { get; set; }

        public string StudentAnswer { get; set; }

        //count of point that user gets for this task
        public int Mark { get; set; }
    }
}


using System;

namespace msvload.Entities
{
    public class Code
    {
        public int ID { get; set; }
        public string code { get; set; }
        public DateTime ExpiredDate { get; set; }
        public bool IsActivated { get; set; }
    }
}

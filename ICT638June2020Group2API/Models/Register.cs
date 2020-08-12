using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICT638June2020Group2API.Models
{
    public class Register
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string phonenumber { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public string uniquename { get; set; }
        public string password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Employee
    {
        public int id { get; set; }
        public string fio { get; set; }
        public string post { get; set; }
        public int subdivision { get; set; }
        public string email { get; set; }
        public string phone_num { get; set; }
        public DateOnly hire_date { get; set; }
        public DateOnly fired_date { get; set; }
        public bool state { get; set; }
    }
}

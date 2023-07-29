using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Subdivision
    {
        public int id { get; set; }
        public string name { get; set; }
        public int head_subdivision { get; set; }
        public int supervisor { get; set; }
        public bool state { get; set; }
    }
}
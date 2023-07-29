using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace App
{
    [PrimaryKey(nameof(emp_id), nameof(subd_id))]
    public class Subdivision_employees
    {
        public int emp_id { get; set; }
        public int subd_id { get; set; }
    }
}

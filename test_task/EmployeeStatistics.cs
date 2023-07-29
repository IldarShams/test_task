using App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_task
{
    public partial class EmployeeStatistics : Form
    {
        PostgreSQLContext db;
        public EmployeeStatistics(PostgreSQLContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hired = (from emps in db.Employee
                         where emps.hire_date >= DateOnly.FromDateTime(dateTimePicker1.Value)
                         && emps.hire_date <= DateOnly.FromDateTime(dateTimePicker2.Value)
                         select emps).Count();
            int fired = (from emps in db.Employee
                         where emps.fired_date >= DateOnly.FromDateTime(dateTimePicker1.Value)
                         && emps.fired_date <= DateOnly.FromDateTime(dateTimePicker2.Value)
                         select emps).Count();
            MessageBox.Show("Нанято: " + hired.ToString() + "\n" +
                            "Уволено: " + fired.ToString());
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

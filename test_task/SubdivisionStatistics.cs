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
    public partial class SubdivisionStatistics : Form
    {
        PostgreSQLContext db;
        DataGridViewSelectedRowCollection f;
        public SubdivisionStatistics(PostgreSQLContext db, DataGridViewSelectedRowCollection f)
        {
            this.db = db;
            this.f = f;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in f) {

                int id = int.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();

                int hired = (from emps in db.Employee
                             where emps.subdivision == id &&
                             emps.hire_date >= DateOnly.FromDateTime(dateTimePicker1.Value)
                         && emps.hire_date <= DateOnly.FromDateTime(dateTimePicker2.Value)
                             select emps).Count();
                int fired = (from emps in db.Employee
                             where emps.subdivision == id &&
                             emps.fired_date >= DateOnly.FromDateTime(dateTimePicker1.Value)
                         && emps.fired_date <= DateOnly.FromDateTime(dateTimePicker2.Value)
                             select emps).Count();
                MessageBox.Show("Подразделение " + name + "\n" +
                                "Нанято:" + hired + "\n" +
                                "Уволено:" + fired);
            }
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

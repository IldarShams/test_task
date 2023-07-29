using App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_task
{
    public partial class AddEmployeeForm : Form
    {
        PostgreSQLContext db;
        Form1 f;
        public AddEmployeeForm(PostgreSQLContext db, Form1 f)
        {
            this.db = db;
            this.f = f;
            InitializeComponent();
            var subs = from sub in db.Subdivisions
                       select sub.name;
            foreach (var sub in subs)
            {
                this.comboBox1.Items.Add(sub);
            }
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Employee new_e = new Employee
            {
                id = int.Parse(this.textBox1.Text),
                fio = this.textBox2.Text,
                post = this.textBox3.Text,
                email = this.textBox5.Text,
                subdivision = (from sub in this.db.Subdivisions
                               where sub.name == this.comboBox1.Text
                               select sub.id).First(),
                hire_date = DateOnly.Parse(this.dateTimePicker1.Text, new CultureInfo("de-DE")),
                phone_num = this.textBox6.Text,
                state = true
            };
            db.Employee.Add(new_e);
            db.SaveChanges();
            f.Update_Employees();
            this.Close();
        }

    }
}

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
    public partial class FindEmployee : Form
    {

        PostgreSQLContext db;
        public FindEmployee(PostgreSQLContext db)
        {
            this.db = db;
            InitializeComponent();
        }



        private void AddBut_Click(object sender, EventArgs e)
        {
            int emp_id = 0;
            string emp_name = textBox2.Text;
            Employee emp;
            IQueryable<Employee> empss;
            if ((!int.TryParse(textBox1.Text, out emp_id)) && emp_name == "")
            {
                MessageBox.Show("Введите корректный табельный номер или ФИО сотрудника!");
                return;
            }
            else if (emp_id != 0 && emp_name == "")
            {
                empss = (from emps in db.Employee
                         where emps.id == emp_id
                         select emps);
            }
            else if (emp_id == 0 && emp_name != "")
            {
                empss = (from emps in db.Employee
                         where emps.fio.ToLower() == emp_name.ToLower()
                         select emps);
            }
            else
            {
                empss = (from emps in db.Employee
                         where emps.fio.ToLower() == emp_name.ToLower()
                             && emps.id == emp_id
                         select emps);
            }
            if (empss.Count() > 0)
            {
                emp = empss.First();
                textBox1.Text = emp.id.ToString();
                textBox2.Text = emp.fio;
                textBox3.Text = emp.post;
                textBox4.Text = (from subs in db.Subdivisions
                                 where subs.id == emp.subdivision
                                 select subs).First().name;
                textBox5.Text = emp.email;
                textBox6.Text = emp.phone_num;
                textBox7.Text = emp.hire_date.ToString();
                textBox8.Text = (emp.fired_date != DateOnly.MinValue ? emp.fired_date.ToString() : "-");
            }
            else
            {
                MessageBox.Show("По данным параметрам ничего не найдено");
            }

        }
    }
}

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
    public partial class FindSubdivision : Form
    {
        PostgreSQLContext db;
        public FindSubdivision(PostgreSQLContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(textBox1.Text, out id)) {
                MessageBox.Show("Введите корректный номер подразделения");
                return;
            } else
            {
                if ((from subs in db.Subdivisions
                     where subs.id == id
                     select subs).Count() == 0)
                {
                    MessageBox.Show("По введенным данным ничего не найдено");
                    return;
                }
                Subdivision sub = (from subs in db.Subdivisions
                                   where subs.id == id
                                   select subs).First();
                textBox2.Text = sub.name;
                string h = (from subs in db.Subdivisions
                            where subs.id == sub.id
                            select subs.name).Count() > 0 ? (from subs in db.Subdivisions
                                                             where subs.id == sub.id
                                                             select subs.name).First() : "";
                textBox3.Text = h;
                string super = (from emps in db.Employee
                                where sub.id == emps.id
                                select emps.fio).Count() > 0 ? (from emps in db.Employee
                                                                where sub.id == emps.id
                                                                select emps.fio).First() : "";
                textBox4.Text = super;
            }
        }
    }
}

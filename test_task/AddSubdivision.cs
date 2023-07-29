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
    public partial class AddSubdivision : Form
    {
        PostgreSQLContext db;
        Form1 f;
        public AddSubdivision(PostgreSQLContext db, Form1 f)
        {
            this.db = db;
            this.f = f;
            InitializeComponent();
            foreach (Subdivision s in db.Subdivisions)
            {
                comboBox1.Items.Add(s.name);
            }
            foreach (Employee e in db.Employee)
            {
                comboBox2.Items.Add(e.fio);
            }
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Subdivision new_sub = new Subdivision
            {
                id = int.Parse(textBox1.Text),
                name = textBox2.Text,
                head_subdivision = (from subs in db.Subdivisions
                                    where subs.name == comboBox1.Text
                                    select subs.id).First(),
                supervisor = (from emps in db.Employee
                              where emps.fio == comboBox2.Text
                              select emps.id).First(),
                state = true
            };
            db.Subdivisions.Add(new_sub);
            db.SaveChanges();
            f.Update_Subdivisions();
            this.Close();
        }
    }
}

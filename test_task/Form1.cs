using App;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace test_task
{
    public partial class Form1 : Form
    {
        PostgreSQLContext db;
        public Form1(PostgreSQLContext db)
        {
            InitializeComponent();
            this.db = db;
            Update_Employees();
            Update_Subdivisions();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm aef = new AddEmployeeForm(db, this);
            aef.Show();
        }

        public void Update_Employees()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Employee e in db.Employee)
            {
                this.dataGridView1.Rows.Add(e.id, e.fio, e.post, e.subdivision,
                    e.email, e.phone_num, e.hire_date, e.fired_date, e.state);
            }
        }

        public void Update_Subdivisions()
        {
            this.dataGridView2.Rows.Clear();
            foreach (var s in (from subs in db.Subdivisions
                               join emp in db.Employee on subs.supervisor equals emp.id
                               join subs3 in db.Subdivisions on subs.head_subdivision equals subs3.id
                               select new
                               {
                                   id = subs.id,
                                   name = subs.name,
                                   head = subs3.name,
                                   sup = emp.fio,
                                   state = subs.state
                               }))
            {
                this.dataGridView2.Rows.Add(s.id, s.name, s.head, s.sup, s.state);
            }
            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {
                IQueryable<Employee> emps = (from e in db.Employee
                                             where e.subdivision == int.Parse(row.Cells[0].Value.ToString())
                                             select e);
                string emps_str = "";
                foreach (Employee emp in emps)
                {
                    emps_str += emp.fio + "; ";
                }
                row.Cells[5].Value = emps_str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите СТРОКУ сотрудника, которого хотите удалить");
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Employee e_to_del = (from emp in db.Employee
                                     where emp.id == int.Parse(row.Cells[0].Value.ToString())
                                     select emp).First();
                db.Employee.Remove(e_to_del);

            }
            db.SaveChanges();

            Update_Employees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите СТРОКУ сотрудника, которого хотите уволить");
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Employee e_to_del = (from emp in db.Employee
                                     where emp.id == int.Parse(row.Cells[0].Value.ToString())
                                     select emp).First();
                e_to_del.fired_date = DateOnly.FromDateTime(DateTime.Now);
                db.Employee.Update(e_to_del);

            }
            db.SaveChanges();

            Update_Employees();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindEmployee ff = new FindEmployee(db);
            ff.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddSubdivision add_s = new AddSubdivision(db, this);
            add_s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Update_Employees();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Update_Subdivisions();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection subs_to_del = dataGridView2.SelectedRows;
            if (subs_to_del.Count == 0)
            {
                MessageBox.Show("Выделети СТРОКУ подразделения для удаления");
            }
            else
            {
                foreach (DataGridViewRow row in subs_to_del)
                {
                    Subdivision sub = (from subs in db.Subdivisions
                                       where subs.id == int.Parse(row.Cells[0].Value.ToString())
                                       select subs).First();
                    IQueryable<Employee> emps_of_sub = (from emps in db.Employee
                                                        where emps.subdivision == sub.id
                                                        select emps);
                    IQueryable<Subdivision> head_of_subs = (from hd in db.Subdivisions
                                                            where hd.head_subdivision == sub.id
                                                            select hd);
                    foreach (Subdivision s in head_of_subs)
                    {
                        s.head_subdivision = 1;
                        db.Update(s);
                    }

                    foreach (Employee emp in emps_of_sub)
                    {
                        emp.subdivision = 1;
                        db.Update(emp);
                    }

                    db.Remove(sub);
                    db.SaveChanges();

                }
            }
            Update_Subdivisions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindSubdivision fs = new FindSubdivision(db);
            fs.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection change_state = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in change_state)
            {
                Employee r = (from e1 in db.Employee
                              where e1.id == int.Parse(row.Cells[0].Value.ToString())
                              select e1).First();
                r.state = !r.state;
                db.Employee.Update(r);
                db.SaveChanges();
            }
            Update_Employees();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection change_state = dataGridView2.SelectedRows;
            foreach (DataGridViewRow row in change_state)
            {
                Subdivision r = (from subs in db.Subdivisions
                                 where subs.id == int.Parse(row.Cells[0].Value.ToString())
                                 select subs).First();
                r.state = !r.state;
                db.Subdivisions.Update(r);
                db.SaveChanges();
            }
            Update_Subdivisions();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Workbook w = app.Workbooks.Open(textBox1.Text);
                Worksheet ws_subs = w.Worksheets[2] as Excel.Worksheet;
                Worksheet ws_emps = w.Worksheets[1] as Excel.Worksheet;
                Excel.Range ws_subs_range = ws_subs.UsedRange;
                Excel.Range ws_emps_range = ws_emps.UsedRange;

                for (int i = 2; i <= ws_subs_range.Rows.Count; i++)
                {
                    int id = int.Parse(ws_subs.Cells[i, "A"].Value2.ToString());
                    string name = ws_subs.Cells[i, "B"].Value2;

                    int head_subdivision = -1;
                    if (ws_subs.Cells[i, "C"].Value2 == null)
                    {
                        head_subdivision = 0;
                    }
                    else
                    {
                        for (int j = 2; j <= ws_subs_range.Rows.Count; j++)
                        {
                            if (ws_subs.Cells[j, "B"].Value2.ToString() == ws_subs.Cells[i, "C"].Value2.ToString())
                            {
                                head_subdivision = int.Parse(ws_subs.Cells[j, "A"].Value2.ToString());
                                break;
                            }
                        }
                        if (head_subdivision == -1)
                        {
                            head_subdivision = 0;
                        }
                    }

                    int supervisor = 0;
                    bool state = true;

                    Subdivision new_sub = new Subdivision
                    {
                        id = id,
                        name = name,
                        head_subdivision = head_subdivision,
                        supervisor = supervisor,
                        state = state
                    };

                    IQueryable<int> ids = (from subs in db.Subdivisions
                                           where subs.id == new_sub.id
                                           select subs.id);
                    if (ids.Count() > 0)
                    {
                        MessageBox.Show("Найдены объекты с повторяющимися id:" + new_sub.id.ToString()
                            + "\nОни будут пропущены");
                        continue;
                    }

                    try
                    {
                        db.Subdivisions.Add(new_sub);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }



                for (int i = 2; i <= ws_emps_range.Rows.Count; i++)
                {
                    int id = int.Parse(ws_emps.Cells[i, "C"].Value2.ToString());
                    string fio = ws_emps.Cells[i, "B"].Value2;
                    string post = ws_emps.Cells[i, "D"].Value2;

                    int subdivision = -1;
                    string sub_name = ws_emps.Cells[i, "E"].Value2.ToString();
                    IQueryable<int> s = (from subs in db.Subdivisions
                                         where subs.name == sub_name
                                         select subs.id);
                    if (s.Count() > 0)
                    {
                        subdivision = s.First();
                    }
                    else
                    { subdivision = 0; }


                    string email = ws_emps.Cells[i, "F"].Value2;
                    string phone_num = ws_emps.Cells[i, "G"].Value2;
                    DateOnly hire_date = DateOnly.FromDateTime(DateTime.Parse(ws_emps.Cells[i, "H"].Value.ToString()));
                    DateOnly fired_date;
                    if (ws_emps.Cells[i, "I"].Value2 == null)
                    {
                        fired_date = DateOnly.MinValue;
                    }
                    else
                    {
                        fired_date = DateOnly.FromDateTime(DateTime.Parse(ws_emps.Cells[i, "I"].Value.ToString()));
                    }
                    bool state = true;


                    Employee new_emp = new Employee
                    {
                        id = id,
                        fio = fio,
                        email = email,
                        phone_num = phone_num,
                        fired_date = fired_date,
                        hire_date = hire_date,
                        post = post,
                        state = state,
                        subdivision = subdivision
                    };
                    IQueryable<int> ids = (from subs in db.Employee
                                           where subs.id == new_emp.id
                                           select subs.id);
                    if (ids.Count() > 0)
                    {
                        MessageBox.Show("Найдены объекты с повторяющимися id:" + new_emp.id.ToString()
                            + "\nОни будут пропущены");
                        continue;
                    }
                    try
                    {
                        db.Employee.Add(new_emp);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                db.SaveChanges();



                Update_Employees();
                Update_Subdivisions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmployeeStatistics es = new EmployeeStatistics(db);
            es.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                SubdivisionStatistics ss = new SubdivisionStatistics(db, dataGridView2.SelectedRows);
                ss.Show();
            } else
            {
                MessageBox.Show("Выделите СТРОКИ подразделений, по которым нужна статистика");
            }
        }
    }
}
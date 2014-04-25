using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void student_Info_Click(object sender, EventArgs e)
        {

        }

        private void prof_Info_Click(object sender, EventArgs e)
        {

        }

        private void eval_Prof_Info_Click(object sender, EventArgs e)
        {

        }

        private void events_Click(object sender, EventArgs e)
        {

        }

        private void reports_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void deleteTask(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        foreach (Task t in dbConnection.tasks)
                            if (t.subject.Equals(c.Name)){
                                dbConnection.tasks.Remove(t);
                                break;
                            }
                }
            }
            MessageBox.Show("تغییرات مورد نظر شما اعمال شد");
            splitContainer1.Panel1.Controls.Clear();

        }

        private void new_Task_Click(object sender, EventArgs e)
        {
            Compose compose = new Compose();
            compose.Show();
        }

        private void showTask(object sender, EventArgs e)
        {
           // MessageBox.Show(((Button)sender).Name);
            Task temp= new Task();
            foreach (Task t in dbConnection.tasks)
            {
                if (t.subject.Equals(((Button)sender).Name))
                    temp = t;
            }
            readOnlyTask r = new readOnlyTask(temp);
            r.Show();
        }

        private void savedTasks_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();
            int x = 25;
            foreach (Task t in dbConnection.tasks)
            {
                CheckBox c = new CheckBox();
                c.Name = t.subject;
                c.Text = t.subject;
                c.Location = new Point(10, x);
                Button b = new Button();
                b.Click += new EventHandler(showTask);
                b.Name = t.subject;
                b.Text = "مشاهده‌ی نامه";
                b.Width = 100;
                b.Location = new Point(120, x);
                x += 25;
                splitContainer1.Panel1.Controls.Add(c);
                splitContainer1.Panel1.Controls.Add(b);
            }

            Button b2 = new Button();
            b2.Click += new EventHandler(deleteTask);
            b2.Name = "delete";
            b2.Location = new Point(40, 350);
            b2.Text = "حذف موارد انتخاب شده";
            b2.Width = 150;
            splitContainer1.Panel1.Controls.Add(b2);
        }

        private void groups_click(object sender, EventArgs e)
        {
            Groups group = new Groups();
            group.Show();
        }
    }
}

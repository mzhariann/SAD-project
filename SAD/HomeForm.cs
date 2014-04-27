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
    public partial class HomeForm : Form
    {

        public HomeForm()
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

        private void new_Task_Click(object sender, EventArgs e)
        {
            ComposeForm compose = new ComposeForm(true);
            compose.Show();
        }

        private void savedTasks_Click(object sender, EventArgs e)
        {
            

            dataGrid1.DataSource = Task.getSubjectTable();
            
            Button showTask = new Button();
            showTask.Text = "مشاهده";
            showTask.Location = new Point(89,387);
            showTask.Width = 75;
            showTask.Height = 23;
            showTask.Click += new EventHandler(show);
            splitContainer1.Panel1.Controls.Add(showTask);
        }

        private void show(object sender, EventArgs e)
        {
            if (dataGrid1.SelectedRows.Count == 0)
                MessageBox.Show("یک نامه را انتخاب کنید");
            else
            {
                int selectedId;
                selectedId = (int) dataGrid1.SelectedRows[0].Cells["Id"].Value;
                readOnlyTask rot = new readOnlyTask(Task.getById(selectedId));
                rot.Show();
            }
        }

        private void groups_click(object sender, EventArgs e)
        {
            GroupsForm group = new GroupsForm();
            group.Show();
        }
    }
}

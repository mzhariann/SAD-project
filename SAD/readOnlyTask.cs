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
    public partial class readOnlyTask : Form
    {
        Task task;
        public readOnlyTask(Task t)
        {
            task = t;
            InitializeComponent();
            Text = t.subject;
            subjectTextBox.Text = t.subject;
            editorTextBox.Text = t.content;
            creationDate.Text = t.creationDate.Date.ToString();
            if (t.confirmation.Equals("True"))
                confirmation.Text = "نیاز به تایید دارد";
            else
                confirmation.Text = "نیاز به تایید ندارد";
            if (t.periodicSend)
            {
                string str = null;
                prdSend.Text = "ارسال دوره‌ای دارد";
                switch (t.prdSend.period.Value)
                {
                    case 0:
                        str = "هفته";
                        break;
                    case 1:
                        str = "ماه";
                        break;
                    case 2:
                        str = "سال";
                        break;
                }
                startDate.Text = t.prdSend.startDate.ToString();
                endDate.Text = t.prdSend.endDate.ToString();
                num.Text = t.prdSend.period.Key.ToString();
                prd.Text = str;
            }
            else
            {
                prdSend.Text = "ارسال دوره‌ای ندارد";
                from.Visible = false;
                startDate.Text="تاریخ ارسال";
                endDate.Text = t.sendingDate.ToString();
                num.Visible = false;
                prd.Visible = false;
                to.Visible = false;
                every.Visible = false;
            }
        }

        private void delCanBtn_Click(object sender, EventArgs e)
        {
                MessageBox.Show("آیا مطمئن هستید؟");
                task.deleteFromDB();               
                MessageBox.Show("تغییرات مورد نظر شما اعمال شد");
                this.Close();
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            Compose cmp = new Compose(false);
            cmp.Controls.OfType<TextBox>().First(x => x.Name == "subjectTextBox").Text = task.subject;
            cmp.Controls.OfType<RichTextBox>().First(x => x.Name == "editorTextBox").Text = task.content;
            cmp.Controls.OfType<DateTimePicker>().First(x => x.Name == "creationDate").Value = task.creationDate;
            cmp.Controls.OfType<CheckBox>().First(x => x.Name == "confirmation").Checked = task.confirmation;
            if (task.periodicSend)
            {
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel1").Controls.OfType<DateTimePicker>().First(x => x.Name == "startDate").Value = task.prdSend.startDate;
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel1").Controls.OfType<DateTimePicker>().First(x => x.Name == "endDate").Value = task.prdSend.endDate;
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel1").Controls.OfType<CheckBox>().First(x => x.Name == "hasPrdSend").Checked = task.periodicSend;
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel1").Controls.OfType<ComboBox>().First(x => x.Name == "numCmbBox").SelectedItem = task.prdSend.period.Key.ToString();
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel1").Controls.OfType<ComboBox>().First(x => x.Name == "prdCmbBox").SelectedIndex = task.prdSend.period.Value;
            }
            else
            {
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel2").Controls.OfType<CheckBox>().First(x => x.Name == "dntHavePrdSend").Checked = !task.periodicSend;
                cmp.Controls.OfType<Panel>().First(x => x.Name == "sendingPanel2").Controls.OfType<DateTimePicker>().First(x => x.Name == "sendDate").Value = task.sendingDate;
            }
            cmp.Show();
            this.Close();
        }
    }
}

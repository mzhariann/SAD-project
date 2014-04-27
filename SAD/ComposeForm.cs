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
    public partial class ComposeForm : Form
    {
        public ComposeForm()
        {
            InitializeComponent();
        }

        private Boolean checkErrors()
        {
            if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                errorProvider1.SetError(subjectTextBox, "موضوع نمی‌تواند خالی باشد");
                return true;
            }
            if (string.IsNullOrWhiteSpace(editorTextBox.Text))
            {
                errorProvider1.SetError(editorTextBox, "متن نمی‌تواند خالی باشد");
                return true;
            }
            CheckBox c1 = sendingPanel1.Controls.OfType<CheckBox>().First(x => x.Name == "hasPrdSend");
            CheckBox c2 = sendingPanel2.Controls.OfType<CheckBox>().First(x => x.Name == "dntHavePrdSend");
            if ((c1.Checked && c2.Checked) || (!c1.Checked && !c2.Checked))
            {
                errorProvider1.SetError(sendingPanel1, "یکی از دو گزینه‌ی ارسال یا عدم ارسال دوره‌ای باید انتخاب شود");
                errorProvider1.SetError(sendingPanel2, "یکی از دو گزینه‌ی ارسال یا عدم ارسال دوره‌ای باید انتخاب شود");

                return true;
            
            }
            ComboBox cb1 = sendingPanel1.Controls.OfType<ComboBox>().First(x => x.Name == "numCmbBox");
            ComboBox cb2 = sendingPanel1.Controls.OfType<ComboBox>().First(x => x.Name == "prdCmbBox");
            if ( c1.Checked && (cb1.SelectedIndex < 0 || cb2.SelectedIndex < 0))
            {
                errorProvider1.SetError(sendingPanel1, "بازه‌ی ارسال باید مشخص باشد");
                return true;
            }
            return false;
        }

        Task t = new Task();
        private void save_Button_Click(object sender, EventArgs e)
        {

            if (!checkErrors())
            {
                t.creationDate = creationDate.Value;
                t.subject = subjectTextBox.Text;
                t.content = editorTextBox.Text;
                t.receivers = new List<string>();
                foreach (object itemChecked in receiverCheckList.CheckedItems)
                    t.receivers.Add(itemChecked.ToString());
                CheckBox c1 = sendingPanel1.Controls.OfType<CheckBox>().First(x => x.Name == "hasPrdSend");
                if (c1.Checked)
                {
                    t.periodicSend = true;
                    t.prdSend = new PeriodicSend();
                    t.prdSend.startDate = sendingPanel1.Controls.OfType<DateTimePicker>().First(x => x.Name == "startDate").Value;
                    t.prdSend.endDate = sendingPanel1.Controls.OfType<DateTimePicker>().First(x => x.Name == "endDate").Value;
                    t.prdSend.period = new KeyValuePair<int, int>(Convert.ToInt32((sendingPanel1.Controls.OfType<ComboBox>().First(x => x.Name == "numCmbBox").SelectedItem.ToString()), 10), sendingPanel1.Controls.OfType<ComboBox>().First(x => x.Name == "prdCmbBox").SelectedIndex);
                }
                CheckBox c2 = sendingPanel2.Controls.OfType<CheckBox>().First(x => x.Name == "dntHavePrdSend");
                if (c2.Checked)
                {
                    t.sendingDate = sendingPanel2.Controls.OfType<DateTimePicker>().First(x => x.Name == "sendDate").Value;
                }
                t.confirmation = confirmation.Checked;
                MessageBox.Show("نامه‌ی شما با موفقیت ثبت شد");
                dbConnection.tasks.Add(t);
                this.Close();
            }
        }

       
    }
}

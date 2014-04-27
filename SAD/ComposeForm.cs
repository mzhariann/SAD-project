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

        private void editor_Text_Changed(object sender, EventArgs e)
        {

        }
        Task t = new Task();
        private void save_Button_Click(object sender, EventArgs e)
        {
           
            t.date = dateTextBox.Text;
            t.subject = subjectTextBox.Text;
            t.content = editorTextBox.Text;
            t.receivers = new List<string>();
            foreach (object itemChecked in receiverCheckList.CheckedItems)
                t.receivers.Add(itemChecked.ToString());
            t.sendingOption = sendingOption.Checked.ToString();
            t.confirmation = confirmation.Checked.ToString();
            MessageBox.Show("نامه‌ی شما با موفقیت ثبت شد");
            dbConnection.tasks.Add(t);
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        public readOnlyTask(Task t)
        {
            InitializeComponent();
            subject.Text = t.subject;
            date.Text = t.date;
            content.Text = t.content;
            foreach (String s in t.receivers)
                receivers.Items.Add(new ListViewItem(s+"\n"));
            if (t.sendingOption.Equals("True"))
                sendingOption.Text = "ارسال دوره‌ای دارد";
            else
                sendingOption.Text = "ارسال دوره‌ای ندارد";
            if (t.confirmation.Equals("True"))
                confirmation.Text = "نیاز به تایید دارد";
            else
                confirmation.Text = "نیاز به تایید ندارد";
        }
    }
}

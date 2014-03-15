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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            TextBox dynamicTB = new TextBox();
            dynamicTB.Location = new Point(0, 0);
            Label dynamicL = new Label();
            dynamicL.Text = "شماره‌ی دانشجویی";
            dynamicL.Location = new Point(100, 5);

            TextBox dynamicTB2 = new TextBox();
            dynamicTB2.Location = new Point(0, 25);
            Label dynamicL2 = new Label();
            dynamicL2.Text = "نام";
            dynamicL2.Location = new Point(100, 30);

            TextBox dynamicTB3 = new TextBox();
            dynamicTB3.Location = new Point(0, 50);
            Label dynamicL3 = new Label();
            dynamicL3.Text = "نام خانوادگی";
            dynamicL3.Location = new Point(100, 55);

            TextBox dynamicTB4 = new TextBox();
            dynamicTB4.Location = new Point(0, 75);
            Label dynamicL4 = new Label();
            dynamicL4.Text = "پست الکترونیکی";
            dynamicL4.Location = new Point(100, 80);

            TextBox dynamicTB5 = new TextBox();
            dynamicTB5.Location = new Point(0, 100);
            Label dynamicL5 = new Label();
            dynamicL5.Text = "مقطع";
            dynamicL5.Location = new Point(100, 105);

            TextBox dynamicTB6 = new TextBox();
            dynamicTB6.Location = new Point(0, 125);
            Label dynamicL6 = new Label();
            dynamicL6.Text = "سال ورود";
            dynamicL6.Location = new Point(100, 130);

            TextBox dynamicTB7 = new TextBox();
            dynamicTB7.Location = new Point(0, 150);
            Label dynamicL7 = new Label();
            dynamicL7.Text = "رشته";
            dynamicL7.Location = new Point(100, 155);

            TextBox dynamicTB8 = new TextBox();
            dynamicTB8.Location = new Point(0, 175);
            Label dynamicL8 = new Label();
            dynamicL8.Text = "استاد راهنما";
            dynamicL8.Location = new Point(100, 180);

            Button save = new Button();
            save.Text = "ذخیره";
            save.Location = new Point(150, 220);
            save.Click += new System.EventHandler(save_Click);
            this.Controls.Add(dynamicL);
            this.Controls.Add(dynamicTB);
            this.Controls.Add(dynamicL2);
            this.Controls.Add(dynamicTB2);
            this.Controls.Add(dynamicL3);
            this.Controls.Add(dynamicTB3);
            this.Controls.Add(dynamicL4);
            this.Controls.Add(dynamicTB4);
            this.Controls.Add(dynamicL5);
            this.Controls.Add(dynamicTB5);
            this.Controls.Add(dynamicL6);
            this.Controls.Add(dynamicTB6);
            this.Controls.Add(dynamicL7);
            this.Controls.Add(dynamicTB7);
            this.Controls.Add(dynamicL8);
            this.Controls.Add(dynamicTB8);

            this.Controls.Add(save);
            this.Controls.Remove(addStudent);
        }
        private void save_Click(Object sender, System.EventArgs e)
        {
        }
    }
}

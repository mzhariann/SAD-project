﻿using System;
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
            addTextBox("شماره‌ی دانشجویی", 0, 0, 100, 5);
            addTextBox("نام", 0, 25, 100, 30);
            addTextBox("نام خانوادگی", 0, 50, 100, 55);
            addTextBox("ایمیل", 0, 75, 100, 80);
            addTextBox("مقطع", 0, 100, 100, 105);
            addTextBox("سال ورود", 0, 125, 100, 130);
            addTextBox("رشته", 0, 150, 100, 155);
            addTextBox("استاد راهنما", 0, 175, 100, 180);    
            addSaveButton();
         
        }
        private void save_Click(Object sender, System.EventArgs e)
        {
            if (this.Controls[1].Text.Equals("شماره‌ی دانشجویی"))
            {
                Student s = new Student();
                s.Id = int.Parse(Controls[0].Text);
                s.fname = Controls[2].Text;
                s.lname = Controls[4].Text;
                s.email = Controls[6].Text;
                s.degree = int.Parse(Controls[8].Text);
                s.entranceYear = int.Parse(Controls[10].Text);
                s.majorId = int.Parse(Controls[12].Text);
               // s.supervisor = Controls[14].Text;
            }

        }
        private void addTextBox(string text , int x1, int y1, int x2, int y2)
        {
            TextBox dynamicTB = new TextBox();
            dynamicTB.Location = new Point(x1, y1);
            Label dynamicL = new Label();
            dynamicL.Text = text;
            dynamicL.Location = new Point(x2, y2);
            this.Controls.Add(dynamicTB);
            this.Controls.Add(dynamicL);
        }

        private void addSaveButton()
        {
            Button save = new Button();
            save.Text = "ذخیره";
            save.Location = new Point(150, 220);
            save.Click += new System.EventHandler(save_Click);
            this.Controls.Add(save);
            this.Controls.Remove(addStudent);
            this.Controls.Remove(addProfessor);
            this.Controls.Remove(addEvaluator);

        }
        private void addProfessor_Click(object sender, EventArgs e)
        {
            addTextBox("شماره‌ی پرسنلی", 0, 0, 100, 5);
            addTextBox("نام", 0, 25, 100, 30);
            addTextBox("نام خانوادگی", 0, 50, 100, 55);
            addTextBox("ایمیل", 0, 75, 100, 80);
            addTextBox("مدیر گروه", 0, 100, 100, 105);
            addSaveButton();
        }

        private void addEvaluator_Click(object sender, EventArgs e)
        {
            addTextBox("شماره‌ی ارزیابی", 0, 0, 100, 5);
            addTextBox("نام", 0, 25, 100, 30);
            addTextBox("نام خانوادگی", 0, 50, 100, 55);
            addTextBox("ایمیل", 0, 75, 100, 80);
            addSaveButton();

        }
    }
}

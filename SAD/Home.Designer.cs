namespace SAD
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.studen_Info_Button = new System.Windows.Forms.Button();
            this.prof_Info_Button = new System.Windows.Forms.Button();
            this.eval_Prof_Button = new System.Windows.Forms.Button();
            this.events_Button = new System.Windows.Forms.Button();
            this.reports_Button = new System.Windows.Forms.Button();
            this.log_Button = new System.Windows.Forms.Button();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.new_Task_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.new_Task_Button);
            this.splitContainer1.Panel1.Controls.Add(this.delete_Button);
            this.splitContainer1.Panel1.Controls.Add(this.confirm_Button);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.log_Button);
            this.splitContainer1.Panel2.Controls.Add(this.reports_Button);
            this.splitContainer1.Panel2.Controls.Add(this.events_Button);
            this.splitContainer1.Panel2.Controls.Add(this.eval_Prof_Button);
            this.splitContainer1.Panel2.Controls.Add(this.prof_Info_Button);
            this.splitContainer1.Panel2.Controls.Add(this.studen_Info_Button);
            this.splitContainer1.Size = new System.Drawing.Size(912, 514);
            this.splitContainer1.SplitterDistance = 702;
            this.splitContainer1.TabIndex = 0;
            // 
            // studen_Info_Button
            // 
            this.studen_Info_Button.Location = new System.Drawing.Point(3, 13);
            this.studen_Info_Button.Name = "studen_Info_Button";
            this.studen_Info_Button.Size = new System.Drawing.Size(203, 23);
            this.studen_Info_Button.TabIndex = 0;
            this.studen_Info_Button.Text = "اطلاعات دانش‌جویان";
            this.studen_Info_Button.UseVisualStyleBackColor = true;
            this.studen_Info_Button.Click += new System.EventHandler(this.student_Info_Click);
            // 
            // prof_Info_Button
            // 
            this.prof_Info_Button.Location = new System.Drawing.Point(3, 33);
            this.prof_Info_Button.Name = "prof_Info_Button";
            this.prof_Info_Button.Size = new System.Drawing.Size(203, 23);
            this.prof_Info_Button.TabIndex = 1;
            this.prof_Info_Button.Text = "اطلاعات اساتید";
            this.prof_Info_Button.UseVisualStyleBackColor = true;
            this.prof_Info_Button.Click += new System.EventHandler(this.prof_Info_Click);
            // 
            // eval_Prof_Button
            // 
            this.eval_Prof_Button.Location = new System.Drawing.Point(3, 54);
            this.eval_Prof_Button.Name = "eval_Prof_Button";
            this.eval_Prof_Button.Size = new System.Drawing.Size(203, 23);
            this.eval_Prof_Button.TabIndex = 2;
            this.eval_Prof_Button.Text = "اطلاعات اساتید ارزیاب";
            this.eval_Prof_Button.UseVisualStyleBackColor = true;
            this.eval_Prof_Button.Click += new System.EventHandler(this.eval_Prof_Info_Click);
            // 
            // events_Button
            // 
            this.events_Button.Location = new System.Drawing.Point(3, 75);
            this.events_Button.Name = "events_Button";
            this.events_Button.Size = new System.Drawing.Size(203, 23);
            this.events_Button.TabIndex = 3;
            this.events_Button.Text = "رویدادها";
            this.events_Button.UseVisualStyleBackColor = true;
            this.events_Button.Click += new System.EventHandler(this.events_Click);
            // 
            // reports_Button
            // 
            this.reports_Button.Location = new System.Drawing.Point(3, 95);
            this.reports_Button.Name = "reports_Button";
            this.reports_Button.Size = new System.Drawing.Size(203, 23);
            this.reports_Button.TabIndex = 4;
            this.reports_Button.Text = "گزارش‌ها";
            this.reports_Button.UseVisualStyleBackColor = true;
            this.reports_Button.Click += new System.EventHandler(this.reports_Click);
            // 
            // log_Button
            // 
            this.log_Button.Location = new System.Drawing.Point(3, 116);
            this.log_Button.Name = "log_Button";
            this.log_Button.Size = new System.Drawing.Size(203, 23);
            this.log_Button.TabIndex = 5;
            this.log_Button.Text = "پیشینه‌ی نامه‌ها";
            this.log_Button.UseVisualStyleBackColor = true;
            this.log_Button.Click += new System.EventHandler(this.log_Click);
            // 
            // confirm_Button
            // 
            this.confirm_Button.Location = new System.Drawing.Point(552, 432);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(75, 23);
            this.confirm_Button.TabIndex = 0;
            this.confirm_Button.Text = "تایید نهایی";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(359, 431);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(75, 23);
            this.delete_Button.TabIndex = 1;
            this.delete_Button.Text = "حذف";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Click);
            // 
            // new_Task_Button
            // 
            this.new_Task_Button.Location = new System.Drawing.Point(104, 431);
            this.new_Task_Button.Name = "new_Task_Button";
            this.new_Task_Button.Size = new System.Drawing.Size(98, 23);
            this.new_Task_Button.TabIndex = 2;
            this.new_Task_Button.Text = "ایجاد نامه‌ی جدید";
            this.new_Task_Button.UseVisualStyleBackColor = true;
            this.new_Task_Button.Click += new System.EventHandler(this.new_Task_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 514);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Home";
            this.Text = "خانه";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button studen_Info_Button;
        private System.Windows.Forms.Button prof_Info_Button;
        private System.Windows.Forms.Button eval_Prof_Button;
        private System.Windows.Forms.Button events_Button;
        private System.Windows.Forms.Button reports_Button;
        private System.Windows.Forms.Button log_Button;
        private System.Windows.Forms.Button new_Task_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button confirm_Button;
    }
}
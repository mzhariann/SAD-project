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
            this.studen_Info_Button = new System.Windows.Forms.Button();
            this.prof_Info_Button = new System.Windows.Forms.Button();
            this.eval_Prof_Button = new System.Windows.Forms.Button();
            this.events_Button = new System.Windows.Forms.Button();
            this.reports_Button = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.savedTasks = new System.Windows.Forms.Button();
            this.new_Task_Button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groups_button = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
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
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(3, 116);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(203, 23);
            this.logButton.TabIndex = 5;
            this.logButton.Text = "پیشینه‌ی نامه‌ها";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.log_Click);
            // 
            // savedTasks
            // 
            this.savedTasks.Location = new System.Drawing.Point(3, 136);
            this.savedTasks.Name = "savedTasks";
            this.savedTasks.Size = new System.Drawing.Size(203, 23);
            this.savedTasks.TabIndex = 6;
            this.savedTasks.Text = "نامه‌های ذخیره شده";
            this.savedTasks.UseVisualStyleBackColor = true;
            this.savedTasks.Click += new System.EventHandler(this.savedTasks_Click);
            // 
            // new_Task_Button
            // 
            this.new_Task_Button.Location = new System.Drawing.Point(3, 156);
            this.new_Task_Button.Name = "new_Task_Button";
            this.new_Task_Button.Size = new System.Drawing.Size(203, 23);
            this.new_Task_Button.TabIndex = 2;
            this.new_Task_Button.Text = "ایجاد نامه‌ی جدید";
            this.new_Task_Button.UseVisualStyleBackColor = true;
            this.new_Task_Button.Click += new System.EventHandler(this.new_Task_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGrid1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groups_button);
            this.splitContainer1.Panel2.Controls.Add(this.new_Task_Button);
            this.splitContainer1.Panel2.Controls.Add(this.savedTasks);
            this.splitContainer1.Panel2.Controls.Add(this.logButton);
            this.splitContainer1.Panel2.Controls.Add(this.reports_Button);
            this.splitContainer1.Panel2.Controls.Add(this.events_Button);
            this.splitContainer1.Panel2.Controls.Add(this.eval_Prof_Button);
            this.splitContainer1.Panel2.Controls.Add(this.prof_Info_Button);
            this.splitContainer1.Panel2.Controls.Add(this.studen_Info_Button);
            this.splitContainer1.Size = new System.Drawing.Size(912, 514);
            this.splitContainer1.SplitterDistance = 702;
            this.splitContainer1.TabIndex = 0;
            // 
            // groups_button
            // 
            this.groups_button.Location = new System.Drawing.Point(3, 174);
            this.groups_button.Name = "groups_button";
            this.groups_button.Size = new System.Drawing.Size(203, 23);
            this.groups_button.TabIndex = 7;
            this.groups_button.Text = "گروه‌های افراد";
            this.groups_button.UseVisualStyleBackColor = true;
            this.groups_button.Click += new System.EventHandler(this.groups_click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 13);
            this.dataGrid1.MultiSelect = false;
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 368);
            this.dataGrid1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studen_Info_Button;
        private System.Windows.Forms.Button prof_Info_Button;
        private System.Windows.Forms.Button eval_Prof_Button;
        private System.Windows.Forms.Button events_Button;
        private System.Windows.Forms.Button reports_Button;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button savedTasks;
        private System.Windows.Forms.Button new_Task_Button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button groups_button;
        private System.Windows.Forms.DataGridView dataGrid1;

    }
}
namespace SAD
{
    partial class readOnlyTaskForm
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
            this.sendingPanel1 = new System.Windows.Forms.Panel();
            this.prd = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.every = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.prdSend = new System.Windows.Forms.Label();
            this.confirmation = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.editorTextBox = new System.Windows.Forms.RichTextBox();
            this.saveEditBtn = new System.Windows.Forms.Button();
            this.creationDate = new System.Windows.Forms.TextBox();
            this.delCanBtn = new System.Windows.Forms.Button();
            this.sendingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendingPanel1
            // 
            this.sendingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendingPanel1.Controls.Add(this.prd);
            this.sendingPanel1.Controls.Add(this.num);
            this.sendingPanel1.Controls.Add(this.every);
            this.sendingPanel1.Controls.Add(this.endDate);
            this.sendingPanel1.Controls.Add(this.to);
            this.sendingPanel1.Controls.Add(this.startDate);
            this.sendingPanel1.Controls.Add(this.from);
            this.sendingPanel1.Controls.Add(this.prdSend);
            this.sendingPanel1.Controls.Add(this.confirmation);
            this.sendingPanel1.Enabled = false;
            this.sendingPanel1.Location = new System.Drawing.Point(40, 304);
            this.sendingPanel1.Name = "sendingPanel1";
            this.sendingPanel1.Size = new System.Drawing.Size(591, 139);
            this.sendingPanel1.TabIndex = 25;
            // 
            // prd
            // 
            this.prd.AutoSize = true;
            this.prd.Location = new System.Drawing.Point(206, 34);
            this.prd.Name = "prd";
            this.prd.Size = new System.Drawing.Size(35, 13);
            this.prd.TabIndex = 8;
            this.prd.Text = "label1";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(247, 34);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(35, 13);
            this.num.TabIndex = 7;
            this.num.Text = "label1";
            // 
            // every
            // 
            this.every.AutoSize = true;
            this.every.Location = new System.Drawing.Point(288, 34);
            this.every.Name = "every";
            this.every.Size = new System.Drawing.Size(19, 13);
            this.every.TabIndex = 6;
            this.every.Text = "هر";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(313, 34);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(35, 13);
            this.endDate.TabIndex = 5;
            this.endDate.Text = "label1";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(430, 34);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(15, 13);
            this.to.TabIndex = 4;
            this.to.Text = "تا";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(451, 34);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(35, 13);
            this.startDate.TabIndex = 3;
            this.startDate.Text = "label1";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(571, 34);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(15, 13);
            this.from.TabIndex = 2;
            this.from.Text = "از";
            // 
            // prdSend
            // 
            this.prdSend.AutoSize = true;
            this.prdSend.Location = new System.Drawing.Point(488, 9);
            this.prdSend.Name = "prdSend";
            this.prdSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prdSend.Size = new System.Drawing.Size(98, 13);
            this.prdSend.TabIndex = 1;
            this.prdSend.Text = "ارسال دوره‌ای ندارد";
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(501, 56);
            this.confirmation.Name = "confirmation";
            this.confirmation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmation.Size = new System.Drawing.Size(85, 13);
            this.confirmation.TabIndex = 0;
            this.confirmation.Text = "نیاز به تایید ندارد";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(37, 36);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(32, 13);
            this.date.TabIndex = 21;
            this.date.Text = "تاریخ";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(573, 36);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(61, 13);
            this.subject.TabIndex = 20;
            this.subject.Text = "موضوع نامه";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Enabled = false;
            this.subjectTextBox.Location = new System.Drawing.Point(531, 52);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 0;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(590, 75);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(44, 13);
            this.contentLabel.TabIndex = 18;
            this.contentLabel.Text = "متن نامه";
            // 
            // editorTextBox
            // 
            this.editorTextBox.Enabled = false;
            this.editorTextBox.Location = new System.Drawing.Point(40, 101);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editorTextBox.Size = new System.Drawing.Size(591, 172);
            this.editorTextBox.TabIndex = 17;
            this.editorTextBox.Text = "";
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Location = new System.Drawing.Point(40, 458);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.saveEditBtn.TabIndex = 16;
            this.saveEditBtn.Text = "ویرایش";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // creationDate
            // 
            this.creationDate.Enabled = false;
            this.creationDate.Location = new System.Drawing.Point(40, 52);
            this.creationDate.Name = "creationDate";
            this.creationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.creationDate.Size = new System.Drawing.Size(165, 20);
            this.creationDate.TabIndex = 27;
            // 
            // delCanBtn
            // 
            this.delCanBtn.Location = new System.Drawing.Point(121, 458);
            this.delCanBtn.Name = "delCanBtn";
            this.delCanBtn.Size = new System.Drawing.Size(75, 23);
            this.delCanBtn.TabIndex = 28;
            this.delCanBtn.Text = "حذف";
            this.delCanBtn.UseVisualStyleBackColor = true;
            this.delCanBtn.Click += new System.EventHandler(this.delCanBtn_Click);
            // 
            // readOnlyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 505);
            this.Controls.Add(this.delCanBtn);
            this.Controls.Add(this.creationDate);
            this.Controls.Add(this.sendingPanel1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.editorTextBox);
            this.Controls.Add(this.saveEditBtn);
            this.Name = "readOnlyTask";
            this.Text = "readOnlyTask";
            this.sendingPanel1.ResumeLayout(false);
            this.sendingPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sendingPanel1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.RichTextBox editorTextBox;
        private System.Windows.Forms.Button saveEditBtn;
        private System.Windows.Forms.TextBox creationDate;
        private System.Windows.Forms.Button delCanBtn;
        private System.Windows.Forms.Label prdSend;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.Label prd;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label every;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label from;




    }
}
namespace SAD
{
    partial class Compose
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
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.editorTextBox = new System.Windows.Forms.RichTextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.hasPrdSend = new System.Windows.Forms.CheckBox();
            this.confirmation = new System.Windows.Forms.CheckBox();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.sendingPanel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.prdCmbBox = new System.Windows.Forms.ComboBox();
            this.numCmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.sendingPanel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.sendDate = new System.Windows.Forms.DateTimePicker();
            this.dntHavePrdSend = new System.Windows.Forms.CheckBox();
            this.creationDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.receiverBtn = new System.Windows.Forms.Button();
            this.sendingPanel1.SuspendLayout();
            this.sendingPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 443);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "ثبت";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(40, 99);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(591, 172);
            this.editorTextBox.TabIndex = 2;
            this.editorTextBox.Text = "";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(590, 73);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(44, 13);
            this.contentLabel.TabIndex = 3;
            this.contentLabel.Text = "متن نامه";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(531, 50);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 0;
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(573, 34);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(61, 13);
            this.subject.TabIndex = 5;
            this.subject.Text = "موضوع نامه";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(40, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(32, 13);
            this.date.TabIndex = 6;
            this.date.Text = "تاریخ";
            // 
            // hasPrdSend
            // 
            this.hasPrdSend.AutoSize = true;
            this.hasPrdSend.Location = new System.Drawing.Point(269, 9);
            this.hasPrdSend.Name = "hasPrdSend";
            this.hasPrdSend.Size = new System.Drawing.Size(116, 17);
            this.hasPrdSend.TabIndex = 3;
            this.hasPrdSend.Text = "ارسال دوره ای دارد";
            this.hasPrdSend.UseVisualStyleBackColor = true;
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(531, 364);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(100, 17);
            this.confirmation.TabIndex = 10;
            this.confirmation.Text = "نیاز به تایید دارد";
            this.confirmation.UseVisualStyleBackColor = true;
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "MMMM dd, yyyy";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(3, 38);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(167, 20);
            this.endDate.TabIndex = 5;
            // 
            // sendingPanel1
            // 
            this.sendingPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendingPanel1.Controls.Add(this.label5);
            this.sendingPanel1.Controls.Add(this.prdCmbBox);
            this.sendingPanel1.Controls.Add(this.numCmbBox);
            this.sendingPanel1.Controls.Add(this.label3);
            this.sendingPanel1.Controls.Add(this.label2);
            this.sendingPanel1.Controls.Add(this.label1);
            this.sendingPanel1.Controls.Add(this.endDate);
            this.sendingPanel1.Controls.Add(this.startDate);
            this.sendingPanel1.Controls.Add(this.hasPrdSend);
            this.sendingPanel1.Location = new System.Drawing.Point(40, 302);
            this.sendingPanel1.Name = "sendingPanel1";
            this.sendingPanel1.Size = new System.Drawing.Size(390, 108);
            this.sendingPanel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "تعداد";
            // 
            // prdCmbBox
            // 
            this.prdCmbBox.FormattingEnabled = true;
            this.prdCmbBox.Items.AddRange(new object[] {
            "هفته",
            "ماه",
            "سال"});
            this.prdCmbBox.Location = new System.Drawing.Point(3, 76);
            this.prdCmbBox.Name = "prdCmbBox";
            this.prdCmbBox.Size = new System.Drawing.Size(100, 21);
            this.prdCmbBox.TabIndex = 7;
            this.prdCmbBox.Tag = "هفته/ماه/سال";
            // 
            // numCmbBox
            // 
            this.numCmbBox.FormattingEnabled = true;
            this.numCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.numCmbBox.Location = new System.Drawing.Point(109, 76);
            this.numCmbBox.Name = "numCmbBox";
            this.numCmbBox.Size = new System.Drawing.Size(61, 21);
            this.numCmbBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "بازه‌ی ارسال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "پایان دوره";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "شروع دوره";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "MMMM dd, yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(3, 10);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(167, 20);
            this.startDate.TabIndex = 4;
            // 
            // sendingPanel2
            // 
            this.sendingPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendingPanel2.Controls.Add(this.label4);
            this.sendingPanel2.Controls.Add(this.sendDate);
            this.sendingPanel2.Controls.Add(this.dntHavePrdSend);
            this.sendingPanel2.Location = new System.Drawing.Point(441, 302);
            this.sendingPanel2.Name = "sendingPanel2";
            this.sendingPanel2.Size = new System.Drawing.Size(190, 58);
            this.sendingPanel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "روز ارسال";
            // 
            // sendDate
            // 
            this.sendDate.CustomFormat = "MMMM dd, yyyy";
            this.sendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sendDate.Location = new System.Drawing.Point(3, 28);
            this.sendDate.Name = "sendDate";
            this.sendDate.Size = new System.Drawing.Size(123, 20);
            this.sendDate.TabIndex = 9;
            // 
            // dntHavePrdSend
            // 
            this.dntHavePrdSend.AutoSize = true;
            this.dntHavePrdSend.Location = new System.Drawing.Point(66, 5);
            this.dntHavePrdSend.Name = "dntHavePrdSend";
            this.dntHavePrdSend.Size = new System.Drawing.Size(117, 17);
            this.dntHavePrdSend.TabIndex = 8;
            this.dntHavePrdSend.Text = "ارسال دوره‌ای ندارد";
            this.dntHavePrdSend.UseVisualStyleBackColor = true;
            // 
            // creationDate
            // 
            this.creationDate.CustomFormat = "MMMM dd, yyyy";
            this.creationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.creationDate.Location = new System.Drawing.Point(40, 50);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(146, 20);
            this.creationDate.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // receiverBtn
            // 
            this.receiverBtn.Location = new System.Drawing.Point(441, 387);
            this.receiverBtn.Name = "receiverBtn";
            this.receiverBtn.Size = new System.Drawing.Size(190, 23);
            this.receiverBtn.TabIndex = 15;
            this.receiverBtn.Text = "انتخاب گیرند‌ه‌ها";
            this.receiverBtn.UseVisualStyleBackColor = true;
            this.receiverBtn.Click += new System.EventHandler(this.receiverBtn_Click);
            // 
            // Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 495);
            this.Controls.Add(this.receiverBtn);
            this.Controls.Add(this.creationDate);
            this.Controls.Add(this.sendingPanel2);
            this.Controls.Add(this.sendingPanel1);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.editorTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "Compose";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sendingPanel1.ResumeLayout(false);
            this.sendingPanel1.PerformLayout();
            this.sendingPanel2.ResumeLayout(false);
            this.sendingPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox editorTextBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.CheckBox hasPrdSend;
        private System.Windows.Forms.CheckBox confirmation;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Panel sendingPanel1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel sendingPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker sendDate;
        private System.Windows.Forms.CheckBox dntHavePrdSend;
        private System.Windows.Forms.DateTimePicker creationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox prdCmbBox;
        private System.Windows.Forms.ComboBox numCmbBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button receiverBtn;
    }
}
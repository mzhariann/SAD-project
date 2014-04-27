namespace SAD
{
    partial class ComposeForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.editorTextBox = new System.Windows.Forms.RichTextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.sendingOption = new System.Windows.Forms.CheckBox();
            this.confirmation = new System.Windows.Forms.CheckBox();
            this.receiverCheckList = new System.Windows.Forms.CheckedListBox();
            this.receiverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(364, 470);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "ثبت";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(137, 135);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(591, 172);
            this.editorTextBox.TabIndex = 2;
            this.editorTextBox.Text = "";
            this.editorTextBox.TextChanged += new System.EventHandler(this.editor_Text_Changed);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(684, 116);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(44, 13);
            this.contentLabel.TabIndex = 3;
            this.contentLabel.Text = "متن نامه";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(628, 86);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 4;
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(667, 69);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(61, 13);
            this.subject.TabIndex = 5;
            this.subject.Text = "موضوع نامه";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(134, 69);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(32, 13);
            this.date.TabIndex = 6;
            this.date.Text = "تاریخ";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(132, 86);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 7;
            // 
            // sendingOption
            // 
            this.sendingOption.AutoSize = true;
            this.sendingOption.Location = new System.Drawing.Point(137, 367);
            this.sendingOption.Name = "sendingOption";
            this.sendingOption.Size = new System.Drawing.Size(95, 17);
            this.sendingOption.TabIndex = 8;
            this.sendingOption.Text = "ارسال دوره ای";
            this.sendingOption.UseVisualStyleBackColor = true;
            this.sendingOption.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(137, 391);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(100, 17);
            this.confirmation.TabIndex = 9;
            this.confirmation.Text = "نیاز به تایید دارد";
            this.confirmation.UseVisualStyleBackColor = true;
            // 
            // receiverCheckList
            // 
            this.receiverCheckList.FormattingEnabled = true;
            this.receiverCheckList.Items.AddRange(new object[] {
            "اساتید طراح",
            "اساتیدی که نمرات را نداده‌اند",
            "دانشجویان دکتری",
            "مدیران گروه‌ها",
            "دانشجویان جدیدالورود",
            "استاید ارزیاب",
            "اساتید درس سمینار",
            "همه‌ی اساتید",
            "همه‌ی دانشجویان"});
            this.receiverCheckList.Location = new System.Drawing.Point(561, 337);
            this.receiverCheckList.Name = "receiverCheckList";
            this.receiverCheckList.Size = new System.Drawing.Size(167, 139);
            this.receiverCheckList.TabIndex = 10;
            // 
            // receiverLabel
            // 
            this.receiverLabel.AutoSize = true;
            this.receiverLabel.Location = new System.Drawing.Point(684, 321);
            this.receiverLabel.Name = "receiverLabel";
            this.receiverLabel.Size = new System.Drawing.Size(38, 13);
            this.receiverLabel.TabIndex = 11;
            this.receiverLabel.Text = "گیرنده";
            // 
            // Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 505);
            this.Controls.Add(this.receiverLabel);
            this.Controls.Add(this.receiverCheckList);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.sendingOption);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.editorTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "Compose";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نامه‌ی جدید";
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
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.CheckBox sendingOption;
        private System.Windows.Forms.CheckBox confirmation;
        private System.Windows.Forms.CheckedListBox receiverCheckList;
        private System.Windows.Forms.Label receiverLabel;
    }
}
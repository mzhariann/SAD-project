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
            this.receivers = new System.Windows.Forms.ListView();
            this.confirmation = new System.Windows.Forms.Label();
            this.sendingOption = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receivers
            // 
            this.receivers.Location = new System.Drawing.Point(362, 318);
            this.receivers.Name = "receivers";
            this.receivers.Size = new System.Drawing.Size(121, 163);
            this.receivers.TabIndex = 0;
            this.receivers.UseCompatibleStateImageBehavior = false;
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(101, 378);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(35, 13);
            this.confirmation.TabIndex = 1;
            this.confirmation.Text = "label1";
            // 
            // sendingOption
            // 
            this.sendingOption.AutoSize = true;
            this.sendingOption.Location = new System.Drawing.Point(101, 403);
            this.sendingOption.Name = "sendingOption";
            this.sendingOption.Size = new System.Drawing.Size(35, 13);
            this.sendingOption.TabIndex = 2;
            this.sendingOption.Text = "label2";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(438, 42);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(35, 13);
            this.subject.TabIndex = 3;
            this.subject.Text = "label3";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(44, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(35, 13);
            this.date.TabIndex = 4;
            this.date.Text = "label4";
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(224, 130);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(35, 13);
            this.content.TabIndex = 5;
            this.content.Text = "label5";
            // 
            // readOnlyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 505);
            this.Controls.Add(this.content);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.sendingOption);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.receivers);
            this.Name = "readOnlyTask";
            this.Text = "readOnlyTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView receivers;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.Label sendingOption;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label content;
    }
}
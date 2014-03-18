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
            this.saveButton = new System.Windows.Forms.Button();
            this.editor_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(387, 440);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "ثبت";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // editor_TextBox
            // 
            this.editor_TextBox.Location = new System.Drawing.Point(46, 55);
            this.editor_TextBox.Name = "editor_TextBox";
            this.editor_TextBox.Size = new System.Drawing.Size(773, 343);
            this.editor_TextBox.TabIndex = 2;
            this.editor_TextBox.Text = "";
            this.editor_TextBox.TextChanged += new System.EventHandler(this.editor_Text_Changed);
            // 
            // Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 505);
            this.Controls.Add(this.editor_TextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "Compose";
            this.Text = "نامه‌ی جدید";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox editor_TextBox;
    }
}
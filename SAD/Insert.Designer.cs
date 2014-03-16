namespace SAD
{
    partial class Insert
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
            this.addStudent = new System.Windows.Forms.Button();
            this.addProfessor = new System.Windows.Forms.Button();
            this.addEvaluator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(57, 71);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(182, 23);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "اضافه کردن دانشجو";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // addProfessor
            // 
            this.addProfessor.Location = new System.Drawing.Point(57, 100);
            this.addProfessor.Name = "addProfessor";
            this.addProfessor.Size = new System.Drawing.Size(182, 23);
            this.addProfessor.TabIndex = 1;
            this.addProfessor.Text = "اضافه کردن استاد";
            this.addProfessor.UseVisualStyleBackColor = true;
            this.addProfessor.Click += new System.EventHandler(this.addProfessor_Click);
            // 
            // addEvaluator
            // 
            this.addEvaluator.Location = new System.Drawing.Point(57, 129);
            this.addEvaluator.Name = "addEvaluator";
            this.addEvaluator.Size = new System.Drawing.Size(182, 23);
            this.addEvaluator.TabIndex = 2;
            this.addEvaluator.Text = "اضافه کردن ارزیاب";
            this.addEvaluator.UseVisualStyleBackColor = true;
            this.addEvaluator.Click += new System.EventHandler(this.addEvaluator_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.addEvaluator);
            this.Controls.Add(this.addProfessor);
            this.Controls.Add(this.addStudent);
            this.Name = "Insert";
            this.Text = "ویرایش";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button addProfessor;
        private System.Windows.Forms.Button addEvaluator;
    }
}
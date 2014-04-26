namespace SAD
{
    partial class EditGroup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Students_Group_Label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.evalGridView = new System.Windows.Forms.DataGridView();
            this.EvalSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.profGridView = new System.Windows.Forms.DataGridView();
            this.profSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.StudentSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.evalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = ": اساتید ارزیاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = ": اساتید";
            // 
            // Students_Group_Label
            // 
            this.Students_Group_Label.AutoSize = true;
            this.Students_Group_Label.Location = new System.Drawing.Point(651, 101);
            this.Students_Group_Label.Name = "Students_Group_Label";
            this.Students_Group_Label.Size = new System.Drawing.Size(62, 13);
            this.Students_Group_Label.TabIndex = 15;
            this.Students_Group_Label.Text = ": دانشجویان";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(660, 58);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(53, 13);
            this.name_label.TabIndex = 14;
            this.name_label.Text = ": نام گروه";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(555, 55);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(100, 20);
            this.name_txtbox.TabIndex = 13;
            this.name_txtbox.TextChanged += new System.EventHandler(this.name_txtbox_TextChanged);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(629, 301);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "ثبت";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // evalGridView
            // 
            this.evalGridView.AllowUserToAddRows = false;
            this.evalGridView.AllowUserToDeleteRows = false;
            this.evalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvalSelect});
            this.evalGridView.Location = new System.Drawing.Point(36, 117);
            this.evalGridView.Name = "evalGridView";
            this.evalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evalGridView.ShowEditingIcon = false;
            this.evalGridView.Size = new System.Drawing.Size(151, 162);
            this.evalGridView.TabIndex = 11;
            // 
            // EvalSelect
            // 
            this.EvalSelect.HeaderText = "";
            this.EvalSelect.Name = "EvalSelect";
            // 
            // profGridView
            // 
            this.profGridView.AllowUserToAddRows = false;
            this.profGridView.AllowUserToDeleteRows = false;
            this.profGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profSelect});
            this.profGridView.Location = new System.Drawing.Point(204, 117);
            this.profGridView.Name = "profGridView";
            this.profGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profGridView.ShowEditingIcon = false;
            this.profGridView.Size = new System.Drawing.Size(223, 162);
            this.profGridView.TabIndex = 10;
            // 
            // profSelect
            // 
            this.profSelect.HeaderText = "";
            this.profSelect.Name = "profSelect";
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.AllowUserToDeleteRows = false;
            this.studentsGridView.AllowUserToOrderColumns = true;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentSelect});
            this.studentsGridView.Location = new System.Drawing.Point(453, 117);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsGridView.ShowEditingIcon = false;
            this.studentsGridView.Size = new System.Drawing.Size(260, 162);
            this.studentsGridView.TabIndex = 9;
            // 
            // StudentSelect
            // 
            this.StudentSelect.HeaderText = "";
            this.StudentSelect.Name = "StudentSelect";
            // 
            // EditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Students_Group_Label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.evalGridView);
            this.Controls.Add(this.profGridView);
            this.Controls.Add(this.studentsGridView);
            this.Name = "EditGroup";
            this.Text = "EditGroup";
            ((System.ComponentModel.ISupportInitialize)(this.evalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Students_Group_Label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView evalGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EvalSelect;
        private System.Windows.Forms.DataGridView profGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn profSelect;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentSelect;

    }
}
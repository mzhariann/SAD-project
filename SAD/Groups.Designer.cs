namespace SAD
{
    partial class Groups
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
            this.new_group_btn = new System.Windows.Forms.Button();
            this.groupsDataGridView = new System.Windows.Forms.DataGridView();
            this.edit_group_btn = new System.Windows.Forms.Button();
            this.delete_group_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // new_group_btn
            // 
            this.new_group_btn.Location = new System.Drawing.Point(12, 196);
            this.new_group_btn.Name = "new_group_btn";
            this.new_group_btn.Size = new System.Drawing.Size(114, 23);
            this.new_group_btn.TabIndex = 0;
            this.new_group_btn.Text = "ایجاد گروه جدید";
            this.new_group_btn.UseVisualStyleBackColor = true;
            this.new_group_btn.Click += new System.EventHandler(this.new_group_btn_Click);
            // 
            // groupsDataGridView
            // 
            this.groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGridView.Location = new System.Drawing.Point(36, 12);
            this.groupsDataGridView.MultiSelect = false;
            this.groupsDataGridView.Name = "groupsDataGridView";
            this.groupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsDataGridView.Size = new System.Drawing.Size(334, 167);
            this.groupsDataGridView.TabIndex = 1;
            // 
            // edit_group_btn
            // 
            this.edit_group_btn.Location = new System.Drawing.Point(148, 196);
            this.edit_group_btn.Name = "edit_group_btn";
            this.edit_group_btn.Size = new System.Drawing.Size(114, 23);
            this.edit_group_btn.TabIndex = 2;
            this.edit_group_btn.Text = "ویرایش";
            this.edit_group_btn.UseVisualStyleBackColor = true;
            this.edit_group_btn.Click += new System.EventHandler(this.edit_group_btn_Click);
            // 
            // delete_group_btn
            // 
            this.delete_group_btn.Location = new System.Drawing.Point(282, 196);
            this.delete_group_btn.Name = "delete_group_btn";
            this.delete_group_btn.Size = new System.Drawing.Size(114, 23);
            this.delete_group_btn.TabIndex = 3;
            this.delete_group_btn.Text = "حذف گروه";
            this.delete_group_btn.UseVisualStyleBackColor = true;
            this.delete_group_btn.Click += new System.EventHandler(this.delete_group_btn_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 275);
            this.Controls.Add(this.delete_group_btn);
            this.Controls.Add(this.edit_group_btn);
            this.Controls.Add(this.groupsDataGridView);
            this.Controls.Add(this.new_group_btn);
            this.Name = "Groups";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_group_btn;
        private System.Windows.Forms.DataGridView groupsDataGridView;
        private System.Windows.Forms.Button edit_group_btn;
        private System.Windows.Forms.Button delete_group_btn;

    }
}
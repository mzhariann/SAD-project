namespace SAD
{
    partial class Receivers
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
            this.grpsGridView = new System.Windows.Forms.DataGridView();
            this.addGrps = new System.Windows.Forms.Button();
            this.showMembers = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.showGrps = new System.Windows.Forms.Button();
            this.addMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grpsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpsGridView
            // 
            this.grpsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpsGridView.Location = new System.Drawing.Point(12, 33);
            this.grpsGridView.Name = "grpsGridView";
            this.grpsGridView.Size = new System.Drawing.Size(727, 170);
            this.grpsGridView.TabIndex = 0;
            // 
            // addGrps
            // 
            this.addGrps.Location = new System.Drawing.Point(443, 209);
            this.addGrps.Name = "addGrps";
            this.addGrps.Size = new System.Drawing.Size(181, 23);
            this.addGrps.TabIndex = 2;
            this.addGrps.Text = "اضافه کردن گروه‌های انتخاب شده";
            this.addGrps.UseVisualStyleBackColor = true;
            this.addGrps.Click += new System.EventHandler(this.addGrps_Click);
            // 
            // showMembers
            // 
            this.showMembers.Location = new System.Drawing.Point(246, 209);
            this.showMembers.Name = "showMembers";
            this.showMembers.Size = new System.Drawing.Size(191, 23);
            this.showMembers.TabIndex = 3;
            this.showMembers.Text = "مشاهده‌ی اعضای گروه انتخاب شده";
            this.showMembers.UseVisualStyleBackColor = true;
            this.showMembers.Click += new System.EventHandler(this.showMembers_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(263, 257);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(207, 23);
            this.done.TabIndex = 4;
            this.done.Text = "اتمام انتخاب";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // showGrps
            // 
            this.showGrps.Location = new System.Drawing.Point(630, 209);
            this.showGrps.Name = "showGrps";
            this.showGrps.Size = new System.Drawing.Size(109, 23);
            this.showGrps.TabIndex = 5;
            this.showGrps.Text = "مشاهده‌ی گروه‌ها";
            this.showGrps.UseVisualStyleBackColor = true;
            this.showGrps.Click += new System.EventHandler(this.showGrps_Click);
            // 
            // addMembers
            // 
            this.addMembers.Location = new System.Drawing.Point(12, 209);
            this.addMembers.Name = "addMembers";
            this.addMembers.Size = new System.Drawing.Size(228, 23);
            this.addMembers.TabIndex = 6;
            this.addMembers.Text = "اضافه کردن افراد انتخاب شده";
            this.addMembers.UseVisualStyleBackColor = true;
            this.addMembers.Click += new System.EventHandler(this.addMembers_Click);
            // 
            // Receivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 294);
            this.Controls.Add(this.addMembers);
            this.Controls.Add(this.showGrps);
            this.Controls.Add(this.done);
            this.Controls.Add(this.showMembers);
            this.Controls.Add(this.addGrps);
            this.Controls.Add(this.grpsGridView);
            this.Name = "Receivers";
            this.Text = "Receivers";
            ((System.ComponentModel.ISupportInitialize)(this.grpsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grpsGridView;
        private System.Windows.Forms.Button addGrps;
        private System.Windows.Forms.Button showMembers;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button showGrps;
        private System.Windows.Forms.Button addMembers;
    }
}
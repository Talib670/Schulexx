namespace Schulexx.Controls
{
    partial class StaffI_cardinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_generate = new System.Windows.Forms.Button();
            this.Chk_sort = new System.Windows.Forms.CheckBox();
            this.Staff_type = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Staff_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(410, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Identity Card Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Location = new System.Drawing.Point(16, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1061, 393);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1055, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_generate);
            this.groupBox2.Controls.Add(this.Chk_sort);
            this.groupBox2.Controls.Add(this.Staff_type);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // Btn_generate
            // 
            this.Btn_generate.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_generate.Location = new System.Drawing.Point(380, 28);
            this.Btn_generate.Name = "Btn_generate";
            this.Btn_generate.Size = new System.Drawing.Size(102, 35);
            this.Btn_generate.TabIndex = 3;
            this.Btn_generate.Text = "Generate";
            this.Btn_generate.UseVisualStyleBackColor = false;
            // 
            // Chk_sort
            // 
            this.Chk_sort.AutoSize = true;
            this.Chk_sort.Location = new System.Drawing.Point(16, 34);
            this.Chk_sort.Name = "Chk_sort";
            this.Chk_sort.Size = new System.Drawing.Size(134, 21);
            this.Chk_sort.TabIndex = 2;
            this.Chk_sort.Text = "Sort by Staff Type";
            this.Chk_sort.UseVisualStyleBackColor = true;
            this.Chk_sort.CheckedChanged += new System.EventHandler(this.Chk_sort_CheckedChanged);
            // 
            // Staff_type
            // 
            this.Staff_type.Controls.Add(this.comboBox1);
            this.Staff_type.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_type.Location = new System.Drawing.Point(157, 16);
            this.Staff_type.Name = "Staff_type";
            this.Staff_type.Size = new System.Drawing.Size(203, 49);
            this.Staff_type.TabIndex = 0;
            this.Staff_type.TabStop = false;
            this.Staff_type.Text = "Select";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Teaching Staff",
            "Non Teachning Staff"});
            this.comboBox1.Location = new System.Drawing.Point(8, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 25);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StaffI_cardinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "StaffI_cardinfo";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.StaffI_cardinfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Staff_type.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_generate;
        private System.Windows.Forms.CheckBox Chk_sort;
        private System.Windows.Forms.GroupBox Staff_type;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

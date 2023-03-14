namespace Schulexx.AttendanceUI
{
    partial class IndividualStudentsAttendance
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
            this.Btn_generate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Staff_type = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Staff_type.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(410, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 54);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Attendance Report";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Location = new System.Drawing.Point(16, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1061, 393);
            this.groupBox3.TabIndex = 22;
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
            // Btn_generate
            // 
            this.Btn_generate.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_generate.Location = new System.Drawing.Point(963, 103);
            this.Btn_generate.Name = "Btn_generate";
            this.Btn_generate.Size = new System.Drawing.Size(102, 35);
            this.Btn_generate.TabIndex = 20;
            this.Btn_generate.Text = "Generate";
            this.Btn_generate.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.Staff_type);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(441, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 75);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Period";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(267, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 49);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // Staff_type
            // 
            this.Staff_type.Controls.Add(this.dateTimePicker1);
            this.Staff_type.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_type.Location = new System.Drawing.Point(6, 20);
            this.Staff_type.Name = "Staff_type";
            this.Staff_type.Size = new System.Drawing.Size(221, 49);
            this.Staff_type.TabIndex = 0;
            this.Staff_type.TabStop = false;
            this.Staff_type.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 59);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Class";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(160, 92);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(252, 59);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select Student";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 25);
            this.comboBox2.TabIndex = 0;
            // 
            // IndividualStudentsAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_generate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "IndividualStudentsAttendance";
            this.Size = new System.Drawing.Size(1093, 563);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.Staff_type.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button Btn_generate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox Staff_type;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

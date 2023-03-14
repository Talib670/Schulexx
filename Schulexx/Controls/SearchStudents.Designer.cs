namespace Schulexx.Controls
{
    partial class SearchStudents
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Btn_searchStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Students";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students Search Results";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Class",
            "Name",
            "Home district",
            "Country",
            "Year Of Admission"});
            this.comboBox1.Location = new System.Drawing.Point(6, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Class",
            "Name",
            "Home district",
            "Country",
            "Year Of Admission"});
            this.comboBox2.Location = new System.Drawing.Point(8, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Btn_searchStudent
            // 
            this.Btn_searchStudent.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_searchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_searchStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_searchStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_searchStudent.Location = new System.Drawing.Point(695, 38);
            this.Btn_searchStudent.Name = "Btn_searchStudent";
            this.Btn_searchStudent.Size = new System.Drawing.Size(106, 34);
            this.Btn_searchStudent.TabIndex = 5;
            this.Btn_searchStudent.Text = "Search";
            this.Btn_searchStudent.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Student By";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(463, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 52);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Students Name";
            // 
            // SearchStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_searchStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearchStudents";
            this.Size = new System.Drawing.Size(1093, 563);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Btn_searchStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

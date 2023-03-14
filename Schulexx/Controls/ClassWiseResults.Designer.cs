namespace Schulexx.Controls
{
    partial class ClassWiseResults
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
            this.term_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SubjectID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StregNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.examSes_cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExamDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExamType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.obtainedMarks_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // term_cbx
            // 
            this.term_cbx.FormattingEnabled = true;
            this.term_cbx.Items.AddRange(new object[] {
            "ONE",
            "TWO",
            "THREE"});
            this.term_cbx.Location = new System.Drawing.Point(270, 6);
            this.term_cbx.Name = "term_cbx";
            this.term_cbx.Size = new System.Drawing.Size(76, 21);
            this.term_cbx.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 397);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students Enrolled for Subject";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubjectID,
            this.StregNo,
            this.StuName});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SubjectID
            // 
            this.SubjectID.Text = "ID";
            this.SubjectID.Width = 0;
            // 
            // StregNo
            // 
            this.StregNo.Text = "Student Reg No";
            this.StregNo.Width = 125;
            // 
            // StuName
            // 
            this.StuName.Text = "Student Name";
            this.StuName.Width = 207;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(152, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "2016";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "ACADEMIC YEAR:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.term_cbx);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.examSes_cbx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 32);
            this.panel1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Exam Session:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(665, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "EXAM TYPE:";
            // 
            // examSes_cbx
            // 
            this.examSes_cbx.FormattingEnabled = true;
            this.examSes_cbx.Items.AddRange(new object[] {
            "Begining of term",
            "Middle term",
            "End of term"});
            this.examSes_cbx.Location = new System.Drawing.Point(469, 6);
            this.examSes_cbx.Name = "examSes_cbx";
            this.examSes_cbx.Size = new System.Drawing.Size(152, 21);
            this.examSes_cbx.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "YEAR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "2016";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "TERM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "O Level class wise Marks Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(575, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 424);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subject Marks Entry";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.RegNo,
            this.StudentName,
            this.ExamDate,
            this.ExamType,
            this.Marks});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(492, 402);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // RegNo
            // 
            this.RegNo.Text = "Reg Number";
            this.RegNo.Width = 128;
            // 
            // StudentName
            // 
            this.StudentName.Text = "Student Name";
            this.StudentName.Width = 118;
            // 
            // ExamDate
            // 
            this.ExamDate.Text = "Exam Date";
            this.ExamDate.Width = 89;
            // 
            // ExamType
            // 
            this.ExamType.Text = "Exam Type";
            this.ExamType.Width = 80;
            // 
            // Marks
            // 
            this.Marks.Text = "Marks";
            this.Marks.Width = 81;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 50);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Class";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 25);
            this.comboBox2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(156, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 52);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Subject";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(223, 25);
            this.comboBox3.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.SaveBtn);
            this.groupBox9.Controls.Add(this.NewBtn);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(347, 148);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(210, 234);
            this.groupBox9.TabIndex = 36;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Marks Entry for subject";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(121, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(121, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(81, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Comment:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Aggregates:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Grade:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBtn.Location = new System.Drawing.Point(104, 197);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 29);
            this.SaveBtn.TabIndex = 24;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewBtn.Location = new System.Drawing.Point(23, 197);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 29);
            this.NewBtn.TabIndex = 24;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.obtainedMarks_textBox);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(23, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 48);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Marks Obtained";
            // 
            // obtainedMarks_textBox
            // 
            this.obtainedMarks_textBox.Location = new System.Drawing.Point(6, 18);
            this.obtainedMarks_textBox.Name = "obtainedMarks_textBox";
            this.obtainedMarks_textBox.Size = new System.Drawing.Size(121, 23);
            this.obtainedMarks_textBox.TabIndex = 0;
            // 
            // ClassWiseResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ClassWiseResults";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.ClassWiseResults_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox term_cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SubjectID;
        private System.Windows.Forms.ColumnHeader StregNo;
        private System.Windows.Forms.ColumnHeader StuName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox examSes_cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader RegNo;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader ExamDate;
        private System.Windows.Forms.ColumnHeader ExamType;
        private System.Windows.Forms.ColumnHeader Marks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox obtainedMarks_textBox;
    }
}

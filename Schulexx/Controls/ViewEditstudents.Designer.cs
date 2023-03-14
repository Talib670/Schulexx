namespace Schulexx.Controls
{
    partial class ViewEditstudents
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.stdD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParentNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StdClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.district = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Village = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.student_txt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Levels_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.class_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Subject_assign = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(204, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 35);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1060, 433);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stdD,
            this.RegNo,
            this.StdName,
            this.Gender,
            this.StdClass,
            this.ParentNames,
            this.DOB,
            this.district,
            this.Village});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1054, 411);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // stdD
            // 
            this.stdD.Text = "Student ID";
            this.stdD.Width = 0;
            // 
            // RegNo
            // 
            this.RegNo.Text = "Registration Number";
            this.RegNo.Width = 148;
            // 
            // StdName
            // 
            this.StdName.Text = "Student Names";
            this.StdName.Width = 197;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 78;
            // 
            // ParentNames
            // 
            this.ParentNames.Text = "Parent Names";
            this.ParentNames.Width = 145;
            // 
            // StdClass
            // 
            this.StdClass.Text = "Study Section";
            this.StdClass.Width = 114;
            // 
            // DOB
            // 
            this.DOB.Text = "Birth Date";
            this.DOB.Width = 127;
            // 
            // district
            // 
            this.district.Text = "Home District";
            this.district.Width = 142;
            // 
            // Village
            // 
            this.Village.Text = "Village";
            this.Village.Width = 123;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(20, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.student_txt);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(294, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 50);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Student";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(662, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "LAST NAME";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(565, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "FIRST NAME";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(496, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MATCH";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "OR NAMES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEARCH BY REG NO #";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 0;
            // 
            // student_txt
            // 
            this.student_txt.Location = new System.Drawing.Point(126, 19);
            this.student_txt.Name = "student_txt";
            this.student_txt.Size = new System.Drawing.Size(140, 23);
            this.student_txt.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Levels_cbx);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(151, 50);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select Levels";
            // 
            // Levels_cbx
            // 
            this.Levels_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Levels_cbx.FormattingEnabled = true;
            this.Levels_cbx.Location = new System.Drawing.Point(3, 19);
            this.Levels_cbx.Name = "Levels_cbx";
            this.Levels_cbx.Size = new System.Drawing.Size(145, 25);
            this.Levels_cbx.TabIndex = 0;
            this.Levels_cbx.SelectedIndexChanged += new System.EventHandler(this.Levels_cbx_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.class_combo);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(163, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 50);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Class";
            // 
            // class_combo
            // 
            this.class_combo.FormattingEnabled = true;
            this.class_combo.Location = new System.Drawing.Point(7, 19);
            this.class_combo.Name = "class_combo";
            this.class_combo.Size = new System.Drawing.Size(110, 25);
            this.class_combo.TabIndex = 0;
            this.class_combo.SelectedIndexChanged += new System.EventHandler(this.class_combo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(838, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Action";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subject_assign
            // 
            this.Subject_assign.BackColor = System.Drawing.Color.DarkCyan;
            this.Subject_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subject_assign.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_assign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subject_assign.Location = new System.Drawing.Point(955, 7);
            this.Subject_assign.Name = "Subject_assign";
            this.Subject_assign.Size = new System.Drawing.Size(113, 35);
            this.Subject_assign.TabIndex = 1;
            this.Subject_assign.Text = "Assign Subjects";
            this.Subject_assign.UseVisualStyleBackColor = false;
            this.Subject_assign.Click += new System.EventHandler(this.Subject_assign_Click);
            // 
            // ViewEditstudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Subject_assign);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewEditstudents";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.ViewEditstudents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader stdD;
        private System.Windows.Forms.ColumnHeader StdName;
        private System.Windows.Forms.ColumnHeader StdClass;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader ParentNames;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader Village;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColumnHeader RegNo;
        private System.Windows.Forms.ColumnHeader district;
        private System.Windows.Forms.Button Subject_assign;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox student_txt;
        private System.Windows.Forms.ComboBox class_combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox Levels_cbx;
    }
}

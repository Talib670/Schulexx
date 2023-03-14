namespace Schulexx.Controls
{
    partial class SubjectsAssignAlevel
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
            this.Subj_cbx = new System.Windows.Forms.ComboBox();
            this.SubName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Short = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.st_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.yearCbx = new System.Windows.Forms.ComboBox();
            this.yr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Subj_cbx
            // 
            this.Subj_cbx.FormattingEnabled = true;
            this.Subj_cbx.Location = new System.Drawing.Point(7, 22);
            this.Subj_cbx.Name = "Subj_cbx";
            this.Subj_cbx.Size = new System.Drawing.Size(202, 25);
            this.Subj_cbx.TabIndex = 0;
            // 
            // SubName
            // 
            this.SubName.Text = "Subject Name";
            this.SubName.Width = 157;
            // 
            // scode
            // 
            this.scode.Text = "Code";
            // 
            // sid
            // 
            this.sid.Text = "ID";
            this.sid.Width = 0;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sid,
            this.scode,
            this.SubName});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(211, 262);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 283);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compulsory Subjects";
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_delete.Location = new System.Drawing.Point(515, 117);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(111, 27);
            this.Btn_delete.TabIndex = 15;
            this.Btn_delete.Text = "Remove";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(417, 117);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(94, 26);
            this.Btn_save.TabIndex = 16;
            this.Btn_save.Text = "Assign";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(337, 117);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(75, 27);
            this.Btn_new.TabIndex = 17;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 112;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Subj_cbx);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(325, 58);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 53);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Subject";
            // 
            // Short
            // 
            this.Short.Text = "Short";
            // 
            // code
            // 
            this.code.Text = "Code";
            this.code.Width = 62;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.code,
            this.st_subject,
            this.Short,
            this.Category,
            this.yr});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(462, 226);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // st_subject
            // 
            this.st_subject.Text = "Subject";
            this.st_subject.Width = 152;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(236, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 248);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assigned Subject";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(208, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All Subjects";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Subsidiary";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Principal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 55);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suggest Subjects to Load";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign student with Subjects";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 47);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.yearCbx);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(552, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(128, 53);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Year";
            // 
            // yearCbx
            // 
            this.yearCbx.FormattingEnabled = true;
            this.yearCbx.Items.AddRange(new object[] {
            "2017",
            "2016"});
            this.yearCbx.Location = new System.Drawing.Point(7, 22);
            this.yearCbx.Name = "yearCbx";
            this.yearCbx.Size = new System.Drawing.Size(116, 25);
            this.yearCbx.TabIndex = 0;
            // 
            // yr
            // 
            this.yr.Text = "Year";
            // 
            // SubjectsAssignAlevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectsAssignAlevel";
            this.Size = new System.Drawing.Size(718, 403);
            this.Load += new System.EventHandler(this.SubjectsAssignAlevel_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Subj_cbx;
        private System.Windows.Forms.ColumnHeader SubName;
        private System.Windows.Forms.ColumnHeader scode;
        private System.Windows.Forms.ColumnHeader sid;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColumnHeader Short;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader st_subject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader yr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox yearCbx;
    }
}

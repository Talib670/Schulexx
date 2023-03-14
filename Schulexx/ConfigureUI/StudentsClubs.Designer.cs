namespace Schulexx.ConfigureUI
{
    partial class StudentsClubs
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClubNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ctype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cleader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBox_ctype = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.activity_txt = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.patron_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_cname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.leader_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.listView1);
            this.groupBox10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(456, 27);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(353, 329);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "List Of Clubs";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ClubNames,
            this.Ctype,
            this.cleader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 307);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.DisplayIndex = 3;
            this.ID.Text = "ID";
            // 
            // ClubNames
            // 
            this.ClubNames.DisplayIndex = 0;
            this.ClubNames.Text = "Club Name";
            this.ClubNames.Width = 119;
            // 
            // Ctype
            // 
            this.Ctype.DisplayIndex = 1;
            this.Ctype.Text = "Club type";
            this.Ctype.Width = 114;
            // 
            // cleader
            // 
            this.cleader.DisplayIndex = 2;
            this.cleader.Text = "Club Leaders";
            this.cleader.Width = 127;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_delete);
            this.groupBox9.Controls.Add(this.btn_save);
            this.groupBox9.Controls.Add(this.btn_new);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(188, 356);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(263, 45);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(174, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 27);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(90, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(78, 27);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_new.Location = new System.Drawing.Point(6, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(78, 27);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 303);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(220, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 66);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "status";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactive";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Active";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cBox_ctype);
            this.groupBox4.Location = new System.Drawing.Point(220, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Club type";
            // 
            // cBox_ctype
            // 
            this.cBox_ctype.FormattingEnabled = true;
            this.cBox_ctype.Items.AddRange(new object[] {
            "Debating club",
            "ICT club",
            "Gospel club",
            "Mathematics",
            "Science club",
            "Scounts Club",
            "Music club"});
            this.cBox_ctype.Location = new System.Drawing.Point(7, 18);
            this.cBox_ctype.Name = "cBox_ctype";
            this.cBox_ctype.Size = new System.Drawing.Size(187, 25);
            this.cBox_ctype.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.activity_txt);
            this.groupBox8.Location = new System.Drawing.Point(6, 195);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(422, 96);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Club Activities";
            // 
            // activity_txt
            // 
            this.activity_txt.Location = new System.Drawing.Point(6, 20);
            this.activity_txt.Multiline = true;
            this.activity_txt.Name = "activity_txt";
            this.activity_txt.Size = new System.Drawing.Size(410, 70);
            this.activity_txt.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.patron_cbx);
            this.groupBox7.Location = new System.Drawing.Point(6, 128);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 47);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Patron";
            // 
            // patron_cbx
            // 
            this.patron_cbx.FormattingEnabled = true;
            this.patron_cbx.Location = new System.Drawing.Point(7, 18);
            this.patron_cbx.Name = "patron_cbx";
            this.patron_cbx.Size = new System.Drawing.Size(187, 25);
            this.patron_cbx.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_cname);
            this.groupBox6.Location = new System.Drawing.Point(6, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(414, 47);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Name";
            // 
            // textBox_cname
            // 
            this.textBox_cname.Location = new System.Drawing.Point(6, 18);
            this.textBox_cname.Name = "textBox_cname";
            this.textBox_cname.Size = new System.Drawing.Size(402, 23);
            this.textBox_cname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leader_cbx);
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Club Leader";
            // 
            // leader_cbx
            // 
            this.leader_cbx.FormattingEnabled = true;
            this.leader_cbx.Location = new System.Drawing.Point(7, 18);
            this.leader_cbx.Name = "leader_cbx";
            this.leader_cbx.Size = new System.Drawing.Size(187, 25);
            this.leader_cbx.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 34);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Managing Students Clubs";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(781, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsClubs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Clubs";
            this.Load += new System.EventHandler(this.StudentsClubs_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ClubNames;
        private System.Windows.Forms.ColumnHeader Ctype;
        private System.Windows.Forms.ColumnHeader cleader;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cBox_ctype;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox patron_cbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox leader_cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox activity_txt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_cname;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button button1;
    }
}
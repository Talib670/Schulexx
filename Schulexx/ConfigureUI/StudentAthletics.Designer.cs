namespace Schulexx.ConfigureUI
{
    partial class StudentAthletics
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
            this.SportName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sp_manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.patron_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Spname_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.listView1);
            this.groupBox10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(231, 41);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(278, 346);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "List Of Clubs";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.SportName,
            this.Sp_manager});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 324);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // SportName
            // 
            this.SportName.Text = "Name Of the sport";
            this.SportName.Width = 146;
            // 
            // Sp_manager
            // 
            this.Sp_manager.Text = "Manager";
            this.Sp_manager.Width = 127;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(8, 306);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(206, 81);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(103, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(103, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 228);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(6, 119);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sport Designed for";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Both";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Boys";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Girls";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.patron_cbx);
            this.groupBox7.Location = new System.Drawing.Point(4, 66);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 47);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Patron";
            // 
            // patron_cbx
            // 
            this.patron_cbx.FormattingEnabled = true;
            this.patron_cbx.Location = new System.Drawing.Point(5, 16);
            this.patron_cbx.Name = "patron_cbx";
            this.patron_cbx.Size = new System.Drawing.Size(187, 25);
            this.patron_cbx.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Spname_txt);
            this.groupBox6.Location = new System.Drawing.Point(6, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 47);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Name of the sport";
            // 
            // Spname_txt
            // 
            this.Spname_txt.Location = new System.Drawing.Point(6, 19);
            this.Spname_txt.Name = "Spname_txt";
            this.Spname_txt.Size = new System.Drawing.Size(186, 23);
            this.Spname_txt.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 34);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Managing Athletics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 28);
            this.panel1.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(491, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 36);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StudentAthletics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAthletics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Athletics";
            this.Load += new System.EventHandler(this.StudentAthletics_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SportName;
        private System.Windows.Forms.ColumnHeader Sp_manager;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox patron_cbx;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox Spname_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;

    }
}
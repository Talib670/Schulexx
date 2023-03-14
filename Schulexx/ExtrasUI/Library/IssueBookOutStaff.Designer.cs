﻿namespace Schulexx.LibraryUI
{
    partial class IssueBookOutStaff
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.IssueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SysNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bknme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tkby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.issue_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.return_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.BookIssueBtn = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Book_copyCbx = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BookTitleCbx = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Book_subCbx = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.levelcbx = new System.Windows.Forms.ComboBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.personnelCbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1046, 503);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ISSUING A BOOK OUT";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listView4);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(7, 212);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1033, 283);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Issued Books Details";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IssueID,
            this.SysNumber,
            this.bknme,
            this.autho,
            this.pub,
            this.tkby,
            this.issue_date,
            this.return_date});
            this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(3, 19);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1027, 261);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // IssueID
            // 
            this.IssueID.Text = "IssueID";
            this.IssueID.Width = 0;
            // 
            // SysNumber
            // 
            this.SysNumber.Text = "Book System Number";
            this.SysNumber.Width = 189;
            // 
            // bknme
            // 
            this.bknme.Text = "Book Name";
            this.bknme.Width = 175;
            // 
            // autho
            // 
            this.autho.Text = "Author";
            this.autho.Width = 184;
            // 
            // pub
            // 
            this.pub.Text = "Publisher";
            this.pub.Width = 137;
            // 
            // tkby
            // 
            this.tkby.Text = "Taken By";
            this.tkby.Width = 109;
            // 
            // issue_date
            // 
            this.issue_date.Text = "Issue Date";
            this.issue_date.Width = 111;
            // 
            // return_date
            // 
            this.return_date.Text = "Return Date";
            this.return_date.Width = 132;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.groupBox14);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox13);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox16);
            this.groupBox5.Controls.Add(this.groupBox15);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1031, 172);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details Of Personnel Taking the book";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.BookIssueBtn);
            this.groupBox10.Controls.Add(this.Btn_new);
            this.groupBox10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(729, 34);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(139, 112);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Action";
            // 
            // BookIssueBtn
            // 
            this.BookIssueBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.BookIssueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIssueBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssueBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookIssueBtn.Location = new System.Drawing.Point(8, 32);
            this.BookIssueBtn.Name = "BookIssueBtn";
            this.BookIssueBtn.Size = new System.Drawing.Size(117, 34);
            this.BookIssueBtn.TabIndex = 4;
            this.BookIssueBtn.Text = "Issue Book";
            this.BookIssueBtn.UseVisualStyleBackColor = false;
            this.BookIssueBtn.Click += new System.EventHandler(this.BookIssueBtn_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(8, 71);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(120, 31);
            this.Btn_new.TabIndex = 4;
            this.Btn_new.Text = "Refresh";
            this.Btn_new.UseVisualStyleBackColor = false;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label12);
            this.groupBox14.Controls.Add(this.label10);
            this.groupBox14.Controls.Add(this.label9);
            this.groupBox14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(875, 13);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(150, 147);
            this.groupBox14.TabIndex = 6;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Book Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Publisher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Book Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Book_copyCbx);
            this.groupBox2.Location = new System.Drawing.Point(187, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 61);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a copy";
            // 
            // Book_copyCbx
            // 
            this.Book_copyCbx.FormattingEnabled = true;
            this.Book_copyCbx.Location = new System.Drawing.Point(6, 26);
            this.Book_copyCbx.Name = "Book_copyCbx";
            this.Book_copyCbx.Size = new System.Drawing.Size(180, 25);
            this.Book_copyCbx.TabIndex = 2;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BookTitleCbx);
            this.groupBox13.Location = new System.Drawing.Point(6, 97);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(175, 61);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Book Title";
            // 
            // BookTitleCbx
            // 
            this.BookTitleCbx.FormattingEnabled = true;
            this.BookTitleCbx.Location = new System.Drawing.Point(6, 22);
            this.BookTitleCbx.Name = "BookTitleCbx";
            this.BookTitleCbx.Size = new System.Drawing.Size(163, 25);
            this.BookTitleCbx.TabIndex = 2;
            this.BookTitleCbx.SelectedIndexChanged += new System.EventHandler(this.BookTitleCbx_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Book_subCbx);
            this.groupBox3.Location = new System.Drawing.Point(436, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Subject";
            // 
            // Book_subCbx
            // 
            this.Book_subCbx.FormattingEnabled = true;
            this.Book_subCbx.Location = new System.Drawing.Point(6, 25);
            this.Book_subCbx.Name = "Book_subCbx";
            this.Book_subCbx.Size = new System.Drawing.Size(257, 25);
            this.Book_subCbx.TabIndex = 2;
            this.Book_subCbx.SelectedIndexChanged += new System.EventHandler(this.Book_subCbx_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.levelcbx);
            this.groupBox8.Location = new System.Drawing.Point(235, 32);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(195, 62);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Select Level";
            // 
            // levelcbx
            // 
            this.levelcbx.FormattingEnabled = true;
            this.levelcbx.Location = new System.Drawing.Point(6, 25);
            this.levelcbx.Name = "levelcbx";
            this.levelcbx.Size = new System.Drawing.Size(182, 25);
            this.levelcbx.TabIndex = 2;
            this.levelcbx.SelectedIndexChanged += new System.EventHandler(this.levelcbx_SelectedIndexChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.dateTimePicker3);
            this.groupBox16.Location = new System.Drawing.Point(557, 96);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(165, 63);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Date Of Return";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(6, 25);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.dateTimePicker1);
            this.groupBox15.Location = new System.Drawing.Point(391, 97);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(160, 63);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Date Of Issue";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.personnelCbx);
            this.groupBox7.Location = new System.Drawing.Point(6, 34);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(220, 61);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select Staff";
            // 
            // personnelCbx
            // 
            this.personnelCbx.FormattingEnabled = true;
            this.personnelCbx.Location = new System.Drawing.Point(7, 23);
            this.personnelCbx.Name = "personnelCbx";
            this.personnelCbx.Size = new System.Drawing.Size(199, 25);
            this.personnelCbx.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(319, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 34);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Borrowing a Book from  the Library";
            // 
            // IssueBookOutStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "IssueBookOutStaff";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.IssueBookOutStaff_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader IssueID;
        private System.Windows.Forms.ColumnHeader SysNumber;
        private System.Windows.Forms.ColumnHeader bknme;
        private System.Windows.Forms.ColumnHeader autho;
        private System.Windows.Forms.ColumnHeader pub;
        private System.Windows.Forms.ColumnHeader tkby;
        private System.Windows.Forms.ColumnHeader issue_date;
        private System.Windows.Forms.ColumnHeader return_date;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button BookIssueBtn;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox BookTitleCbx;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox levelcbx;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox personnelCbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Book_copyCbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Book_subCbx;
    }
}

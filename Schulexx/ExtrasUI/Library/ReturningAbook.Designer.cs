namespace Schulexx.LibraryUI
{
    partial class ReturningAbook
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
            this.RetunBookBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ReturnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BkNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookNamez = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BkNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datetaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Booktakenby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.personnelCbx = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // RetunBookBtn
            // 
            this.RetunBookBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.RetunBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetunBookBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetunBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RetunBookBtn.Location = new System.Drawing.Point(930, 43);
            this.RetunBookBtn.Name = "RetunBookBtn";
            this.RetunBookBtn.Size = new System.Drawing.Size(132, 31);
            this.RetunBookBtn.TabIndex = 10;
            this.RetunBookBtn.Text = "Return Book";
            this.RetunBookBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(559, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 396);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Return books";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReturnID,
            this.BkNumber,
            this.BookNamez,
            this.BookSubject,
            this.DateReturned});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(525, 374);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ReturnID
            // 
            this.ReturnID.Text = "ReturnID";
            this.ReturnID.Width = 0;
            // 
            // BkNumber
            // 
            this.BkNumber.Text = "Book Number";
            this.BkNumber.Width = 123;
            // 
            // BookNamez
            // 
            this.BookNamez.Text = "Book Name";
            this.BookNamez.Width = 154;
            // 
            // BookSubject
            // 
            this.BookSubject.Text = "Subject";
            this.BookSubject.Width = 129;
            // 
            // DateReturned
            // 
            this.DateReturned.Text = "Date Returned";
            this.DateReturned.Width = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(300, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 34);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(83, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Returning a Book in the Library";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 464);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Books Hired out";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.BkNo,
            this.BookNames,
            this.datetaken,
            this.Booktakenby});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 442);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ReturnID";
            this.ID.Width = 0;
            // 
            // BkNo
            // 
            this.BkNo.Text = "Book Number";
            this.BkNo.Width = 114;
            // 
            // BookNames
            // 
            this.BookNames.Text = "Book Name";
            this.BookNames.Width = 144;
            // 
            // datetaken
            // 
            this.datetaken.Text = "Date Taken";
            this.datetaken.Width = 120;
            // 
            // Booktakenby
            // 
            this.Booktakenby.Text = "Taken by";
            this.Booktakenby.Width = 136;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(562, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(525, 62);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(337, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(337, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.personnelCbx);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 51);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Personnel Type";
            // 
            // personnelCbx
            // 
            this.personnelCbx.FormattingEnabled = true;
            this.personnelCbx.Items.AddRange(new object[] {
            "Student",
            "Staff"});
            this.personnelCbx.Location = new System.Drawing.Point(7, 20);
            this.personnelCbx.Name = "personnelCbx";
            this.personnelCbx.Size = new System.Drawing.Size(136, 25);
            this.personnelCbx.TabIndex = 0;
            this.personnelCbx.SelectedIndexChanged += new System.EventHandler(this.personnelCbx_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(186, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(222, 51);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search for a book";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 23);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dateTimePicker1);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(702, 32);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(222, 51);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select Date of Return";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ReturningAbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RetunBookBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "ReturningAbook";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.ReturningAbook_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RetunBookBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ReturnID;
        private System.Windows.Forms.ColumnHeader BkNumber;
        private System.Windows.Forms.ColumnHeader BookSubject;
        private System.Windows.Forms.ColumnHeader DateReturned;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader BkNo;
        private System.Windows.Forms.ColumnHeader BookNames;
        private System.Windows.Forms.ColumnHeader datetaken;
        private System.Windows.Forms.ColumnHeader Booktakenby;
        private System.Windows.Forms.ColumnHeader BookNamez;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox personnelCbx;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

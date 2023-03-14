namespace Schulexx.Controls
{
    partial class BookSearch
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
            this.Btn_Bkdetails = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.BookNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bpublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bk_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Bkdetails
            // 
            this.Btn_Bkdetails.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_Bkdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Bkdetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Bkdetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Bkdetails.Location = new System.Drawing.Point(670, 81);
            this.Btn_Bkdetails.Name = "Btn_Bkdetails";
            this.Btn_Bkdetails.Size = new System.Drawing.Size(189, 32);
            this.Btn_Bkdetails.TabIndex = 11;
            this.Btn_Bkdetails.Text = "View Book Details";
            this.Btn_Bkdetails.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(751, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 12;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(383, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 17);
            this.label29.TabIndex = 10;
            this.label29.Text = "Search  here";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(480, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(249, 20);
            this.textBox5.TabIndex = 9;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Book Name",
            "Author",
            "Publisher",
            "Book ID",
            "Category"});
            this.comboBox9.Location = new System.Drawing.Point(146, 52);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(230, 21);
            this.comboBox9.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(24, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 17);
            this.label28.TabIndex = 7;
            this.label28.Text = "Search book By";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.listView3);
            this.groupBox12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(24, 111);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1045, 400);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "List Of books";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookNo,
            this.Book_Name,
            this.B_author,
            this.Bpublisher,
            this.Level,
            this.Subject,
            this.Bk_Status});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(3, 19);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1039, 378);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // BookNo
            // 
            this.BookNo.Text = "BooK Number";
            this.BookNo.Width = 106;
            // 
            // Book_Name
            // 
            this.Book_Name.Text = "Book Name";
            this.Book_Name.Width = 202;
            // 
            // B_author
            // 
            this.B_author.Text = "Author";
            this.B_author.Width = 177;
            // 
            // Bpublisher
            // 
            this.Bpublisher.Text = "Publisher";
            this.Bpublisher.Width = 160;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 144;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 122;
            // 
            // Bk_Status
            // 
            this.Bk_Status.Text = "Status";
            this.Bk_Status.Width = 131;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(336, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 34);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(83, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching for a Book in the Library";
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Bkdetails);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.groupBox12);
            this.Name = "BookSearch";
            this.Size = new System.Drawing.Size(1093, 563);
            this.groupBox12.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Bkdetails;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader BookNo;
        private System.Windows.Forms.ColumnHeader Book_Name;
        private System.Windows.Forms.ColumnHeader B_author;
        private System.Windows.Forms.ColumnHeader Bpublisher;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Bk_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

namespace Schulexx.LibraryUI
{
    partial class NewBook
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
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tcopies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SubjectCbx = new System.Windows.Forms.ComboBox();
            this.LevelCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PubTbx = new System.Windows.Forms.TextBox();
            this.AuthorTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BkDescrbx = new System.Windows.Forms.TextBox();
            this.BookNameTbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_NewCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(297, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adding New Book in the Library";
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_delete.Location = new System.Drawing.Point(350, 320);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(75, 29);
            this.Btn_delete.TabIndex = 6;
            this.Btn_delete.Text = "DELETE";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(271, 320);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 29);
            this.Btn_save.TabIndex = 7;
            this.Btn_save.Text = "SAVE";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(193, 320);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(75, 29);
            this.Btn_new.TabIndex = 8;
            this.Btn_new.Text = "REFRESH";
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(432, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 450);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookID,
            this.BookName,
            this.BookSubject,
            this.BookLevel,
            this.BookAuthor,
            this.Publisher,
            this.Tcopies});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(631, 428);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // BookID
            // 
            this.BookID.Text = "BookID";
            this.BookID.Width = 0;
            // 
            // BookName
            // 
            this.BookName.Text = "Book Name";
            this.BookName.Width = 127;
            // 
            // BookSubject
            // 
            this.BookSubject.Text = "Book subject";
            this.BookSubject.Width = 112;
            // 
            // BookLevel
            // 
            this.BookLevel.Text = "Level";
            this.BookLevel.Width = 95;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Text = "Author";
            this.BookAuthor.Width = 85;
            // 
            // Publisher
            // 
            this.Publisher.Text = "Publisher";
            this.Publisher.Width = 104;
            // 
            // Tcopies
            // 
            this.Tcopies.Text = "Total Copies";
            this.Tcopies.Width = 110;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SubjectCbx);
            this.groupBox3.Controls.Add(this.LevelCbx);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PubTbx);
            this.groupBox3.Controls.Add(this.AuthorTbx);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BkDescrbx);
            this.groupBox3.Controls.Add(this.BookNameTbx);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 257);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Details";
            // 
            // SubjectCbx
            // 
            this.SubjectCbx.FormattingEnabled = true;
            this.SubjectCbx.Location = new System.Drawing.Point(137, 23);
            this.SubjectCbx.Name = "SubjectCbx";
            this.SubjectCbx.Size = new System.Drawing.Size(159, 25);
            this.SubjectCbx.TabIndex = 2;
            // 
            // LevelCbx
            // 
            this.LevelCbx.FormattingEnabled = true;
            this.LevelCbx.Location = new System.Drawing.Point(137, 153);
            this.LevelCbx.Name = "LevelCbx";
            this.LevelCbx.Size = new System.Drawing.Size(159, 25);
            this.LevelCbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // PubTbx
            // 
            this.PubTbx.Location = new System.Drawing.Point(137, 121);
            this.PubTbx.Name = "PubTbx";
            this.PubTbx.Size = new System.Drawing.Size(159, 23);
            this.PubTbx.TabIndex = 1;
            // 
            // AuthorTbx
            // 
            this.AuthorTbx.Location = new System.Drawing.Point(137, 89);
            this.AuthorTbx.Name = "AuthorTbx";
            this.AuthorTbx.Size = new System.Drawing.Size(159, 23);
            this.AuthorTbx.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Book Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Level";
            // 
            // BkDescrbx
            // 
            this.BkDescrbx.Location = new System.Drawing.Point(137, 189);
            this.BkDescrbx.Multiline = true;
            this.BkDescrbx.Name = "BkDescrbx";
            this.BkDescrbx.Size = new System.Drawing.Size(245, 58);
            this.BkDescrbx.TabIndex = 1;
            // 
            // BookNameTbx
            // 
            this.BookNameTbx.Location = new System.Drawing.Point(137, 57);
            this.BookNameTbx.Name = "BookNameTbx";
            this.BookNameTbx.Size = new System.Drawing.Size(245, 23);
            this.BookNameTbx.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Brief Description";
            // 
            // Btn_NewCopy
            // 
            this.Btn_NewCopy.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_NewCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewCopy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_NewCopy.Location = new System.Drawing.Point(905, 19);
            this.Btn_NewCopy.Name = "Btn_NewCopy";
            this.Btn_NewCopy.Size = new System.Drawing.Size(161, 31);
            this.Btn_NewCopy.TabIndex = 9;
            this.Btn_NewCopy.Text = "Add New Copy";
            this.Btn_NewCopy.UseVisualStyleBackColor = false;
            this.Btn_NewCopy.Click += new System.EventHandler(this.Btn_NewCopy_Click);
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_NewCopy);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewBook";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.NewBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader BookSubject;
        private System.Windows.Forms.ColumnHeader BookLevel;
        private System.Windows.Forms.ColumnHeader BookAuthor;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.ColumnHeader Tcopies;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox SubjectCbx;
        private System.Windows.Forms.ComboBox LevelCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PubTbx;
        private System.Windows.Forms.TextBox AuthorTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BkDescrbx;
        private System.Windows.Forms.TextBox BookNameTbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_NewCopy;
    }
}

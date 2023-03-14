namespace Schulexx.Controls
{
    partial class OlevelMarks_sheet
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentAdmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AverageMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aggregates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalMarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.class_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(219, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(578, 40);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADDING COMMENTS TO STUDENTS PERFORMANCES (O LEVEL)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 464);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.StudentAdmn,
            this.StudentNames,
            this.AverageMark,
            this.Aggregates,
            this.TotalMarks,
            this.Position,
            this.Comment});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(714, 442);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // StudentAdmn
            // 
            this.StudentAdmn.Text = "Reg Number";
            this.StudentAdmn.Width = 133;
            // 
            // StudentNames
            // 
            this.StudentNames.Text = "Student Names";
            this.StudentNames.Width = 170;
            // 
            // AverageMark
            // 
            this.AverageMark.Text = "Average Mark";
            this.AverageMark.Width = 106;
            // 
            // Aggregates
            // 
            this.Aggregates.Text = "Aggregates in 8";
            this.Aggregates.Width = 125;
            // 
            // TotalMarks
            // 
            this.TotalMarks.Text = "Total Marks";
            this.TotalMarks.Width = 91;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 137;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(735, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 260);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COMMENTS";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Head Teacher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(164, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 32);
            this.button2.TabIndex = 38;
            this.button2.Text = "Update Comment";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding Comment";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 127);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Class Teacher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(164, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "Update Comment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 149);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adding Comment";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 127);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.class_cbx);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 44);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Class";
            // 
            // class_cbx
            // 
            this.class_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_cbx.FormattingEnabled = true;
            this.class_cbx.Location = new System.Drawing.Point(3, 19);
            this.class_cbx.Name = "class_cbx";
            this.class_cbx.Size = new System.Drawing.Size(125, 25);
            this.class_cbx.TabIndex = 0;
            // 
            // OlevelMarks_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox8);
            this.Name = "OlevelMarks_sheet";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.OlevelMarks_sheet_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox class_cbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader StudentAdmn;
        private System.Windows.Forms.ColumnHeader StudentNames;
        private System.Windows.Forms.ColumnHeader AverageMark;
        private System.Windows.Forms.ColumnHeader Aggregates;
        private System.Windows.Forms.ColumnHeader TotalMarks;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

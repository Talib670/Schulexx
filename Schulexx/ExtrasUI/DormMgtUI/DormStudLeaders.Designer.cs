namespace Schulexx.ExtrasUI.DormMgtUI
{
    partial class DormStudLeaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DormStudLeaders));
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.domitryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DormPatron = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CboStudent = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CboDormitory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Assistant";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.82593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.17407F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 308);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(296, 298);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.domitryName,
            this.DormPatron});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 21);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 272);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // domitryName
            // 
            this.domitryName.Text = "Dormitory Name";
            this.domitryName.Width = 191;
            // 
            // DormPatron
            // 
            this.DormPatron.Text = "Patron";
            this.DormPatron.Width = 244;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(247, 298);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dorm Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.30435F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.69565F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(237, 272);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CboDormitory);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(4, 63);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(229, 48);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Dormitory";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_delete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_save, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_new, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 231);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(231, 38);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_delete.Location = new System.Drawing.Point(154, 4);
            this.Btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(73, 30);
            this.Btn_delete.TabIndex = 1;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = false;
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(79, 4);
            this.Btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(67, 30);
            this.Btn_save.TabIndex = 1;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(4, 4);
            this.Btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(67, 30);
            this.Btn_new.TabIndex = 1;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CboStudent);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(4, 119);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(229, 52);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Patron";
            // 
            // CboStudent
            // 
            this.CboStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStudent.FormattingEnabled = true;
            this.CboStudent.Location = new System.Drawing.Point(4, 20);
            this.CboStudent.Margin = new System.Windows.Forms.Padding(4);
            this.CboStudent.Name = "CboStudent";
            this.CboStudent.Size = new System.Drawing.Size(221, 25);
            this.CboStudent.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leadership Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Head";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Dormitory Leaders";
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(518, 1);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 31);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.BtnClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(7);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTop.Size = new System.Drawing.Size(563, 33);
            this.pnlTop.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(231, 53);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(109, 47);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Year";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(118, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(110, 47);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Term";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 25);
            this.comboBox2.TabIndex = 0;
            // 
            // CboDormitory
            // 
            this.CboDormitory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboDormitory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDormitory.FormattingEnabled = true;
            this.CboDormitory.Location = new System.Drawing.Point(4, 20);
            this.CboDormitory.Margin = new System.Windows.Forms.Padding(4);
            this.CboDormitory.Name = "CboDormitory";
            this.CboDormitory.Size = new System.Drawing.Size(221, 25);
            this.CboDormitory.TabIndex = 0;
            // 
            // DormStudLeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(563, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DormStudLeaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DormStudLeaders";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader domitryName;
        private System.Windows.Forms.ColumnHeader DormPatron;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CboStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox CboDormitory;
    }
}
namespace Schulexx.ConfigureUI
{
    partial class AlevelPaperConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlevelPaperConfiguration));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnCbx = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DescTbx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.subjCbx = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(99, 4);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(87, 38);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.Location = new System.Drawing.Point(4, 4);
            this.Btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(83, 38);
            this.Btn_new.TabIndex = 3;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = true;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnCbx);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(150, 57);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paper Number";
            // 
            // pnCbx
            // 
            this.pnCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pnCbx.FormattingEnabled = true;
            this.pnCbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.pnCbx.Location = new System.Drawing.Point(4, 25);
            this.pnCbx.Margin = new System.Windows.Forms.Padding(4);
            this.pnCbx.Name = "pnCbx";
            this.pnCbx.Size = new System.Drawing.Size(128, 25);
            this.pnCbx.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DescTbx);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(4, 70);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(150, 123);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Description";
            // 
            // DescTbx
            // 
            this.DescTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescTbx.Location = new System.Drawing.Point(4, 21);
            this.DescTbx.Margin = new System.Windows.Forms.Padding(4);
            this.DescTbx.Multiline = true;
            this.DescTbx.Name = "DescTbx";
            this.DescTbx.Size = new System.Drawing.Size(142, 98);
            this.DescTbx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.subjCbx);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(162, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(272, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subject";
            // 
            // subjCbx
            // 
            this.subjCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjCbx.FormattingEnabled = true;
            this.subjCbx.Location = new System.Drawing.Point(8, 24);
            this.subjCbx.Margin = new System.Windows.Forms.Padding(4);
            this.subjCbx.Name = "subjCbx";
            this.subjCbx.Size = new System.Drawing.Size(256, 25);
            this.subjCbx.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView1);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(4, 230);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(442, 218);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Details";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.subj,
            this.pnumber,
            this.desc});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(4, 20);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 1;
            // 
            // subj
            // 
            this.subj.Text = "Subject";
            this.subj.Width = 116;
            // 
            // pnumber
            // 
            this.pnumber.Text = "Paper number";
            this.pnumber.Width = 171;
            // 
            // desc
            // 
            this.desc.Text = "Description";
            this.desc.Width = 190;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.BtnClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTop.Size = new System.Drawing.Size(450, 33);
            this.pnlTop.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A level subject Paper Configuration";
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(406, 1);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(43, 31);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 452);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.30137F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.69863F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.50254F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.49746F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 197);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_new, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SaveBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_delete, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(161, 69);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 46);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(194, 4);
            this.Btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(76, 38);
            this.Btn_delete.TabIndex = 3;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AlevelPaperConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(450, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlevelPaperConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AlevelPaperConfiguration_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox pnCbx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox DescTbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox subjCbx;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader subj;
        private System.Windows.Forms.ColumnHeader pnumber;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Btn_delete;
    }
}
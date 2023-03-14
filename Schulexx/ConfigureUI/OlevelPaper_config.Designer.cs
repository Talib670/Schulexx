namespace Schulexx.ConfigureUI
{
    partial class OlevelPaper_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlevelPaper_config));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.clnama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.DescTbx = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnCbx = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.subjCbx = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.classCbx = new System.Windows.Forms.ComboBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.Text = "Description";
            this.desc.Width = 190;
            // 
            // subj
            // 
            this.subj.Text = "Subject";
            this.subj.Width = 147;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.clnama,
            this.subj,
            this.pnumber,
            this.desc});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(4, 20);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(499, 315);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // clnama
            // 
            this.clnama.Text = "Class";
            this.clnama.Width = 66;
            // 
            // pnumber
            // 
            this.pnumber.Text = "Paper number";
            this.pnumber.Width = 104;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView1);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(4, 232);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(507, 339);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Details";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Green;
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(196, 4);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(95, 31);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.Green;
            this.Btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.ForeColor = System.Drawing.Color.White;
            this.Btn_save.Location = new System.Drawing.Point(100, 4);
            this.Btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(88, 31);
            this.Btn_save.TabIndex = 3;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.Green;
            this.Btn_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.ForeColor = System.Drawing.Color.White;
            this.Btn_new.Location = new System.Drawing.Point(4, 4);
            this.Btn_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(88, 31);
            this.Btn_new.TabIndex = 3;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // DescTbx
            // 
            this.DescTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescTbx.Location = new System.Drawing.Point(4, 20);
            this.DescTbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescTbx.Multiline = true;
            this.DescTbx.Name = "DescTbx";
            this.DescTbx.Size = new System.Drawing.Size(334, 49);
            this.DescTbx.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DescTbx);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(145, 74);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(342, 73);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Description";
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
            this.pnCbx.Location = new System.Drawing.Point(11, 21);
            this.pnCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCbx.Name = "pnCbx";
            this.pnCbx.Size = new System.Drawing.Size(117, 25);
            this.pnCbx.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnCbx);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(4, 74);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(133, 55);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paper Number";
            // 
            // subjCbx
            // 
            this.subjCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjCbx.FormattingEnabled = true;
            this.subjCbx.Location = new System.Drawing.Point(9, 29);
            this.subjCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjCbx.Name = "subjCbx";
            this.subjCbx.Size = new System.Drawing.Size(333, 25);
            this.subjCbx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.subjCbx);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(145, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(350, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subject";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(507, 220);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.classCbx);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(4, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(133, 62);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Class";
            // 
            // classCbx
            // 
            this.classCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCbx.FormattingEnabled = true;
            this.classCbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.classCbx.Location = new System.Drawing.Point(11, 30);
            this.classCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classCbx.Name = "classCbx";
            this.classCbx.Size = new System.Drawing.Size(117, 25);
            this.classCbx.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.BtnClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTop.Size = new System.Drawing.Size(515, 33);
            this.pnlTop.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "O level subject Paper Configuration";
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(471, 1);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(43, 31);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.92308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 650);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.45691F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.54308F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(499, 196);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_save, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_Delete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_new, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(144, 154);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(295, 39);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // OlevelPaper_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(515, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OlevelPaper_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.OlevelPaper_config_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader subj;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pnumber;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.TextBox DescTbx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox pnCbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox subjCbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox classCbx;
        private System.Windows.Forms.ColumnHeader clnama;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
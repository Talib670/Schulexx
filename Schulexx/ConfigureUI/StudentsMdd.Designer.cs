namespace Schulexx.ConfigureUI
{
    partial class StudentsMdd
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
            this.ch_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChoirName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patron = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chp_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chname_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chl_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox10.Location = new System.Drawing.Point(243, 29);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(275, 329);
            this.groupBox10.TabIndex = 17;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "List Of MDD choirs";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_id,
            this.ChoirName,
            this.Type,
            this.Patron});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(269, 307);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ch_id
            // 
            this.ch_id.Width = 0;
            // 
            // ChoirName
            // 
            this.ChoirName.Text = "Choir Name";
            this.ChoirName.Width = 101;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 65;
            // 
            // Patron
            // 
            this.Patron.Text = "Patron";
            this.Patron.Width = 101;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_delete);
            this.groupBox9.Controls.Add(this.btn_save);
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(12, 360);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(263, 45);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(174, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 27);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(90, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(78, 27);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 303);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(6, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Drama";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dance";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Music";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chp_cbx);
            this.groupBox7.Location = new System.Drawing.Point(6, 119);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 47);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Patron";
            // 
            // chp_cbx
            // 
            this.chp_cbx.FormattingEnabled = true;
            this.chp_cbx.Location = new System.Drawing.Point(5, 16);
            this.chp_cbx.Name = "chp_cbx";
            this.chp_cbx.Size = new System.Drawing.Size(187, 25);
            this.chp_cbx.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chname_txt);
            this.groupBox6.Location = new System.Drawing.Point(6, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 47);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Choir Name";
            // 
            // chname_txt
            // 
            this.chname_txt.Location = new System.Drawing.Point(6, 19);
            this.chname_txt.Name = "chname_txt";
            this.chname_txt.Size = new System.Drawing.Size(186, 23);
            this.chname_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chl_cbx);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choir Leader";
            // 
            // chl_cbx
            // 
            this.chl_cbx.FormattingEnabled = true;
            this.chl_cbx.Location = new System.Drawing.Point(7, 18);
            this.chl_cbx.Name = "chl_cbx";
            this.chl_cbx.Size = new System.Drawing.Size(187, 25);
            this.chl_cbx.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 34);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Dance and Drama";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(492, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentsMdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsMdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Music Dance and Drama";
            this.Load += new System.EventHandler(this.StudentsMdd_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader ChoirName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox chp_cbx;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox chname_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox chl_cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Patron;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ColumnHeader ch_id;
        private System.Windows.Forms.Button button2;
    }
}
namespace Schulexx.Controls
{
    partial class SchoolFees
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.level_cbx = new System.Windows.Forms.ComboBox();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.AmountTbx = new System.Windows.Forms.TextBox();
            this.Btn_new = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.PaytypeCbx = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.FeesCbx = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Student_combo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ClassCbx = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TermCbx = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FeesID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Feetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatePaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.payMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(305, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Fees Payment Entry";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(925, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 160);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Picture";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.Btn_delete);
            this.groupBox2.Controls.Add(this.Btn_save);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.Btn_new);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(913, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Details";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.level_cbx);
            this.groupBox6.Location = new System.Drawing.Point(385, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 51);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select Level";
            // 
            // level_cbx
            // 
            this.level_cbx.FormattingEnabled = true;
            this.level_cbx.Location = new System.Drawing.Point(6, 20);
            this.level_cbx.Name = "level_cbx";
            this.level_cbx.Size = new System.Drawing.Size(155, 25);
            this.level_cbx.TabIndex = 15;
            this.level_cbx.SelectedIndexChanged += new System.EventHandler(this.level_cbx_SelectedIndexChanged);
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_delete.Location = new System.Drawing.Point(808, 123);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(75, 32);
            this.Btn_delete.TabIndex = 16;
            this.Btn_delete.Text = "DELETE";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(707, 123);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(95, 32);
            this.Btn_save.TabIndex = 16;
            this.Btn_save.Text = "SAVE";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.AmountTbx);
            this.groupBox10.Location = new System.Drawing.Point(561, 66);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(165, 51);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Amount Paid";
            // 
            // AmountTbx
            // 
            this.AmountTbx.Location = new System.Drawing.Point(4, 18);
            this.AmountTbx.Name = "AmountTbx";
            this.AmountTbx.Size = new System.Drawing.Size(155, 23);
            this.AmountTbx.TabIndex = 7;
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(626, 123);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(75, 32);
            this.Btn_new.TabIndex = 15;
            this.Btn_new.Text = "NEW";
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dateTimePicker1);
            this.groupBox11.Location = new System.Drawing.Point(731, 64);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(176, 51);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Date Paid";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.PaytypeCbx);
            this.groupBox9.Location = new System.Drawing.Point(385, 68);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(170, 51);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Payment Type";
            // 
            // PaytypeCbx
            // 
            this.PaytypeCbx.FormattingEnabled = true;
            this.PaytypeCbx.Items.AddRange(new object[] {
            "Bank",
            "Cash",
            "Eft"});
            this.PaytypeCbx.Location = new System.Drawing.Point(6, 20);
            this.PaytypeCbx.Name = "PaytypeCbx";
            this.PaytypeCbx.Size = new System.Drawing.Size(155, 25);
            this.PaytypeCbx.TabIndex = 15;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.FeesCbx);
            this.groupBox8.Location = new System.Drawing.Point(197, 69);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(182, 51);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Fees Type";
            // 
            // FeesCbx
            // 
            this.FeesCbx.FormattingEnabled = true;
            this.FeesCbx.Location = new System.Drawing.Point(6, 20);
            this.FeesCbx.Name = "FeesCbx";
            this.FeesCbx.Size = new System.Drawing.Size(171, 25);
            this.FeesCbx.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Student_combo);
            this.groupBox7.Location = new System.Drawing.Point(731, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(176, 51);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select Student";
            // 
            // Student_combo
            // 
            this.Student_combo.FormattingEnabled = true;
            this.Student_combo.Location = new System.Drawing.Point(6, 20);
            this.Student_combo.Name = "Student_combo";
            this.Student_combo.Size = new System.Drawing.Size(155, 25);
            this.Student_combo.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ClassCbx);
            this.groupBox5.Location = new System.Drawing.Point(562, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 51);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Class";
            // 
            // ClassCbx
            // 
            this.ClassCbx.FormattingEnabled = true;
            this.ClassCbx.Location = new System.Drawing.Point(6, 20);
            this.ClassCbx.Name = "ClassCbx";
            this.ClassCbx.Size = new System.Drawing.Size(155, 25);
            this.ClassCbx.TabIndex = 15;
            this.ClassCbx.SelectedIndexChanged += new System.EventHandler(this.ClassCbx_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TermCbx);
            this.groupBox4.Location = new System.Drawing.Point(197, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 51);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Term";
            // 
            // TermCbx
            // 
            this.TermCbx.FormattingEnabled = true;
            this.TermCbx.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.TermCbx.Location = new System.Drawing.Point(6, 20);
            this.TermCbx.Name = "TermCbx";
            this.TermCbx.Size = new System.Drawing.Size(170, 25);
            this.TermCbx.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "2016";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Running Session";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.listView1);
            this.groupBox12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(4, 233);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1073, 316);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "School Fess Payment Details";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FeesID,
            this.StReg,
            this.stName,
            this.Term,
            this.Class,
            this.Feetype,
            this.Paid,
            this.DatePaid,
            this.Balance,
            this.payMode});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1067, 294);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // FeesID
            // 
            this.FeesID.Text = "FeesID";
            this.FeesID.Width = 0;
            // 
            // StReg
            // 
            this.StReg.Text = "Student Reg";
            this.StReg.Width = 103;
            // 
            // stName
            // 
            this.stName.Text = "Student Names";
            this.stName.Width = 162;
            // 
            // Term
            // 
            this.Term.Text = "Term";
            this.Term.Width = 108;
            // 
            // Class
            // 
            this.Class.Text = "Class";
            this.Class.Width = 83;
            // 
            // Feetype
            // 
            this.Feetype.Text = "Fee Type";
            this.Feetype.Width = 109;
            // 
            // Paid
            // 
            this.Paid.Text = "Amount Paid";
            this.Paid.Width = 172;
            // 
            // DatePaid
            // 
            this.DatePaid.Text = "DatePaid";
            this.DatePaid.Width = 107;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            this.Balance.Width = 104;
            // 
            // payMode
            // 
            this.payMode.Text = "Payment Mode";
            this.payMode.Width = 127;
            // 
            // SchoolFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SchoolFees";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.SchoolFees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox level_cbx;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox AmountTbx;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox PaytypeCbx;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox FeesCbx;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox Student_combo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox ClassCbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox TermCbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FeesID;
        private System.Windows.Forms.ColumnHeader stName;
        private System.Windows.Forms.ColumnHeader StReg;
        private System.Windows.Forms.ColumnHeader Term;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Feetype;
        private System.Windows.Forms.ColumnHeader Paid;
        private System.Windows.Forms.ColumnHeader DatePaid;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader payMode;
        private System.Windows.Forms.Button Btn_delete;
    }
}

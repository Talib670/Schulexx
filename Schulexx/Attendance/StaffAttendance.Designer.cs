namespace Schulexx.AttendanceUI
{
    partial class StaffAttendance
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
            this.AsStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AbsentRbtn = new System.Windows.Forms.RadioButton();
            this.Btn_save = new System.Windows.Forms.Button();
            this.PresentRbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Rdsc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StfID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StfNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StaffTypeCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsStatus
            // 
            this.AsStatus.Text = "Attendance Status";
            this.AsStatus.Width = 149;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 115;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(463, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 338);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.StudentNames,
            this.Gender,
            this.Adate,
            this.AsStatus});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(597, 316);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // StudentNames
            // 
            this.StudentNames.Text = "Student Names";
            this.StudentNames.Width = 193;
            // 
            // Adate
            // 
            this.Adate.Text = "Date";
            this.Adate.Width = 138;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(469, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 93);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AbsentRbtn);
            this.groupBox6.Controls.Add(this.Btn_save);
            this.groupBox6.Controls.Add(this.PresentRbtn);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(579, 69);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Attendance status";
            // 
            // AbsentRbtn
            // 
            this.AbsentRbtn.AutoSize = true;
            this.AbsentRbtn.Location = new System.Drawing.Point(94, 32);
            this.AbsentRbtn.Name = "AbsentRbtn";
            this.AbsentRbtn.Size = new System.Drawing.Size(71, 20);
            this.AbsentRbtn.TabIndex = 0;
            this.AbsentRbtn.TabStop = true;
            this.AbsentRbtn.Text = "Absent";
            this.AbsentRbtn.UseVisualStyleBackColor = true;
            this.AbsentRbtn.Click += new System.EventHandler(this.AbsentRbtn_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(181, 27);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(111, 30);
            this.Btn_save.TabIndex = 50;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // PresentRbtn
            // 
            this.PresentRbtn.AutoSize = true;
            this.PresentRbtn.Location = new System.Drawing.Point(16, 32);
            this.PresentRbtn.Name = "PresentRbtn";
            this.PresentRbtn.Size = new System.Drawing.Size(72, 20);
            this.PresentRbtn.TabIndex = 0;
            this.PresentRbtn.TabStop = true;
            this.PresentRbtn.Text = "Present";
            this.PresentRbtn.UseVisualStyleBackColor = true;
            this.PresentRbtn.Click += new System.EventHandler(this.PresentRbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(369, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Manage Staff  attendances";
            // 
            // Rdsc
            // 
            this.Rdsc.Text = "Residence";
            this.Rdsc.Width = 137;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 438);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Class Listing";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StfID,
            this.StaffNumber,
            this.StfNames,
            this.Rdsc});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 416);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // StfID
            // 
            this.StfID.Text = "StdID";
            this.StfID.Width = 0;
            // 
            // StaffNumber
            // 
            this.StaffNumber.Text = "Staff Number";
            this.StaffNumber.Width = 124;
            // 
            // StfNames
            // 
            this.StfNames.Text = "Names";
            this.StfNames.Width = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Date Of Attendance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(427, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 23);
            this.dateTimePicker1.TabIndex = 58;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // StaffTypeCbx
            // 
            this.StaffTypeCbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffTypeCbx.FormattingEnabled = true;
            this.StaffTypeCbx.Items.AddRange(new object[] {
            "Teaching Staff",
            "Non Teaching Staff"});
            this.StaffTypeCbx.Location = new System.Drawing.Point(106, 64);
            this.StaffTypeCbx.Name = "StaffTypeCbx";
            this.StaffTypeCbx.Size = new System.Drawing.Size(152, 25);
            this.StaffTypeCbx.TabIndex = 64;
            this.StaffTypeCbx.SelectedIndexChanged += new System.EventHandler(this.StaffTypeCbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Staff Type";
            // 
            // StaffAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StaffTypeCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "StaffAttendance";
            this.Size = new System.Drawing.Size(1093, 563);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader AsStatus;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader StudentNames;
        private System.Windows.Forms.ColumnHeader Adate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton AbsentRbtn;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.RadioButton PresentRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Rdsc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader StfID;
        private System.Windows.Forms.ColumnHeader StaffNumber;
        private System.Windows.Forms.ColumnHeader StfNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox StaffTypeCbx;
        private System.Windows.Forms.Label label3;

    }
}

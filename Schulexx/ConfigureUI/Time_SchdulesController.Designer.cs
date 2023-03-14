namespace Schulexx.ConfigureUI
{
    partial class Time_SchdulesController
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SchTbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PmRbtn = new System.Windows.Forms.RadioButton();
            this.AmRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SchTbx);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Name";
            // 
            // SchTbx
            // 
            this.SchTbx.Location = new System.Drawing.Point(7, 23);
            this.SchTbx.Name = "SchTbx";
            this.SchTbx.Size = new System.Drawing.Size(222, 23);
            this.SchTbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PmRbtn);
            this.groupBox2.Controls.Add(this.AmRbtn);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(254, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Mode";
            // 
            // PmRbtn
            // 
            this.PmRbtn.AutoSize = true;
            this.PmRbtn.Location = new System.Drawing.Point(82, 24);
            this.PmRbtn.Name = "PmRbtn";
            this.PmRbtn.Size = new System.Drawing.Size(45, 21);
            this.PmRbtn.TabIndex = 0;
            this.PmRbtn.TabStop = true;
            this.PmRbtn.Text = "PM";
            this.PmRbtn.UseVisualStyleBackColor = true;
            this.PmRbtn.Click += new System.EventHandler(this.Pm_Click);
            // 
            // AmRbtn
            // 
            this.AmRbtn.AutoSize = true;
            this.AmRbtn.Location = new System.Drawing.Point(17, 26);
            this.AmRbtn.Name = "AmRbtn";
            this.AmRbtn.Size = new System.Drawing.Size(46, 21);
            this.AmRbtn.TabIndex = 0;
            this.AmRbtn.TabStop = true;
            this.AmRbtn.Text = "AM";
            this.AmRbtn.UseVisualStyleBackColor = true;
            this.AmRbtn.Click += new System.EventHandler(this.Am_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(12, 97);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(347, 100);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Time Range";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dateTimePicker2);
            this.groupBox10.Location = new System.Drawing.Point(169, 22);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(151, 57);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "End Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.Value = new System.DateTime(2016, 9, 12, 12, 55, 0, 0);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dateTimePicker1);
            this.groupBox9.Location = new System.Drawing.Point(6, 22);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(157, 57);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Start Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2016, 9, 12, 12, 55, 0, 0);
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_New.Location = new System.Drawing.Point(365, 106);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(133, 28);
            this.Btn_New.TabIndex = 3;
            this.Btn_New.Text = "Add New";
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(365, 135);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(133, 28);
            this.Btn_save.TabIndex = 3;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_delete.Location = new System.Drawing.Point(365, 169);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(133, 28);
            this.Btn_delete.TabIndex = 3;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 161);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedules information";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.SchName,
            this.Stime,
            this.Etime});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(476, 139);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // SchName
            // 
            this.SchName.Text = "Schedule Name";
            this.SchName.Width = 216;
            // 
            // Stime
            // 
            this.Stime.Text = "Start Time";
            this.Stime.Width = 141;
            // 
            // Etime
            // 
            this.Etime.Text = "End time";
            this.Etime.Width = 117;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(466, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Time_SchdulesController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Time_SchdulesController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Time_SchdulesController_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SchTbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PmRbtn;
        private System.Windows.Forms.RadioButton AmRbtn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader SchName;
        private System.Windows.Forms.ColumnHeader Stime;
        private System.Windows.Forms.ColumnHeader Etime;
        private System.Windows.Forms.Button button1;
    }
}
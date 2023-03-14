namespace Schulexx.Controls
{
    partial class ViewEditteachers
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConstraitBtn = new System.Windows.Forms.Button();
            this.BtnAsgnSub = new System.Windows.Forms.Button();
            this.BtnAsgnStud = new System.Windows.Forms.Button();
            this.BtnAsgnCls = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TeacherTbx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.staffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StfName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaritalStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phoneddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.District = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Village = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nationality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(267, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 35);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(79, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Teaching Staff";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConstraitBtn);
            this.groupBox2.Controls.Add(this.BtnAsgnSub);
            this.groupBox2.Controls.Add(this.BtnAsgnStud);
            this.groupBox2.Controls.Add(this.BtnAsgnCls);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ConstraitBtn
            // 
            this.ConstraitBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ConstraitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConstraitBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstraitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConstraitBtn.Location = new System.Drawing.Point(892, 23);
            this.ConstraitBtn.Name = "ConstraitBtn";
            this.ConstraitBtn.Size = new System.Drawing.Size(164, 29);
            this.ConstraitBtn.TabIndex = 1;
            this.ConstraitBtn.Text = "Set Constraits";
            this.ConstraitBtn.UseVisualStyleBackColor = false;
            // 
            // BtnAsgnSub
            // 
            this.BtnAsgnSub.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAsgnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsgnSub.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsgnSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAsgnSub.Location = new System.Drawing.Point(754, 23);
            this.BtnAsgnSub.Name = "BtnAsgnSub";
            this.BtnAsgnSub.Size = new System.Drawing.Size(132, 29);
            this.BtnAsgnSub.TabIndex = 1;
            this.BtnAsgnSub.Text = "Assign Subjects";
            this.BtnAsgnSub.UseVisualStyleBackColor = false;
            // 
            // BtnAsgnStud
            // 
            this.BtnAsgnStud.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAsgnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsgnStud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsgnStud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAsgnStud.Location = new System.Drawing.Point(502, 23);
            this.BtnAsgnStud.Name = "BtnAsgnStud";
            this.BtnAsgnStud.Size = new System.Drawing.Size(122, 29);
            this.BtnAsgnStud.TabIndex = 1;
            this.BtnAsgnStud.Text = "Assign Student";
            this.BtnAsgnStud.UseVisualStyleBackColor = false;
            // 
            // BtnAsgnCls
            // 
            this.BtnAsgnCls.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAsgnCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsgnCls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsgnCls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAsgnCls.Location = new System.Drawing.Point(630, 23);
            this.BtnAsgnCls.Name = "BtnAsgnCls";
            this.BtnAsgnCls.Size = new System.Drawing.Size(117, 29);
            this.BtnAsgnCls.TabIndex = 1;
            this.BtnAsgnCls.Text = "Assign Class";
            this.BtnAsgnCls.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TeacherTbx);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 50);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Teacher";
            // 
            // TeacherTbx
            // 
            this.TeacherTbx.Location = new System.Drawing.Point(7, 21);
            this.TeacherTbx.Name = "TeacherTbx";
            this.TeacherTbx.Size = new System.Drawing.Size(180, 23);
            this.TeacherTbx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1065, 455);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.staffID,
            this.RegNo,
            this.StfName,
            this.Gender,
            this.MaritalStatus,
            this.Phoneddress,
            this.District,
            this.Village,
            this.nationality});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1059, 433);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // staffID
            // 
            this.staffID.Text = "Staff ID";
            this.staffID.Width = 0;
            // 
            // RegNo
            // 
            this.RegNo.Text = "Staff No";
            this.RegNo.Width = 113;
            // 
            // StfName
            // 
            this.StfName.Text = "Names";
            this.StfName.Width = 206;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 117;
            // 
            // MaritalStatus
            // 
            this.MaritalStatus.Text = "Marital Status";
            this.MaritalStatus.Width = 129;
            // 
            // Phoneddress
            // 
            this.Phoneddress.Text = "Phone Number";
            this.Phoneddress.Width = 127;
            // 
            // District
            // 
            this.District.Text = "District";
            this.District.Width = 101;
            // 
            // Village
            // 
            this.Village.Text = "Residential Address";
            this.Village.Width = 157;
            // 
            // nationality
            // 
            this.nationality.Text = "Nationality";
            this.nationality.Width = 224;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(946, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewEditteachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewEditteachers";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.ViewEditteachers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader staffID;
        private System.Windows.Forms.ColumnHeader StfName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader MaritalStatus;
        private System.Windows.Forms.ColumnHeader Phoneddress;
        private System.Windows.Forms.ColumnHeader District;
        private System.Windows.Forms.ColumnHeader Village;
        private System.Windows.Forms.Button BtnAsgnSub;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAsgnCls;
        private System.Windows.Forms.TextBox TeacherTbx;
        private System.Windows.Forms.Button BtnAsgnStud;
        private System.Windows.Forms.ColumnHeader nationality;
        private System.Windows.Forms.ColumnHeader RegNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConstraitBtn;
    }
}

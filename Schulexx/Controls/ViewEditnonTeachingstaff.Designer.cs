namespace Schulexx.Controls
{
    partial class ViewEditnonTeachingstaff
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.stffD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.District = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Village = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nationality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAsgnStud = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(375, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 35);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Non Teaching Staff";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1060, 455);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stffD,
            this.StaffNo,
            this.StaffName,
            this.Gender,
            this.MStatus,
            this.Phone,
            this.District,
            this.Village,
            this.Nationality});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1054, 433);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // stffD
            // 
            this.stffD.Text = "Staff ID";
            this.stffD.Width = 0;
            // 
            // StaffNo
            // 
            this.StaffNo.Text = "Staff Number";
            this.StaffNo.Width = 115;
            // 
            // StaffName
            // 
            this.StaffName.Text = "Staff Names";
            this.StaffName.Width = 218;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 77;
            // 
            // MStatus
            // 
            this.MStatus.Text = "Marital Status";
            this.MStatus.Width = 117;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone Number";
            this.Phone.Width = 140;
            // 
            // District
            // 
            this.District.Text = "Home District";
            this.District.Width = 160;
            // 
            // Village
            // 
            this.Village.Text = "Village";
            this.Village.Width = 123;
            // 
            // Nationality
            // 
            this.Nationality.Text = "Nationality";
            this.Nationality.Width = 164;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAsgnStud);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(13, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // BtnAsgnStud
            // 
            this.BtnAsgnStud.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAsgnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsgnStud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsgnStud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAsgnStud.Location = new System.Drawing.Point(929, 19);
            this.BtnAsgnStud.Name = "BtnAsgnStud";
            this.BtnAsgnStud.Size = new System.Drawing.Size(122, 29);
            this.BtnAsgnStud.TabIndex = 2;
            this.BtnAsgnStud.Text = "Assign Student";
            this.BtnAsgnStud.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 50);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group by";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(942, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewEditnonTeachingstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewEditnonTeachingstaff";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.ViewEditnonTeachingstaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader stffD;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader MStatus;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader District;
        private System.Windows.Forms.ColumnHeader Village;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader StaffNo;
        private System.Windows.Forms.ColumnHeader Nationality;
        private System.Windows.Forms.Button BtnAsgnStud;
        private System.Windows.Forms.Button button1;
    }
}

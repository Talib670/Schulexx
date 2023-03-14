namespace Schulexx.Controls
{
    partial class ViewEditparents
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
            this.ParenttID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Relation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Occupation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.T_students = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_cont = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(383, 3);
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
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Parents";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1052, 430);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParenttID,
            this.ParentName,
            this.Gender,
            this.StudentNames,
            this.Relation,
            this.PhNumber,
            this.Occupation,
            this.HomeAddress,
            this.WorkAddress,
            this.T_students});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1046, 408);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ParenttID
            // 
            this.ParenttID.Text = "Parentt ID";
            this.ParenttID.Width = 0;
            // 
            // ParentName
            // 
            this.ParentName.Text = "Parent Names";
            this.ParentName.Width = 141;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 68;
            // 
            // StudentNames
            // 
            this.StudentNames.Text = "Student Names";
            this.StudentNames.Width = 117;
            // 
            // Relation
            // 
            this.Relation.Text = "Relation to Student";
            this.Relation.Width = 178;
            // 
            // PhNumber
            // 
            this.PhNumber.Text = "Phone Number";
            this.PhNumber.Width = 128;
            // 
            // Occupation
            // 
            this.Occupation.Text = "Occupation";
            this.Occupation.Width = 113;
            // 
            // HomeAddress
            // 
            this.HomeAddress.Text = "Home Address";
            this.HomeAddress.Width = 113;
            // 
            // WorkAddress
            // 
            this.WorkAddress.Text = "Work Address";
            this.WorkAddress.Width = 104;
            // 
            // T_students
            // 
            this.T_students.Text = "Total Students";
            this.T_students.Width = 118;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_cont);
            this.groupBox2.Controls.Add(this.btn_assign);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(23, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Btn_cont
            // 
            this.Btn_cont.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cont.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cont.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_cont.Location = new System.Drawing.Point(761, 19);
            this.Btn_cont.Name = "Btn_cont";
            this.Btn_cont.Size = new System.Drawing.Size(134, 36);
            this.Btn_cont.TabIndex = 1;
            this.Btn_cont.Text = "Contact Info";
            this.Btn_cont.UseVisualStyleBackColor = false;
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_assign.Location = new System.Drawing.Point(901, 19);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(134, 35);
            this.btn_assign.TabIndex = 1;
            this.btn_assign.Text = "Assign Student";
            this.btn_assign.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(738, 50);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Parent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "OR BY PHONE  NUMBER#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEARCH BY NAMES #";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 0;
            // 
            // ViewEditparents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewEditparents";
            this.Size = new System.Drawing.Size(1093, 563);
            this.Load += new System.EventHandler(this.ViewEditparents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ParenttID;
        private System.Windows.Forms.ColumnHeader ParentName;
        private System.Windows.Forms.ColumnHeader Occupation;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader StudentNames;
        private System.Windows.Forms.ColumnHeader Relation;
        private System.Windows.Forms.ColumnHeader PhNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.ColumnHeader HomeAddress;
        private System.Windows.Forms.ColumnHeader WorkAddress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_cont;
        private System.Windows.Forms.ColumnHeader T_students;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

namespace Schulexx.Controls
{
    partial class StudentClass_enroll
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
            this.streamCbx = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.class_Cbx = new System.Windows.Forms.ComboBox();
            this.Btn_new = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.st_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.st_Stream = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enroll Student in Class";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.streamCbx);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stream";
            // 
            // streamCbx
            // 
            this.streamCbx.FormattingEnabled = true;
            this.streamCbx.Location = new System.Drawing.Point(7, 21);
            this.streamCbx.Name = "streamCbx";
            this.streamCbx.Size = new System.Drawing.Size(211, 25);
            this.streamCbx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.class_Cbx);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 55);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class";
            // 
            // class_Cbx
            // 
            this.class_Cbx.FormattingEnabled = true;
            this.class_Cbx.Location = new System.Drawing.Point(7, 21);
            this.class_Cbx.Name = "class_Cbx";
            this.class_Cbx.Size = new System.Drawing.Size(211, 25);
            this.class_Cbx.TabIndex = 0;
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(19, 206);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(78, 33);
            this.Btn_new.TabIndex = 2;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(100, 207);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(70, 32);
            this.Btn_save.TabIndex = 2;
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
            this.Btn_delete.Location = new System.Drawing.Point(173, 207);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(70, 32);
            this.Btn_delete.TabIndex = 2;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(262, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 217);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Class Enrollments";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.student,
            this.st_class,
            this.st_Stream});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 195);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // student
            // 
            this.student.Text = "Student";
            this.student.Width = 97;
            // 
            // st_class
            // 
            this.st_class.Text = "Class";
            this.st_class.Width = 87;
            // 
            // st_Stream
            // 
            this.st_Stream.Text = "Stream";
            this.st_Stream.Width = 131;
            // 
            // StudentClass_enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentClass_enroll";
            this.Size = new System.Drawing.Size(560, 242);
            this.Load += new System.EventHandler(this.StudentClass_enroll_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox streamCbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox class_Cbx;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader student;
        private System.Windows.Forms.ColumnHeader st_class;
        private System.Windows.Forms.ColumnHeader st_Stream;
        private System.Windows.Forms.ColumnHeader id;
    }
}

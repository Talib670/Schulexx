namespace Schulexx.ConfigureUI
{
    partial class NewDepartment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depNametxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descr_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepDescr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DeptypeCbx = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding Departments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depNametxt);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(22, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Name";
            // 
            // depNametxt
            // 
            this.depNametxt.Location = new System.Drawing.Point(6, 20);
            this.depNametxt.Name = "depNametxt";
            this.depNametxt.Size = new System.Drawing.Size(207, 23);
            this.depNametxt.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descr_txt);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(23, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 113);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Department Description";
            // 
            // descr_txt
            // 
            this.descr_txt.Location = new System.Drawing.Point(6, 20);
            this.descr_txt.Multiline = true;
            this.descr_txt.Name = "descr_txt";
            this.descr_txt.Size = new System.Drawing.Size(207, 87);
            this.descr_txt.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(248, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 312);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.DepName,
            this.Dtype,
            this.DepDescr});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 290);
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
            // DepName
            // 
            this.DepName.Text = "Department Name";
            this.DepName.Width = 146;
            // 
            // Dtype
            // 
            this.Dtype.Text = "Type";
            this.Dtype.Width = 122;
            // 
            // DepDescr
            // 
            this.DepDescr.Text = "Department Description";
            this.DepDescr.Width = 205;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(84, 296);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 25);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(165, 296);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_new.Location = new System.Drawing.Point(24, 296);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(54, 25);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DeptypeCbx);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(23, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 54);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Department Type";
            // 
            // DeptypeCbx
            // 
            this.DeptypeCbx.FormattingEnabled = true;
            this.DeptypeCbx.Items.AddRange(new object[] {
            "Teaching Department",
            "Non Teaching Department"});
            this.DeptypeCbx.Location = new System.Drawing.Point(7, 23);
            this.DeptypeCbx.Name = "DeptypeCbx";
            this.DeptypeCbx.Size = new System.Drawing.Size(205, 25);
            this.DeptypeCbx.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(693, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 23);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(728, 29);
            this.panel1.TabIndex = 12;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // NewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(728, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NewDepartment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox depNametxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox descr_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DepName;
        private System.Windows.Forms.ColumnHeader DepDescr;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Dtype;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox DeptypeCbx;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
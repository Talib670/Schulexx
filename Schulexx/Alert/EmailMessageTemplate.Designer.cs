namespace Schulexx.AlertUI
{
    partial class EmailMessageTemplate
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TempTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tmessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.msgTbx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Email_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TempTitle,
            this.Tmessage});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 283);
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
            // TempTitle
            // 
            this.TempTitle.Text = "Template Title";
            this.TempTitle.Width = 190;
            // 
            // Tmessage
            // 
            this.Tmessage.Text = "Template Message";
            this.Tmessage.Width = 234;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(323, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 305);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Email Template Messages";
            // 
            // msgTbx
            // 
            this.msgTbx.Location = new System.Drawing.Point(7, 20);
            this.msgTbx.Multiline = true;
            this.msgTbx.Name = "msgTbx";
            this.msgTbx.Size = new System.Drawing.Size(296, 149);
            this.msgTbx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msgTbx);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 175);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Message Body";
            // 
            // Email_Tbx
            // 
            this.Email_Tbx.Location = new System.Drawing.Point(7, 22);
            this.Email_Tbx.Name = "Email_Tbx";
            this.Email_Tbx.Size = new System.Drawing.Size(296, 23);
            this.Email_Tbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Email_Tbx);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 57);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Template Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Message Templates";
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_delete.Location = new System.Drawing.Point(221, 300);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(76, 33);
            this.Btn_delete.TabIndex = 28;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_save.Location = new System.Drawing.Point(139, 300);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(76, 33);
            this.Btn_save.TabIndex = 29;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_new.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_new.Location = new System.Drawing.Point(57, 300);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(76, 33);
            this.Btn_new.TabIndex = 30;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 44);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // EmailMessageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailMessageTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailMessageTemplate";
            this.Load += new System.EventHandler(this.EmailMessageTemplate_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TempTitle;
        private System.Windows.Forms.ColumnHeader Tmessage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox msgTbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Email_Tbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
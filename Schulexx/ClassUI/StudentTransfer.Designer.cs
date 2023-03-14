namespace Schulexx.StudentsUI
{
    partial class StudentTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTransfer));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbOldStudents = new System.Windows.Forms.GroupBox();
            this.dgvOldStudents = new System.Windows.Forms.DataGridView();
            this.reg_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.gbFailedStudents = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFailedStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butFailAllTrnBack = new System.Windows.Forms.Button();
            this.butFailAllTrn = new System.Windows.Forms.Button();
            this.butFailSelectedTrn = new System.Windows.Forms.Button();
            this.butFailSelectedTrnBk = new System.Windows.Forms.Button();
            this.gbPromoStudents = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPromoStudents = new System.Windows.Forms.DataGridView();
            this.reg_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butPromoAllTrnBack = new System.Windows.Forms.Button();
            this.butPromoAllTrn = new System.Windows.Forms.Button();
            this.butPromoSelectedTrn = new System.Windows.Forms.Button();
            this.butPromoSelectedTrnBk = new System.Windows.Forms.Button();
            this.TopPn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tlpMain.SuspendLayout();
            this.gbOldStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldStudents)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFailedStudents.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedStudents)).BeginInit();
            this.gbPromoStudents.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromoStudents)).BeginInit();
            this.TopPn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpMain.Controls.Add(this.gbOldStudents, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tlpMain.Controls.Add(this.gbFailedStudents, 1, 2);
            this.tlpMain.Controls.Add(this.gbPromoStudents, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1024, 545);
            this.tlpMain.TabIndex = 0;
            // 
            // gbOldStudents
            // 
            this.gbOldStudents.Controls.Add(this.dgvOldStudents);
            this.gbOldStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOldStudents.Location = new System.Drawing.Point(3, 69);
            this.gbOldStudents.Name = "gbOldStudents";
            this.tlpMain.SetRowSpan(this.gbOldStudents, 2);
            this.gbOldStudents.Size = new System.Drawing.Size(454, 473);
            this.gbOldStudents.TabIndex = 4;
            this.gbOldStudents.TabStop = false;
            this.gbOldStudents.Text = "Students to be Transferred";
            // 
            // dgvOldStudents
            // 
            this.dgvOldStudents.AllowUserToAddRows = false;
            this.dgvOldStudents.AllowUserToDeleteRows = false;
            this.dgvOldStudents.AllowUserToResizeRows = false;
            this.dgvOldStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOldStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvOldStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOldStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg_number,
            this.lname,
            this.fname});
            this.dgvOldStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOldStudents.Location = new System.Drawing.Point(3, 19);
            this.dgvOldStudents.Name = "dgvOldStudents";
            this.dgvOldStudents.ReadOnly = true;
            this.dgvOldStudents.RowHeadersVisible = false;
            this.dgvOldStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOldStudents.Size = new System.Drawing.Size(448, 451);
            this.dgvOldStudents.TabIndex = 0;
            this.dgvOldStudents.SelectionChanged += new System.EventHandler(this.dgvOldStudents_SelectionChanged);
            // 
            // reg_number
            // 
            this.reg_number.DataPropertyName = "reg_number";
            this.reg_number.HeaderText = "Reg No";
            this.reg_number.Name = "reg_number";
            this.reg_number.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.butSave, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.butLoad, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1018, 60);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(375, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students, having subjects assigned, cannot be transferred back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(393, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Move students and click on \"Save Transfers\" button to save";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butSave
            // 
            this.butSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSave.BackColor = System.Drawing.Color.DarkCyan;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butSave.Location = new System.Drawing.Point(876, 12);
            this.butSave.Margin = new System.Windows.Forms.Padding(4);
            this.butSave.Name = "butSave";
            this.tableLayoutPanel7.SetRowSpan(this.butSave, 2);
            this.butSave.Size = new System.Drawing.Size(138, 35);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save Transfers";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butLoad
            // 
            this.butLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butLoad.BackColor = System.Drawing.Color.DarkCyan;
            this.butLoad.Enabled = false;
            this.butLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLoad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butLoad.Location = new System.Drawing.Point(182, 12);
            this.butLoad.Margin = new System.Windows.Forms.Padding(4);
            this.butLoad.Name = "butLoad";
            this.tableLayoutPanel7.SetRowSpan(this.butLoad, 2);
            this.butLoad.Size = new System.Drawing.Size(112, 35);
            this.butLoad.TabIndex = 11;
            this.butLoad.Text = "Load Students";
            this.butLoad.UseVisualStyleBackColor = false;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox2.Location = new System.Drawing.Point(101, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel7.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(74, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Year";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYear.Location = new System.Drawing.Point(16, 25);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 19);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "9999";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel7.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(92, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // cboClass
            // 
            this.cboClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboClass.DisplayMember = "Value";
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(19, 23);
            this.cboClass.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(60, 25);
            this.cboClass.TabIndex = 0;
            this.cboClass.ValueMember = "Key";
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // gbFailedStudents
            // 
            this.gbFailedStudents.Controls.Add(this.tableLayoutPanel2);
            this.gbFailedStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFailedStudents.Location = new System.Drawing.Point(463, 381);
            this.gbFailedStudents.Name = "gbFailedStudents";
            this.gbFailedStudents.Size = new System.Drawing.Size(558, 161);
            this.gbFailedStudents.TabIndex = 13;
            this.gbFailedStudents.TabStop = false;
            this.gbFailedStudents.Text = "Students Transferred";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvFailedStudents, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butFailAllTrnBack, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.butFailAllTrn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.butFailSelectedTrn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.butFailSelectedTrnBk, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 139);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // dgvFailedStudents
            // 
            this.dgvFailedStudents.AllowUserToAddRows = false;
            this.dgvFailedStudents.AllowUserToDeleteRows = false;
            this.dgvFailedStudents.AllowUserToResizeRows = false;
            this.dgvFailedStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFailedStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvFailedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailedStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvFailedStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFailedStudents.Location = new System.Drawing.Point(67, 3);
            this.dgvFailedStudents.Name = "dgvFailedStudents";
            this.dgvFailedStudents.ReadOnly = true;
            this.dgvFailedStudents.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dgvFailedStudents, 7);
            this.dgvFailedStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFailedStudents.Size = new System.Drawing.Size(482, 133);
            this.dgvFailedStudents.TabIndex = 0;
            this.dgvFailedStudents.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFailedStudents_DataBindingComplete);
            this.dgvFailedStudents.SelectionChanged += new System.EventHandler(this.dgvFailedStudents_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "reg_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Reg No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn3.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // butFailAllTrnBack
            // 
            this.butFailAllTrnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butFailAllTrnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.butFailAllTrnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFailAllTrnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFailAllTrnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butFailAllTrnBack.Location = new System.Drawing.Point(3, 112);
            this.butFailAllTrnBack.Name = "butFailAllTrnBack";
            this.butFailAllTrnBack.Size = new System.Drawing.Size(58, 26);
            this.butFailAllTrnBack.TabIndex = 14;
            this.butFailAllTrnBack.Text = "<<";
            this.butFailAllTrnBack.UseVisualStyleBackColor = false;
            this.butFailAllTrnBack.Click += new System.EventHandler(this.butFailAllTrnBack_Click);
            // 
            // butFailAllTrn
            // 
            this.butFailAllTrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butFailAllTrn.BackColor = System.Drawing.Color.DarkCyan;
            this.butFailAllTrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFailAllTrn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFailAllTrn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butFailAllTrn.Location = new System.Drawing.Point(3, 33);
            this.butFailAllTrn.Name = "butFailAllTrn";
            this.butFailAllTrn.Size = new System.Drawing.Size(58, 26);
            this.butFailAllTrn.TabIndex = 12;
            this.butFailAllTrn.Text = ">>";
            this.butFailAllTrn.UseVisualStyleBackColor = false;
            this.butFailAllTrn.Click += new System.EventHandler(this.butFailAllTrn_Click);
            // 
            // butFailSelectedTrn
            // 
            this.butFailSelectedTrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butFailSelectedTrn.BackColor = System.Drawing.Color.DarkCyan;
            this.butFailSelectedTrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFailSelectedTrn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFailSelectedTrn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butFailSelectedTrn.Location = new System.Drawing.Point(3, 1);
            this.butFailSelectedTrn.Name = "butFailSelectedTrn";
            this.butFailSelectedTrn.Size = new System.Drawing.Size(58, 26);
            this.butFailSelectedTrn.TabIndex = 11;
            this.butFailSelectedTrn.Text = ">";
            this.butFailSelectedTrn.UseVisualStyleBackColor = false;
            this.butFailSelectedTrn.Click += new System.EventHandler(this.butFailSelectedTrn_Click);
            // 
            // butFailSelectedTrnBk
            // 
            this.butFailSelectedTrnBk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butFailSelectedTrnBk.BackColor = System.Drawing.Color.DarkCyan;
            this.butFailSelectedTrnBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFailSelectedTrnBk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFailSelectedTrnBk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butFailSelectedTrnBk.Location = new System.Drawing.Point(3, 80);
            this.butFailSelectedTrnBk.Name = "butFailSelectedTrnBk";
            this.butFailSelectedTrnBk.Size = new System.Drawing.Size(58, 26);
            this.butFailSelectedTrnBk.TabIndex = 13;
            this.butFailSelectedTrnBk.Text = "<";
            this.butFailSelectedTrnBk.UseVisualStyleBackColor = false;
            this.butFailSelectedTrnBk.Click += new System.EventHandler(this.butFailSelectedTrnBk_Click);
            // 
            // gbPromoStudents
            // 
            this.gbPromoStudents.Controls.Add(this.tableLayoutPanel6);
            this.gbPromoStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPromoStudents.Location = new System.Drawing.Point(463, 69);
            this.gbPromoStudents.Name = "gbPromoStudents";
            this.gbPromoStudents.Size = new System.Drawing.Size(558, 306);
            this.gbPromoStudents.TabIndex = 7;
            this.gbPromoStudents.TabStop = false;
            this.gbPromoStudents.Text = "Students Transferred";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.dgvPromoStudents, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.butPromoAllTrnBack, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.butPromoAllTrn, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.butPromoSelectedTrn, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.butPromoSelectedTrnBk, 0, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(552, 284);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // dgvPromoStudents
            // 
            this.dgvPromoStudents.AllowUserToAddRows = false;
            this.dgvPromoStudents.AllowUserToDeleteRows = false;
            this.dgvPromoStudents.AllowUserToResizeRows = false;
            this.dgvPromoStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromoStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvPromoStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromoStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg_number1,
            this.lname1,
            this.fname1});
            this.dgvPromoStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPromoStudents.Location = new System.Drawing.Point(69, 3);
            this.dgvPromoStudents.Name = "dgvPromoStudents";
            this.dgvPromoStudents.ReadOnly = true;
            this.dgvPromoStudents.RowHeadersVisible = false;
            this.tableLayoutPanel6.SetRowSpan(this.dgvPromoStudents, 7);
            this.dgvPromoStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromoStudents.Size = new System.Drawing.Size(480, 278);
            this.dgvPromoStudents.TabIndex = 0;
            this.dgvPromoStudents.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPromoStudents_DataBindingComplete);
            this.dgvPromoStudents.SelectionChanged += new System.EventHandler(this.dgvPromoStudents_SelectionChanged);
            // 
            // reg_number1
            // 
            this.reg_number1.DataPropertyName = "reg_number";
            this.reg_number1.HeaderText = "Reg No";
            this.reg_number1.Name = "reg_number1";
            this.reg_number1.ReadOnly = true;
            // 
            // lname1
            // 
            this.lname1.DataPropertyName = "lname";
            this.lname1.HeaderText = "Last Name";
            this.lname1.Name = "lname1";
            this.lname1.ReadOnly = true;
            // 
            // fname1
            // 
            this.fname1.DataPropertyName = "fname";
            this.fname1.HeaderText = "First Name";
            this.fname1.Name = "fname1";
            this.fname1.ReadOnly = true;
            // 
            // butPromoAllTrnBack
            // 
            this.butPromoAllTrnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPromoAllTrnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.butPromoAllTrnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPromoAllTrnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPromoAllTrnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butPromoAllTrnBack.Location = new System.Drawing.Point(4, 199);
            this.butPromoAllTrnBack.Margin = new System.Windows.Forms.Padding(4);
            this.butPromoAllTrnBack.Name = "butPromoAllTrnBack";
            this.butPromoAllTrnBack.Size = new System.Drawing.Size(58, 35);
            this.butPromoAllTrnBack.TabIndex = 14;
            this.butPromoAllTrnBack.Text = "<<";
            this.butPromoAllTrnBack.UseVisualStyleBackColor = false;
            this.butPromoAllTrnBack.Click += new System.EventHandler(this.butPromoAllTrnBack_Click);
            // 
            // butPromoAllTrn
            // 
            this.butPromoAllTrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPromoAllTrn.BackColor = System.Drawing.Color.DarkCyan;
            this.butPromoAllTrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPromoAllTrn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPromoAllTrn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butPromoAllTrn.Location = new System.Drawing.Point(4, 93);
            this.butPromoAllTrn.Margin = new System.Windows.Forms.Padding(4);
            this.butPromoAllTrn.Name = "butPromoAllTrn";
            this.butPromoAllTrn.Size = new System.Drawing.Size(58, 35);
            this.butPromoAllTrn.TabIndex = 12;
            this.butPromoAllTrn.Text = ">>";
            this.butPromoAllTrn.UseVisualStyleBackColor = false;
            this.butPromoAllTrn.Click += new System.EventHandler(this.butPromoAllTrn_Click);
            // 
            // butPromoSelectedTrn
            // 
            this.butPromoSelectedTrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPromoSelectedTrn.BackColor = System.Drawing.Color.DarkCyan;
            this.butPromoSelectedTrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPromoSelectedTrn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPromoSelectedTrn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butPromoSelectedTrn.Location = new System.Drawing.Point(4, 50);
            this.butPromoSelectedTrn.Margin = new System.Windows.Forms.Padding(4);
            this.butPromoSelectedTrn.Name = "butPromoSelectedTrn";
            this.butPromoSelectedTrn.Size = new System.Drawing.Size(58, 35);
            this.butPromoSelectedTrn.TabIndex = 11;
            this.butPromoSelectedTrn.Text = ">";
            this.butPromoSelectedTrn.UseVisualStyleBackColor = false;
            this.butPromoSelectedTrn.Click += new System.EventHandler(this.butPromoSelectedTrn_Click);
            // 
            // butPromoSelectedTrnBk
            // 
            this.butPromoSelectedTrnBk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPromoSelectedTrnBk.BackColor = System.Drawing.Color.DarkCyan;
            this.butPromoSelectedTrnBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPromoSelectedTrnBk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPromoSelectedTrnBk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butPromoSelectedTrnBk.Location = new System.Drawing.Point(4, 156);
            this.butPromoSelectedTrnBk.Margin = new System.Windows.Forms.Padding(4);
            this.butPromoSelectedTrnBk.Name = "butPromoSelectedTrnBk";
            this.butPromoSelectedTrnBk.Size = new System.Drawing.Size(58, 35);
            this.butPromoSelectedTrnBk.TabIndex = 13;
            this.butPromoSelectedTrnBk.Text = "<";
            this.butPromoSelectedTrnBk.UseVisualStyleBackColor = false;
            this.butPromoSelectedTrnBk.Click += new System.EventHandler(this.butPromoTrnBk_Click);
            // 
            // TopPn
            // 
            this.TopPn.BackColor = System.Drawing.Color.DarkCyan;
            this.TopPn.Controls.Add(this.BtnClose);
            this.TopPn.Controls.Add(this.label3);
            this.TopPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPn.Location = new System.Drawing.Point(0, 0);
            this.TopPn.Name = "TopPn";
            this.TopPn.Padding = new System.Windows.Forms.Padding(1);
            this.TopPn.Size = new System.Drawing.Size(1024, 29);
            this.TopPn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(282, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Transfer Students from One Class to Another (Promote OR Demote)";
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Black", 12F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(985, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(38, 27);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "x";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 545);
            this.panel1.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPn;
            this.bunifuDragControl1.Vertical = true;
            // 
            // StudentTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1024, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPn);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentTransfer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer Students";
            this.Load += new System.EventHandler(this.StudentTransfer_Load);
            this.Shown += new System.EventHandler(this.StudentTransfer_Shown);
            this.tlpMain.ResumeLayout(false);
            this.gbOldStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldStudents)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbFailedStudents.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedStudents)).EndInit();
            this.gbPromoStudents.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromoStudents)).EndInit();
            this.TopPn.ResumeLayout(false);
            this.TopPn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOldStudents;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.DataGridView dgvOldStudents;
        private System.Windows.Forms.GroupBox gbPromoStudents;
        private System.Windows.Forms.DataGridView dgvPromoStudents;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button butPromoAllTrnBack;
        private System.Windows.Forms.Button butPromoSelectedTrnBk;
        private System.Windows.Forms.Button butPromoAllTrn;
        private System.Windows.Forms.Button butPromoSelectedTrn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFailedStudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butFailAllTrnBack;
        private System.Windows.Forms.Button butFailAllTrn;
        private System.Windows.Forms.Button butFailSelectedTrn;
        private System.Windows.Forms.Button butFailSelectedTrnBk;
        private System.Windows.Forms.DataGridView dgvFailedStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel TopPn;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
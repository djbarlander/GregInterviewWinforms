namespace GregInterviewWinforms
{
    partial class Form1
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phExtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CSV = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbStaffDetail = new System.Windows.Forms.GroupBox();
            this.cbStaffStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIRD = new System.Windows.Forms.TextBox();
            this.txtPhExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhCell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhHome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMInitial = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMInitial = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gbStaffDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffTitleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleInitialDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phHomeDataGridViewTextBoxColumn,
            this.phCellDataGridViewTextBoxColumn,
            this.phExtDataGridViewTextBoxColumn,
            this.iRDDataGridViewTextBoxColumn,
            this.staffTypeDataGridViewTextBoxColumn,
            this.staffStatusDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.vwStaffBindingSource;
            this.dgvMain.Location = new System.Drawing.Point(18, 18);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.Size = new System.Drawing.Size(1996, 437);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 97;
            // 
            // staffTitleDataGridViewTextBoxColumn
            // 
            this.staffTitleDataGridViewTextBoxColumn.DataPropertyName = "StaffTitle";
            this.staffTitleDataGridViewTextBoxColumn.HeaderText = "StaffTitle";
            this.staffTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffTitleDataGridViewTextBoxColumn.Name = "staffTitleDataGridViewTextBoxColumn";
            this.staffTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffTitleDataGridViewTextBoxColumn.Width = 109;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 118;
            // 
            // middleInitialDataGridViewTextBoxColumn
            // 
            this.middleInitialDataGridViewTextBoxColumn.DataPropertyName = "MiddleInitial";
            this.middleInitialDataGridViewTextBoxColumn.HeaderText = "MiddleInitial";
            this.middleInitialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.middleInitialDataGridViewTextBoxColumn.Name = "middleInitialDataGridViewTextBoxColumn";
            this.middleInitialDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleInitialDataGridViewTextBoxColumn.Width = 128;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 118;
            // 
            // phHomeDataGridViewTextBoxColumn
            // 
            this.phHomeDataGridViewTextBoxColumn.DataPropertyName = "PhHome";
            this.phHomeDataGridViewTextBoxColumn.HeaderText = "PhHome";
            this.phHomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phHomeDataGridViewTextBoxColumn.Name = "phHomeDataGridViewTextBoxColumn";
            this.phHomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.phHomeDataGridViewTextBoxColumn.Width = 107;
            // 
            // phCellDataGridViewTextBoxColumn
            // 
            this.phCellDataGridViewTextBoxColumn.DataPropertyName = "PhCell";
            this.phCellDataGridViewTextBoxColumn.HeaderText = "PhCell";
            this.phCellDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phCellDataGridViewTextBoxColumn.Name = "phCellDataGridViewTextBoxColumn";
            this.phCellDataGridViewTextBoxColumn.ReadOnly = true;
            this.phCellDataGridViewTextBoxColumn.Width = 90;
            // 
            // phExtDataGridViewTextBoxColumn
            // 
            this.phExtDataGridViewTextBoxColumn.DataPropertyName = "PhExt";
            this.phExtDataGridViewTextBoxColumn.HeaderText = "PhExt";
            this.phExtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phExtDataGridViewTextBoxColumn.Name = "phExtDataGridViewTextBoxColumn";
            this.phExtDataGridViewTextBoxColumn.ReadOnly = true;
            this.phExtDataGridViewTextBoxColumn.Width = 87;
            // 
            // iRDDataGridViewTextBoxColumn
            // 
            this.iRDDataGridViewTextBoxColumn.DataPropertyName = "IRD";
            this.iRDDataGridViewTextBoxColumn.HeaderText = "IRD";
            this.iRDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iRDDataGridViewTextBoxColumn.Name = "iRDDataGridViewTextBoxColumn";
            this.iRDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iRDDataGridViewTextBoxColumn.Width = 74;
            // 
            // staffTypeDataGridViewTextBoxColumn
            // 
            this.staffTypeDataGridViewTextBoxColumn.DataPropertyName = "StaffType";
            this.staffTypeDataGridViewTextBoxColumn.HeaderText = "StaffType";
            this.staffTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffTypeDataGridViewTextBoxColumn.Name = "staffTypeDataGridViewTextBoxColumn";
            this.staffTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffTypeDataGridViewTextBoxColumn.Width = 114;
            // 
            // staffStatusDataGridViewTextBoxColumn
            // 
            this.staffStatusDataGridViewTextBoxColumn.DataPropertyName = "StaffStatus";
            this.staffStatusDataGridViewTextBoxColumn.HeaderText = "StaffStatus";
            this.staffStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffStatusDataGridViewTextBoxColumn.Name = "staffStatusDataGridViewTextBoxColumn";
            this.staffStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffStatusDataGridViewTextBoxColumn.Width = 127;
            // 
            // vwStaffBindingSource
            // 
            this.vwStaffBindingSource.DataSource = typeof(GregInterviewWinforms.vw_Staff);
            // 
            // btn_CSV
            // 
            this.btn_CSV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CSV.Location = new System.Drawing.Point(51, 1000);
            this.btn_CSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CSV.Name = "btn_CSV";
            this.btn_CSV.Size = new System.Drawing.Size(112, 35);
            this.btn_CSV.TabIndex = 3;
            this.btn_CSV.Text = "Create CSV";
            this.btn_CSV.UseVisualStyleBackColor = false;
            this.btn_CSV.Click += new System.EventHandler(this.btn_CSV_Click);
            // 
            // gbStaffDetail
            // 
            this.gbStaffDetail.Controls.Add(this.cbStaffStatus);
            this.gbStaffDetail.Controls.Add(this.label6);
            this.gbStaffDetail.Controls.Add(this.cbManager);
            this.gbStaffDetail.Controls.Add(this.label5);
            this.gbStaffDetail.Controls.Add(this.txtIRD);
            this.gbStaffDetail.Controls.Add(this.txtPhExt);
            this.gbStaffDetail.Controls.Add(this.label4);
            this.gbStaffDetail.Controls.Add(this.label3);
            this.gbStaffDetail.Controls.Add(this.txtPhCell);
            this.gbStaffDetail.Controls.Add(this.label2);
            this.gbStaffDetail.Controls.Add(this.txtPhHome);
            this.gbStaffDetail.Controls.Add(this.label1);
            this.gbStaffDetail.Controls.Add(this.btnNew);
            this.gbStaffDetail.Controls.Add(this.btnSave);
            this.gbStaffDetail.Controls.Add(this.btnCancel);
            this.gbStaffDetail.Controls.Add(this.btnEdit);
            this.gbStaffDetail.Controls.Add(this.txtLName);
            this.gbStaffDetail.Controls.Add(this.txtMInitial);
            this.gbStaffDetail.Controls.Add(this.txtFName);
            this.gbStaffDetail.Controls.Add(this.lblLName);
            this.gbStaffDetail.Controls.Add(this.lblMInitial);
            this.gbStaffDetail.Controls.Add(this.lblFName);
            this.gbStaffDetail.Controls.Add(this.lblTitle);
            this.gbStaffDetail.Controls.Add(this.cbTitle);
            this.gbStaffDetail.Location = new System.Drawing.Point(18, 486);
            this.gbStaffDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStaffDetail.Name = "gbStaffDetail";
            this.gbStaffDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStaffDetail.Size = new System.Drawing.Size(1996, 505);
            this.gbStaffDetail.TabIndex = 4;
            this.gbStaffDetail.TabStop = false;
            this.gbStaffDetail.Text = "Staff Details";
            // 
            // cbStaffStatus
            // 
            this.cbStaffStatus.DisplayMember = "StaffStatusID";
            this.cbStaffStatus.FormattingEnabled = true;
            this.cbStaffStatus.Location = new System.Drawing.Point(1274, 107);
            this.cbStaffStatus.Name = "cbStaffStatus";
            this.cbStaffStatus.Size = new System.Drawing.Size(163, 28);
            this.cbStaffStatus.TabIndex = 23;
            this.cbStaffStatus.ValueMember = "StaffStatusID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1166, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Staff Status";
            // 
            // cbManager
            // 
            this.cbManager.DisplayMember = "Manager";
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(976, 105);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(148, 28);
            this.cbManager.TabIndex = 21;
            this.cbManager.ValueMember = "ManagerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(879, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Staff Type";
            // 
            // txtIRD
            // 
            this.txtIRD.Location = new System.Drawing.Point(696, 107);
            this.txtIRD.Name = "txtIRD";
            this.txtIRD.Size = new System.Drawing.Size(148, 26);
            this.txtIRD.TabIndex = 19;
            // 
            // txtPhExt
            // 
            this.txtPhExt.Location = new System.Drawing.Point(444, 107);
            this.txtPhExt.Name = "txtPhExt";
            this.txtPhExt.Size = new System.Drawing.Size(100, 26);
            this.txtPhExt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "IRD Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Office Extension";
            // 
            // txtPhCell
            // 
            this.txtPhCell.Location = new System.Drawing.Point(100, 107);
            this.txtPhCell.Name = "txtPhCell";
            this.txtPhCell.Size = new System.Drawing.Size(158, 26);
            this.txtPhCell.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cell Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPhHome
            // 
            this.txtPhHome.Location = new System.Drawing.Point(1274, 29);
            this.txtPhHome.Name = "txtPhHome";
            this.txtPhHome.Size = new System.Drawing.Size(163, 26);
            this.txtPhHome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1166, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Home Phone";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNew.Location = new System.Drawing.Point(14, 358);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 35);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Info;
            this.btnSave.Location = new System.Drawing.Point(456, 358);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCancel.Location = new System.Drawing.Point(304, 358);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(152, 358);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(976, 29);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 26);
            this.txtLName.TabIndex = 7;
            // 
            // txtMInitial
            // 
            this.txtMInitial.Location = new System.Drawing.Point(696, 29);
            this.txtMInitial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMInitial.Name = "txtMInitial";
            this.txtMInitial.Size = new System.Drawing.Size(148, 26);
            this.txtMInitial.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(396, 29);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(148, 26);
            this.txtFName.TabIndex = 5;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(879, 42);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name";
            // 
            // lblMInitial
            // 
            this.lblMInitial.AutoSize = true;
            this.lblMInitial.Location = new System.Drawing.Point(588, 42);
            this.lblMInitial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMInitial.Name = "lblMInitial";
            this.lblMInitial.Size = new System.Drawing.Size(96, 20);
            this.lblMInitial.TabIndex = 3;
            this.lblMInitial.Text = "Middle Initial";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(300, 42);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 20);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 42);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // cbTitle
            // 
            this.cbTitle.DisplayMember = "Title";
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(78, 29);
            this.cbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(180, 28);
            this.cbTitle.TabIndex = 0;
            this.cbTitle.ValueMember = "StaffTitleID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(230, 1003);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print List";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2032, 1128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbStaffDetail);
            this.Controls.Add(this.btn_CSV);
            this.Controls.Add(this.dgvMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gbStaffDetail.ResumeLayout(false);
            this.gbStaffDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btn_CSV;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phCellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phExtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffStatusDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwStaffBindingSource;
        private System.Windows.Forms.GroupBox gbStaffDetail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMInitial;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMInitial;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtPhHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhCell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIRD;
        private System.Windows.Forms.TextBox txtPhExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbManager;
        private System.Windows.Forms.ComboBox cbStaffStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}


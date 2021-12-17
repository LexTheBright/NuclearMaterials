namespace SAACNM {
    partial class InvoicesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.lblPartner = new System.Windows.Forms.Label();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEmpStart = new System.Windows.Forms.Label();
            this.txtEmpStart = new System.Windows.Forms.TextBox();
            this.lblEmpEnd = new System.Windows.Forms.Label();
            this.txtEmpEnd = new System.Windows.Forms.TextBox();
            this.dgvAccountUnits = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.clmMatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMatForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScaleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmZBMNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFromCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiverCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlAgentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAgentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDocNum,
            this.Column1,
            this.clmDocDate,
            this.clmDocType,
            this.clmSecondName,
            this.clmFirstName,
            this.clmFatherName,
            this.clmFromCode,
            this.clmReceiverCode,
            this.cmlAgentCode,
            this.clmAgentSurname,
            this.clmOrgName});
            this.dgvInvoices.Location = new System.Drawing.Point(12, 12);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidth = 20;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(786, 234);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Location = new System.Drawing.Point(9, 258);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(139, 14);
            this.lblPartner.TabIndex = 1;
            this.lblPartner.Text = "Предприятие-партнер:";
            // 
            // txtPartner
            // 
            this.txtPartner.Location = new System.Drawing.Point(12, 275);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.ReadOnly = true;
            this.txtPartner.Size = new System.Drawing.Size(200, 22);
            this.txtPartner.TabIndex = 2;
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(215, 258);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(177, 14);
            this.lblAgent.TabIndex = 3;
            this.lblAgent.Text = "Представитель предприятия:";
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(218, 275);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.ReadOnly = true;
            this.txtAgent.Size = new System.Drawing.Size(250, 22);
            this.txtAgent.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(642, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(723, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEmpStart
            // 
            this.lblEmpStart.AutoSize = true;
            this.lblEmpStart.Location = new System.Drawing.Point(9, 310);
            this.lblEmpStart.Name = "lblEmpStart";
            this.lblEmpStart.Size = new System.Drawing.Size(136, 14);
            this.lblEmpStart.TabIndex = 5;
            this.lblEmpStart.Text = "Сотрудник-инициатор:";
            // 
            // txtEmpStart
            // 
            this.txtEmpStart.Location = new System.Drawing.Point(12, 327);
            this.txtEmpStart.Name = "txtEmpStart";
            this.txtEmpStart.ReadOnly = true;
            this.txtEmpStart.Size = new System.Drawing.Size(250, 22);
            this.txtEmpStart.TabIndex = 6;
            // 
            // lblEmpEnd
            // 
            this.lblEmpEnd.AutoSize = true;
            this.lblEmpEnd.Location = new System.Drawing.Point(265, 310);
            this.lblEmpEnd.Name = "lblEmpEnd";
            this.lblEmpEnd.Size = new System.Drawing.Size(147, 14);
            this.lblEmpEnd.TabIndex = 7;
            this.lblEmpEnd.Text = "Сотрудник-завершитель:";
            // 
            // txtEmpEnd
            // 
            this.txtEmpEnd.Location = new System.Drawing.Point(268, 327);
            this.txtEmpEnd.Name = "txtEmpEnd";
            this.txtEmpEnd.ReadOnly = true;
            this.txtEmpEnd.Size = new System.Drawing.Size(250, 22);
            this.txtEmpEnd.TabIndex = 8;
            // 
            // dgvAccountUnits
            // 
            this.dgvAccountUnits.AllowUserToAddRows = false;
            this.dgvAccountUnits.AllowUserToDeleteRows = false;
            this.dgvAccountUnits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAccountUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatType,
            this.clmSerialNum,
            this.clmContNum,
            this.clmMatForm,
            this.clmMass,
            this.clmScaleNum,
            this.clmZBMNum,
            this.clmBuildNum,
            this.clmRoomNum});
            this.dgvAccountUnits.Location = new System.Drawing.Point(12, 373);
            this.dgvAccountUnits.MultiSelect = false;
            this.dgvAccountUnits.Name = "dgvAccountUnits";
            this.dgvAccountUnits.ReadOnly = true;
            this.dgvAccountUnits.RowHeadersVisible = false;
            this.dgvAccountUnits.RowHeadersWidth = 20;
            this.dgvAccountUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountUnits.Size = new System.Drawing.Size(786, 225);
            this.dgvAccountUnits.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(723, 615);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // clmMatType
            // 
            this.clmMatType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMatType.HeaderText = "Тип материала";
            this.clmMatType.Name = "clmMatType";
            this.clmMatType.ReadOnly = true;
            this.clmMatType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmSerialNum
            // 
            this.clmSerialNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmSerialNum.HeaderText = "№ УЕ";
            this.clmSerialNum.MinimumWidth = 50;
            this.clmSerialNum.Name = "clmSerialNum";
            this.clmSerialNum.ReadOnly = true;
            this.clmSerialNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSerialNum.Width = 50;
            // 
            // clmContNum
            // 
            this.clmContNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmContNum.HeaderText = "Тип контейнера";
            this.clmContNum.MinimumWidth = 110;
            this.clmContNum.Name = "clmContNum";
            this.clmContNum.ReadOnly = true;
            this.clmContNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmContNum.Width = 110;
            // 
            // clmMatForm
            // 
            this.clmMatForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmMatForm.HeaderText = "Форма материала";
            this.clmMatForm.MinimumWidth = 120;
            this.clmMatForm.Name = "clmMatForm";
            this.clmMatForm.ReadOnly = true;
            this.clmMatForm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMatForm.Width = 120;
            // 
            // clmMass
            // 
            this.clmMass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmMass.HeaderText = "Масса";
            this.clmMass.Name = "clmMass";
            this.clmMass.ReadOnly = true;
            this.clmMass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMass.Width = 46;
            // 
            // clmScaleNum
            // 
            this.clmScaleNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmScaleNum.HeaderText = "№ весов";
            this.clmScaleNum.Name = "clmScaleNum";
            this.clmScaleNum.ReadOnly = true;
            this.clmScaleNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmScaleNum.Width = 63;
            // 
            // clmZBMNum
            // 
            this.clmZBMNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmZBMNum.HeaderText = "№ ЗБМ";
            this.clmZBMNum.Name = "clmZBMNum";
            this.clmZBMNum.ReadOnly = true;
            this.clmZBMNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmZBMNum.Width = 53;
            // 
            // clmBuildNum
            // 
            this.clmBuildNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmBuildNum.HeaderText = "№ здания";
            this.clmBuildNum.Name = "clmBuildNum";
            this.clmBuildNum.ReadOnly = true;
            this.clmBuildNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBuildNum.Width = 70;
            // 
            // clmRoomNum
            // 
            this.clmRoomNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmRoomNum.HeaderText = "№ помещения";
            this.clmRoomNum.Name = "clmRoomNum";
            this.clmRoomNum.ReadOnly = true;
            this.clmRoomNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmRoomNum.Width = 87;
            // 
            // clmDocNum
            // 
            this.clmDocNum.HeaderText = "№ накладной";
            this.clmDocNum.Name = "clmDocNum";
            this.clmDocNum.ReadOnly = true;
            this.clmDocNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmDocNum.Width = 110;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Код накладной";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmDocDate
            // 
            this.clmDocDate.HeaderText = "Дата";
            this.clmDocDate.Name = "clmDocDate";
            this.clmDocDate.ReadOnly = true;
            this.clmDocDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmDocDate.Width = 80;
            // 
            // clmDocType
            // 
            this.clmDocType.HeaderText = "Тип накладной";
            this.clmDocType.Name = "clmDocType";
            this.clmDocType.ReadOnly = true;
            this.clmDocType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmDocType.Width = 130;
            // 
            // clmSecondName
            // 
            this.clmSecondName.HeaderText = "Фамилия";
            this.clmSecondName.Name = "clmSecondName";
            this.clmSecondName.ReadOnly = true;
            this.clmSecondName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSecondName.Width = 125;
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "Имя";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            this.clmFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFirstName.Width = 110;
            // 
            // clmFatherName
            // 
            this.clmFatherName.HeaderText = "Отчество";
            this.clmFatherName.Name = "clmFatherName";
            this.clmFatherName.ReadOnly = true;
            this.clmFatherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFatherName.Width = 125;
            // 
            // clmFromCode
            // 
            this.clmFromCode.HeaderText = "Код отправителя";
            this.clmFromCode.Name = "clmFromCode";
            this.clmFromCode.ReadOnly = true;
            this.clmFromCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFromCode.Visible = false;
            this.clmFromCode.Width = 80;
            // 
            // clmReceiverCode
            // 
            this.clmReceiverCode.HeaderText = "Код получателя";
            this.clmReceiverCode.Name = "clmReceiverCode";
            this.clmReceiverCode.ReadOnly = true;
            this.clmReceiverCode.Visible = false;
            // 
            // cmlAgentCode
            // 
            this.cmlAgentCode.HeaderText = "Код представителя ";
            this.cmlAgentCode.Name = "cmlAgentCode";
            this.cmlAgentCode.ReadOnly = true;
            this.cmlAgentCode.Visible = false;
            // 
            // clmAgentSurname
            // 
            this.clmAgentSurname.HeaderText = "Фамилия представителя";
            this.clmAgentSurname.Name = "clmAgentSurname";
            this.clmAgentSurname.ReadOnly = true;
            this.clmAgentSurname.Visible = false;
            // 
            // clmOrgName
            // 
            this.clmOrgName.HeaderText = "Имя организации-партнера";
            this.clmOrgName.Name = "clmOrgName";
            this.clmOrgName.ReadOnly = true;
            this.clmOrgName.Visible = false;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 652);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvAccountUnits);
            this.Controls.Add(this.txtEmpEnd);
            this.Controls.Add(this.lblEmpEnd);
            this.Controls.Add(this.txtEmpStart);
            this.Controls.Add(this.lblEmpStart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.txtPartner);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.dgvInvoices);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvoicesForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEmpStart;
        private System.Windows.Forms.TextBox txtEmpStart;
        private System.Windows.Forms.Label lblEmpEnd;
        private System.Windows.Forms.TextBox txtEmpEnd;
        private System.Windows.Forms.DataGridView dgvAccountUnits;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScaleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmZBMNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFromCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiverCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlAgentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAgentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrgName;
    }
}
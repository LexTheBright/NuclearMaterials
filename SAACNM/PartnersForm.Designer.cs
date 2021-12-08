namespace SAACNM
{
    partial class PartnersForm
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
            this.lblPartners = new System.Windows.Forms.Label();
            this.dgvPartners = new System.Windows.Forms.DataGridView();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.btnEditPartner = new System.Windows.Forms.Button();
            this.btnDeletePartner = new System.Windows.Forms.Button();
            this.lblAgents = new System.Windows.Forms.Label();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.btnEditAgent = new System.Windows.Forms.Button();
            this.btnDeleteAgent = new System.Windows.Forms.Button();
            this.lblEmp = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOrg = new System.Windows.Forms.Label();
            this.txtEnt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clmEnterpriseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnterpriseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPartners.Location = new System.Drawing.Point(12, 9);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(146, 16);
            this.lblPartners.TabIndex = 0;
            this.lblPartners.Text = "Организации-партнеры";
            // 
            // dgvPartners
            // 
            this.dgvPartners.AllowUserToAddRows = false;
            this.dgvPartners.AllowUserToDeleteRows = false;
            this.dgvPartners.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEnterpriseCode,
            this.clmEnterpriseName,
            this.clmAddress,
            this.clmPhone,
            this.clmINN});
            this.dgvPartners.Location = new System.Drawing.Point(15, 28);
            this.dgvPartners.MultiSelect = false;
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.ReadOnly = true;
            this.dgvPartners.RowHeadersVisible = false;
            this.dgvPartners.RowHeadersWidth = 20;
            this.dgvPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartners.Size = new System.Drawing.Size(582, 173);
            this.dgvPartners.TabIndex = 1;
            this.dgvPartners.SelectionChanged += new System.EventHandler(this.dgvPartners_SelectionChanged);
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPartner.Location = new System.Drawing.Point(279, 5);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(89, 34);
            this.btnAddPartner.TabIndex = 4;
            this.btnAddPartner.Text = "Добавить";
            this.btnAddPartner.UseVisualStyleBackColor = false;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditPartner.Location = new System.Drawing.Point(374, 5);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(110, 34);
            this.btnEditPartner.TabIndex = 5;
            this.btnEditPartner.Text = "Редактировать";
            this.btnEditPartner.UseVisualStyleBackColor = false;
            this.btnEditPartner.Click += new System.EventHandler(this.btnEditPartner_Click);
            // 
            // btnDeletePartner
            // 
            this.btnDeletePartner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePartner.Location = new System.Drawing.Point(490, 5);
            this.btnDeletePartner.Name = "btnDeletePartner";
            this.btnDeletePartner.Size = new System.Drawing.Size(89, 34);
            this.btnDeletePartner.TabIndex = 6;
            this.btnDeletePartner.Text = "Удалить";
            this.btnDeletePartner.UseVisualStyleBackColor = false;
            this.btnDeletePartner.Click += new System.EventHandler(this.btnDeletePartner_Click);
            // 
            // lblAgents
            // 
            this.lblAgents.AutoSize = true;
            this.lblAgents.Location = new System.Drawing.Point(12, 271);
            this.lblAgents.Name = "lblAgents";
            this.lblAgents.Size = new System.Drawing.Size(169, 14);
            this.lblAgents.TabIndex = 7;
            this.lblAgents.Text = "Представители организации";
            // 
            // dgvAgents
            // 
            this.dgvAgents.AllowUserToAddRows = false;
            this.dgvAgents.AllowUserToDeleteRows = false;
            this.dgvAgents.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSecondName,
            this.clmFirstName,
            this.clmFatherName,
            this.clmPhoneNum});
            this.dgvAgents.Location = new System.Drawing.Point(15, 288);
            this.dgvAgents.MultiSelect = false;
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.ReadOnly = true;
            this.dgvAgents.RowHeadersVisible = false;
            this.dgvAgents.RowHeadersWidth = 20;
            this.dgvAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgents.Size = new System.Drawing.Size(582, 173);
            this.dgvAgents.TabIndex = 8;
            this.dgvAgents.SelectionChanged += new System.EventHandler(this.dgvAgents_SelectionChanged);
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAgent.Location = new System.Drawing.Point(279, 5);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(89, 34);
            this.btnAddAgent.TabIndex = 11;
            this.btnAddAgent.Text = "Добавить";
            this.btnAddAgent.UseVisualStyleBackColor = false;
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click);
            // 
            // btnEditAgent
            // 
            this.btnEditAgent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditAgent.Location = new System.Drawing.Point(374, 5);
            this.btnEditAgent.Name = "btnEditAgent";
            this.btnEditAgent.Size = new System.Drawing.Size(110, 34);
            this.btnEditAgent.TabIndex = 12;
            this.btnEditAgent.Text = "Редактировать";
            this.btnEditAgent.UseVisualStyleBackColor = false;
            this.btnEditAgent.Click += new System.EventHandler(this.btnEditAgent_Click);
            // 
            // btnDeleteAgent
            // 
            this.btnDeleteAgent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAgent.Location = new System.Drawing.Point(490, 5);
            this.btnDeleteAgent.Name = "btnDeleteAgent";
            this.btnDeleteAgent.Size = new System.Drawing.Size(89, 34);
            this.btnDeleteAgent.TabIndex = 13;
            this.btnDeleteAgent.Text = "Удалить";
            this.btnDeleteAgent.UseVisualStyleBackColor = false;
            this.btnDeleteAgent.Click += new System.EventHandler(this.btnDeleteAgent_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(3, 15);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(93, 14);
            this.lblEmp.TabIndex = 9;
            this.lblEmp.Text = "Представитель";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(102, 12);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.ReadOnly = true;
            this.txtEmp.Size = new System.Drawing.Size(137, 22);
            this.txtEmp.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.labelOrg);
            this.panel1.Controls.Add(this.btnAddPartner);
            this.panel1.Controls.Add(this.btnEditPartner);
            this.panel1.Controls.Add(this.txtEnt);
            this.panel1.Controls.Add(this.btnDeletePartner);
            this.panel1.Location = new System.Drawing.Point(15, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 43);
            this.panel1.TabIndex = 15;
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Location = new System.Drawing.Point(3, 15);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(80, 14);
            this.labelOrg.TabIndex = 2;
            this.labelOrg.Text = "Организация";
            // 
            // txtEnt
            // 
            this.txtEnt.Location = new System.Drawing.Point(89, 12);
            this.txtEnt.Name = "txtEnt";
            this.txtEnt.ReadOnly = true;
            this.txtEnt.Size = new System.Drawing.Size(150, 22);
            this.txtEnt.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.lblEmp);
            this.panel2.Controls.Add(this.btnEditAgent);
            this.panel2.Controls.Add(this.txtEmp);
            this.panel2.Controls.Add(this.btnAddAgent);
            this.panel2.Controls.Add(this.btnDeleteAgent);
            this.panel2.Location = new System.Drawing.Point(15, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 43);
            this.panel2.TabIndex = 16;
            // 
            // clmEnterpriseCode
            // 
            this.clmEnterpriseCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmEnterpriseCode.HeaderText = "Код";
            this.clmEnterpriseCode.Name = "clmEnterpriseCode";
            this.clmEnterpriseCode.ReadOnly = true;
            this.clmEnterpriseCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmEnterpriseCode.Width = 34;
            // 
            // clmEnterpriseName
            // 
            this.clmEnterpriseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmEnterpriseName.HeaderText = "Название";
            this.clmEnterpriseName.Name = "clmEnterpriseName";
            this.clmEnterpriseName.ReadOnly = true;
            this.clmEnterpriseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmEnterpriseName.Width = 65;
            // 
            // clmAddress
            // 
            this.clmAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAddress.HeaderText = "Адрес";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPhone
            // 
            this.clmPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPhone.HeaderText = "Номер телефона";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            this.clmPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmINN
            // 
            this.clmINN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmINN.HeaderText = "ИНН";
            this.clmINN.Name = "clmINN";
            this.clmINN.ReadOnly = true;
            this.clmINN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmINN.Width = 37;
            // 
            // clmSecondName
            // 
            this.clmSecondName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmSecondName.HeaderText = "Фамилия";
            this.clmSecondName.MinimumWidth = 160;
            this.clmSecondName.Name = "clmSecondName";
            this.clmSecondName.ReadOnly = true;
            this.clmSecondName.Width = 160;
            // 
            // clmFirstName
            // 
            this.clmFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmFirstName.HeaderText = "Имя";
            this.clmFirstName.MinimumWidth = 160;
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            this.clmFirstName.Width = 160;
            // 
            // clmFatherName
            // 
            this.clmFatherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmFatherName.HeaderText = "Отчество";
            this.clmFatherName.MinimumWidth = 155;
            this.clmFatherName.Name = "clmFatherName";
            this.clmFatherName.ReadOnly = true;
            this.clmFatherName.Width = 155;
            // 
            // clmPhoneNum
            // 
            this.clmPhoneNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPhoneNum.HeaderText = "Паспорт";
            this.clmPhoneNum.MinimumWidth = 100;
            this.clmPhoneNum.Name = "clmPhoneNum";
            this.clmPhoneNum.ReadOnly = true;
            this.clmPhoneNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PartnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 517);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.lblAgents);
            this.Controls.Add(this.dgvPartners);
            this.Controls.Add(this.lblPartners);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PartnersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Партнеры";
            this.Load += new System.EventHandler(this.PartnersForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartnersForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartners;
        private System.Windows.Forms.DataGridView dgvPartners;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.Button btnEditPartner;
        private System.Windows.Forms.Button btnDeletePartner;
        private System.Windows.Forms.Label lblAgents;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.Button btnEditAgent;
        private System.Windows.Forms.Button btnDeleteAgent;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.TextBox txtEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnterpriseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnterpriseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNum;
    }
}
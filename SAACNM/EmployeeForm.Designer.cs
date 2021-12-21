namespace SAACNM
{
    partial class EmployeeForm
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblSecName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPowerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmSecondName,
            this.clmFirstName,
            this.clmFatherName,
            this.clmPost,
            this.clmAddress,
            this.clmPhone,
            this.clmBirthDate,
            this.clmPassport,
            this.clmPowerCode});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 20;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(943, 331);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.SelectionChanged += new System.EventHandler(this.dgvEmployee_SelectionChanged);
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Location = new System.Drawing.Point(7, 15);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(59, 14);
            this.lblSecName.TabIndex = 1;
            this.lblSecName.Text = "Фамилия";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(76, 12);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(150, 22);
            this.txtSecondName.TabIndex = 2;
            this.txtSecondName.TextChanged += new System.EventHandler(this.txtSecondName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(631, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(726, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(842, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.txtSecondName);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblSecName);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(12, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 43);
            this.panel2.TabIndex = 17;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoose.Location = new System.Drawing.Point(536, 5);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(89, 34);
            this.btnChoose.TabIndex = 18;
            this.btnChoose.Text = "Выбрать";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "№";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmID.Width = 40;
            // 
            // clmSecondName
            // 
            this.clmSecondName.HeaderText = "Фамилия";
            this.clmSecondName.Name = "clmSecondName";
            this.clmSecondName.ReadOnly = true;
            this.clmSecondName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "Имя";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            this.clmFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFirstName.Width = 80;
            // 
            // clmFatherName
            // 
            this.clmFatherName.HeaderText = "Отчество";
            this.clmFatherName.Name = "clmFatherName";
            this.clmFatherName.ReadOnly = true;
            this.clmFatherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPost
            // 
            this.clmPost.HeaderText = "Должность";
            this.clmPost.Name = "clmPost";
            this.clmPost.ReadOnly = true;
            this.clmPost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPost.Width = 105;
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
            // clmBirthDate
            // 
            this.clmBirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmBirthDate.HeaderText = "Дата рождения";
            this.clmBirthDate.Name = "clmBirthDate";
            this.clmBirthDate.ReadOnly = true;
            this.clmBirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBirthDate.Width = 92;
            // 
            // clmPassport
            // 
            this.clmPassport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPassport.HeaderText = "Паспортные данные";
            this.clmPassport.Name = "clmPassport";
            this.clmPassport.ReadOnly = true;
            this.clmPassport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPassport.Width = 115;
            // 
            // clmPowerCode
            // 
            this.clmPowerCode.HeaderText = "PostCode";
            this.clmPowerCode.Name = "clmPowerCode";
            this.clmPowerCode.ReadOnly = true;
            this.clmPowerCode.Visible = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvEmployee);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPowerCode;
    }
}
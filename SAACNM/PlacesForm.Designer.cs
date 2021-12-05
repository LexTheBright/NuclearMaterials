namespace SAACNM
{
    partial class PlacesForm
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
            this.dgvPlaces = new System.Windows.Forms.DataGridView();
            this.clmNumZBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblZBMNum = new System.Windows.Forms.Label();
            this.txtZBMNum = new System.Windows.Forms.TextBox();
            this.lblBuildNum = new System.Windows.Forms.Label();
            this.txtBuildNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvLimits = new System.Windows.Forms.DataGridView();
            this.lblLimits = new System.Windows.Forms.Label();
            this.btnAddLim = new System.Windows.Forms.Button();
            this.btnEditLim = new System.Windows.Forms.Button();
            this.btnDeleteLim = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMatType = new System.Windows.Forms.Label();
            this.txtMatType = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.clmTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLimValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlaces
            // 
            this.dgvPlaces.AllowUserToAddRows = false;
            this.dgvPlaces.AllowUserToDeleteRows = false;
            this.dgvPlaces.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumZBM,
            this.clmNumBuilding,
            this.clmNumRoom,
            this.clmSecName,
            this.clmFirName,
            this.clmFatName,
            this.clmPhone});
            this.dgvPlaces.Location = new System.Drawing.Point(12, 12);
            this.dgvPlaces.MultiSelect = false;
            this.dgvPlaces.Name = "dgvPlaces";
            this.dgvPlaces.ReadOnly = true;
            this.dgvPlaces.RowHeadersWidth = 20;
            this.dgvPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaces.Size = new System.Drawing.Size(784, 249);
            this.dgvPlaces.TabIndex = 0;
            this.dgvPlaces.SelectionChanged += new System.EventHandler(this.dgvPlaces_SelectionChanged);
            // 
            // clmNumZBM
            // 
            this.clmNumZBM.HeaderText = "№ ЗБМ";
            this.clmNumZBM.Name = "clmNumZBM";
            this.clmNumZBM.ReadOnly = true;
            this.clmNumZBM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumZBM.Width = 70;
            // 
            // clmNumBuilding
            // 
            this.clmNumBuilding.HeaderText = "№ здания";
            this.clmNumBuilding.Name = "clmNumBuilding";
            this.clmNumBuilding.ReadOnly = true;
            this.clmNumBuilding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumBuilding.Width = 90;
            // 
            // clmNumRoom
            // 
            this.clmNumRoom.HeaderText = "№ помещения";
            this.clmNumRoom.Name = "clmNumRoom";
            this.clmNumRoom.ReadOnly = true;
            this.clmNumRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumRoom.Width = 120;
            // 
            // clmSecName
            // 
            this.clmSecName.HeaderText = "Фамилия";
            this.clmSecName.Name = "clmSecName";
            this.clmSecName.ReadOnly = true;
            this.clmSecName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSecName.Width = 115;
            // 
            // clmFirName
            // 
            this.clmFirName.HeaderText = "Имя";
            this.clmFirName.Name = "clmFirName";
            this.clmFirName.ReadOnly = true;
            this.clmFirName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFirName.Width = 105;
            // 
            // clmFatName
            // 
            this.clmFatName.HeaderText = "Отчество";
            this.clmFatName.Name = "clmFatName";
            this.clmFatName.ReadOnly = true;
            this.clmFatName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFatName.Width = 115;
            // 
            // clmPhone
            // 
            this.clmPhone.HeaderText = "Номер телефона";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            this.clmPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPhone.Width = 130;
            // 
            // lblZBMNum
            // 
            this.lblZBMNum.AutoSize = true;
            this.lblZBMNum.Location = new System.Drawing.Point(12, 272);
            this.lblZBMNum.Name = "lblZBMNum";
            this.lblZBMNum.Size = new System.Drawing.Size(51, 14);
            this.lblZBMNum.TabIndex = 1;
            this.lblZBMNum.Text = "№ ЗБМ:";
            // 
            // txtZBMNum
            // 
            this.txtZBMNum.Location = new System.Drawing.Point(69, 269);
            this.txtZBMNum.Name = "txtZBMNum";
            this.txtZBMNum.Size = new System.Drawing.Size(100, 22);
            this.txtZBMNum.TabIndex = 2;
            this.txtZBMNum.TextChanged += new System.EventHandler(this.txtZBMNum_TextChanged);
            // 
            // lblBuildNum
            // 
            this.lblBuildNum.AutoSize = true;
            this.lblBuildNum.Location = new System.Drawing.Point(175, 272);
            this.lblBuildNum.Name = "lblBuildNum";
            this.lblBuildNum.Size = new System.Drawing.Size(68, 14);
            this.lblBuildNum.TabIndex = 3;
            this.lblBuildNum.Text = "№ здания:";
            // 
            // txtBuildNum
            // 
            this.txtBuildNum.Location = new System.Drawing.Point(249, 269);
            this.txtBuildNum.Name = "txtBuildNum";
            this.txtBuildNum.Size = new System.Drawing.Size(100, 22);
            this.txtBuildNum.TabIndex = 4;
            this.txtBuildNum.TextChanged += new System.EventHandler(this.txtBuildNum_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(535, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(616, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 25);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(721, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvLimits
            // 
            this.dgvLimits.AllowUserToAddRows = false;
            this.dgvLimits.AllowUserToDeleteRows = false;
            this.dgvLimits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLimits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLimits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTypeName,
            this.clmLimValue});
            this.dgvLimits.Location = new System.Drawing.Point(12, 322);
            this.dgvLimits.MultiSelect = false;
            this.dgvLimits.Name = "dgvLimits";
            this.dgvLimits.ReadOnly = true;
            this.dgvLimits.RowHeadersWidth = 20;
            this.dgvLimits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLimits.Size = new System.Drawing.Size(411, 202);
            this.dgvLimits.TabIndex = 9;
            this.dgvLimits.SelectionChanged += new System.EventHandler(this.dgvLimits_SelectionChanged);
            // 
            // lblLimits
            // 
            this.lblLimits.AutoSize = true;
            this.lblLimits.Location = new System.Drawing.Point(12, 305);
            this.lblLimits.Name = "lblLimits";
            this.lblLimits.Size = new System.Drawing.Size(62, 14);
            this.lblLimits.TabIndex = 8;
            this.lblLimits.Text = "Пределы:";
            // 
            // btnAddLim
            // 
            this.btnAddLim.Location = new System.Drawing.Point(429, 377);
            this.btnAddLim.Name = "btnAddLim";
            this.btnAddLim.Size = new System.Drawing.Size(75, 25);
            this.btnAddLim.TabIndex = 12;
            this.btnAddLim.Text = "Добавить";
            this.btnAddLim.UseVisualStyleBackColor = true;
            this.btnAddLim.Click += new System.EventHandler(this.btnAddLim_Click);
            // 
            // btnEditLim
            // 
            this.btnEditLim.Location = new System.Drawing.Point(510, 377);
            this.btnEditLim.Name = "btnEditLim";
            this.btnEditLim.Size = new System.Drawing.Size(101, 25);
            this.btnEditLim.TabIndex = 13;
            this.btnEditLim.Text = "Редактировать";
            this.btnEditLim.UseVisualStyleBackColor = true;
            this.btnEditLim.Click += new System.EventHandler(this.btnEditLim_Click);
            // 
            // btnDeleteLim
            // 
            this.btnDeleteLim.Location = new System.Drawing.Point(617, 377);
            this.btnDeleteLim.Name = "btnDeleteLim";
            this.btnDeleteLim.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteLim.TabIndex = 14;
            this.btnDeleteLim.Text = "Удалить";
            this.btnDeleteLim.UseVisualStyleBackColor = true;
            this.btnDeleteLim.Click += new System.EventHandler(this.btnDeleteLim_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(721, 499);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(426, 322);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(97, 14);
            this.lblMatType.TabIndex = 10;
            this.lblMatType.Text = "Тип материала:";
            // 
            // txtMatType
            // 
            this.txtMatType.Location = new System.Drawing.Point(429, 339);
            this.txtMatType.Name = "txtMatType";
            this.txtMatType.Size = new System.Drawing.Size(197, 22);
            this.txtMatType.TabIndex = 11;
            this.txtMatType.TextChanged += new System.EventHandler(this.txtMatType_TextChanged);
            // 
            // btnChoose
            // 
            this.btnChoose.Enabled = false;
            this.btnChoose.Location = new System.Drawing.Point(721, 296);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 25);
            this.btnChoose.TabIndex = 16;
            this.btnChoose.Text = "Выбрать";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // clmTypeName
            // 
            this.clmTypeName.HeaderText = "Тип материала";
            this.clmTypeName.Name = "clmTypeName";
            this.clmTypeName.ReadOnly = true;
            this.clmTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmTypeName.Width = 120;
            // 
            // clmLimValue
            // 
            this.clmLimValue.HeaderText = "Величина критического предела, кг";
            this.clmLimValue.Name = "clmLimValue";
            this.clmLimValue.ReadOnly = true;
            this.clmLimValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmLimValue.Width = 250;
            // 
            // PlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 536);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtMatType);
            this.Controls.Add(this.lblMatType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteLim);
            this.Controls.Add(this.btnEditLim);
            this.Controls.Add(this.btnAddLim);
            this.Controls.Add(this.lblLimits);
            this.Controls.Add(this.dgvLimits);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBuildNum);
            this.Controls.Add(this.lblBuildNum);
            this.Controls.Add(this.txtZBMNum);
            this.Controls.Add(this.lblZBMNum);
            this.Controls.Add(this.dgvPlaces);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PlacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Места и пределы";
            this.Load += new System.EventHandler(this.PlacesForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlacesForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaces;
        private System.Windows.Forms.Label lblZBMNum;
        private System.Windows.Forms.TextBox txtZBMNum;
        private System.Windows.Forms.Label lblBuildNum;
        private System.Windows.Forms.TextBox txtBuildNum;
        private System.Windows.Forms.DataGridView dgvLimits;
        private System.Windows.Forms.Label lblLimits;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.TextBox txtMatType;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnChoose;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAddLim;
        internal System.Windows.Forms.Button btnEditLim;
        internal System.Windows.Forms.Button btnDeleteLim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumZBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLimValue;
    }
}
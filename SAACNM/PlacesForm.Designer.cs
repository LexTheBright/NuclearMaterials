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
            this.lblZBMNum = new System.Windows.Forms.Label();
            this.txtZBMNum = new System.Windows.Forms.TextBox();
            this.lblBuildNum = new System.Windows.Forms.Label();
            this.txtBuildNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvLimits = new System.Windows.Forms.DataGridView();
            this.btnAddLim = new System.Windows.Forms.Button();
            this.btnEditLim = new System.Windows.Forms.Button();
            this.btnDeleteLim = new System.Windows.Forms.Button();
            this.lblMatType = new System.Windows.Forms.Label();
            this.txtMatType = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clmNumZBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLimValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeMatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimits)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dgvPlaces.RowHeadersVisible = false;
            this.dgvPlaces.RowHeadersWidth = 20;
            this.dgvPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaces.Size = new System.Drawing.Size(784, 249);
            this.dgvPlaces.TabIndex = 0;
            this.dgvPlaces.SelectionChanged += new System.EventHandler(this.DgvPlaces_SelectionChanged);
            // 
            // lblZBMNum
            // 
            this.lblZBMNum.AutoSize = true;
            this.lblZBMNum.Location = new System.Drawing.Point(11, 15);
            this.lblZBMNum.Name = "lblZBMNum";
            this.lblZBMNum.Size = new System.Drawing.Size(47, 14);
            this.lblZBMNum.TabIndex = 1;
            this.lblZBMNum.Text = "№ ЗБМ";
            // 
            // txtZBMNum
            // 
            this.txtZBMNum.Location = new System.Drawing.Point(68, 12);
            this.txtZBMNum.Name = "txtZBMNum";
            this.txtZBMNum.Size = new System.Drawing.Size(100, 22);
            this.txtZBMNum.TabIndex = 2;
            this.txtZBMNum.TextChanged += new System.EventHandler(this.TxtZBMNum_TextChanged);
            // 
            // lblBuildNum
            // 
            this.lblBuildNum.AutoSize = true;
            this.lblBuildNum.Location = new System.Drawing.Point(178, 15);
            this.lblBuildNum.Name = "lblBuildNum";
            this.lblBuildNum.Size = new System.Drawing.Size(64, 14);
            this.lblBuildNum.TabIndex = 3;
            this.lblBuildNum.Text = "№ здания";
            // 
            // txtBuildNum
            // 
            this.txtBuildNum.Location = new System.Drawing.Point(252, 12);
            this.txtBuildNum.Name = "txtBuildNum";
            this.txtBuildNum.Size = new System.Drawing.Size(63, 22);
            this.txtBuildNum.TabIndex = 4;
            this.txtBuildNum.TextChanged += new System.EventHandler(this.TxtBuildNum_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(481, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(576, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(692, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvLimits
            // 
            this.dgvLimits.AllowUserToAddRows = false;
            this.dgvLimits.AllowUserToDeleteRows = false;
            this.dgvLimits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLimits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLimits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTypeName,
            this.clmLimValue,
            this.CodeMatType});
            this.dgvLimits.Location = new System.Drawing.Point(18, 322);
            this.dgvLimits.MultiSelect = false;
            this.dgvLimits.Name = "dgvLimits";
            this.dgvLimits.ReadOnly = true;
            this.dgvLimits.RowHeadersVisible = false;
            this.dgvLimits.RowHeadersWidth = 20;
            this.dgvLimits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLimits.Size = new System.Drawing.Size(451, 196);
            this.dgvLimits.TabIndex = 9;
            this.dgvLimits.SelectionChanged += new System.EventHandler(this.DgvLimits_SelectionChanged);
            // 
            // btnAddLim
            // 
            this.btnAddLim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddLim.Location = new System.Drawing.Point(49, 50);
            this.btnAddLim.Name = "btnAddLim";
            this.btnAddLim.Size = new System.Drawing.Size(227, 37);
            this.btnAddLim.TabIndex = 12;
            this.btnAddLim.Text = "Добавить";
            this.btnAddLim.UseVisualStyleBackColor = false;
            this.btnAddLim.Click += new System.EventHandler(this.BtnAddLim_Click);
            // 
            // btnEditLim
            // 
            this.btnEditLim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditLim.Location = new System.Drawing.Point(49, 98);
            this.btnEditLim.Name = "btnEditLim";
            this.btnEditLim.Size = new System.Drawing.Size(227, 37);
            this.btnEditLim.TabIndex = 13;
            this.btnEditLim.Text = "Редактировать";
            this.btnEditLim.UseVisualStyleBackColor = false;
            this.btnEditLim.Click += new System.EventHandler(this.BtnEditLim_Click);
            // 
            // btnDeleteLim
            // 
            this.btnDeleteLim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteLim.Location = new System.Drawing.Point(49, 148);
            this.btnDeleteLim.Name = "btnDeleteLim";
            this.btnDeleteLim.Size = new System.Drawing.Size(227, 37);
            this.btnDeleteLim.TabIndex = 14;
            this.btnDeleteLim.Text = "Удалить";
            this.btnDeleteLim.UseVisualStyleBackColor = false;
            this.btnDeleteLim.Click += new System.EventHandler(this.BtnDeleteLim_Click);
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(15, 20);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(93, 14);
            this.lblMatType.TabIndex = 10;
            this.lblMatType.Text = "Тип материала";
            // 
            // txtMatType
            // 
            this.txtMatType.Location = new System.Drawing.Point(118, 17);
            this.txtMatType.Name = "txtMatType";
            this.txtMatType.Size = new System.Drawing.Size(177, 22);
            this.txtMatType.TabIndex = 11;
            this.txtMatType.TextChanged += new System.EventHandler(this.TxtMatType_TextChanged);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoose.Enabled = false;
            this.btnChoose.Location = new System.Drawing.Point(386, 5);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(89, 34);
            this.btnChoose.TabIndex = 16;
            this.btnChoose.Text = "Выбрать";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblZBMNum);
            this.panel1.Controls.Add(this.txtZBMNum);
            this.panel1.Controls.Add(this.lblBuildNum);
            this.panel1.Controls.Add(this.txtBuildNum);
            this.panel1.Location = new System.Drawing.Point(12, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 43);
            this.panel1.TabIndex = 17;
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
            this.clmSecName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSecName.HeaderText = "Фамилия";
            this.clmSecName.Name = "clmSecName";
            this.clmSecName.ReadOnly = true;
            this.clmSecName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // clmTypeName
            // 
            this.clmTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTypeName.HeaderText = "Тип материала";
            this.clmTypeName.Name = "clmTypeName";
            this.clmTypeName.ReadOnly = true;
            this.clmTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmLimValue
            // 
            this.clmLimValue.HeaderText = "Величина критического предела, кг";
            this.clmLimValue.Name = "clmLimValue";
            this.clmLimValue.ReadOnly = true;
            this.clmLimValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmLimValue.Width = 250;
            // 
            // CodeMatType
            // 
            this.CodeMatType.HeaderText = "Код типа материала";
            this.CodeMatType.Name = "CodeMatType";
            this.CodeMatType.ReadOnly = true;
            this.CodeMatType.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.txtMatType);
            this.panel2.Controls.Add(this.btnDeleteLim);
            this.panel2.Controls.Add(this.lblMatType);
            this.panel2.Controls.Add(this.btnAddLim);
            this.panel2.Controls.Add(this.btnEditLim);
            this.panel2.Location = new System.Drawing.Point(475, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 196);
            this.panel2.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 218);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пределы";
            // 
            // PlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLimits);
            this.Controls.Add(this.dgvPlaces);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaces;
        private System.Windows.Forms.Label lblZBMNum;
        private System.Windows.Forms.TextBox txtZBMNum;
        private System.Windows.Forms.Label lblBuildNum;
        private System.Windows.Forms.TextBox txtBuildNum;
        private System.Windows.Forms.DataGridView dgvLimits;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeMatType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace SAACNM {
    partial class ShowAccUnits {
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
            this.dgvAccountUnits = new System.Windows.Forms.DataGridView();
            this.clmSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmZBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccountUnits
            // 
            this.dgvAccountUnits.AllowUserToAddRows = false;
            this.dgvAccountUnits.AllowUserToDeleteRows = false;
            this.dgvAccountUnits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAccountUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSerialNum,
            this.clmInvoice,
            this.clmScales,
            this.clmMass,
            this.clmFormType,
            this.clmMatType,
            this.clmZBM,
            this.clmBuild,
            this.clmRoom});
            this.dgvAccountUnits.Location = new System.Drawing.Point(12, 12);
            this.dgvAccountUnits.MultiSelect = false;
            this.dgvAccountUnits.Name = "dgvAccountUnits";
            this.dgvAccountUnits.ReadOnly = true;
            this.dgvAccountUnits.RowHeadersWidth = 20;
            this.dgvAccountUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountUnits.Size = new System.Drawing.Size(947, 336);
            this.dgvAccountUnits.TabIndex = 0;
            // 
            // clmSerialNum
            // 
            this.clmSerialNum.HeaderText = "Серийный номер";
            this.clmSerialNum.Name = "clmSerialNum";
            this.clmSerialNum.ReadOnly = true;
            this.clmSerialNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSerialNum.Width = 120;
            // 
            // clmInvoice
            // 
            this.clmInvoice.HeaderText = "№ накладной";
            this.clmInvoice.Name = "clmInvoice";
            this.clmInvoice.ReadOnly = true;
            this.clmInvoice.Width = 110;
            // 
            // clmScales
            // 
            this.clmScales.HeaderText = "№ весов";
            this.clmScales.Name = "clmScales";
            this.clmScales.ReadOnly = true;
            this.clmScales.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMass
            // 
            this.clmMass.HeaderText = "Вес нетто, кг";
            this.clmMass.Name = "clmMass";
            this.clmMass.ReadOnly = true;
            this.clmMass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmFormType
            // 
            this.clmFormType.HeaderText = "Форма";
            this.clmFormType.Name = "clmFormType";
            this.clmFormType.ReadOnly = true;
            this.clmFormType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFormType.Width = 110;
            // 
            // clmMatType
            // 
            this.clmMatType.HeaderText = "Тип материала";
            this.clmMatType.Name = "clmMatType";
            this.clmMatType.ReadOnly = true;
            this.clmMatType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMatType.Width = 130;
            // 
            // clmZBM
            // 
            this.clmZBM.HeaderText = "ЗБМ";
            this.clmZBM.Name = "clmZBM";
            this.clmZBM.ReadOnly = true;
            this.clmZBM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmZBM.Width = 70;
            // 
            // clmBuild
            // 
            this.clmBuild.HeaderText = "Здание";
            this.clmBuild.Name = "clmBuild";
            this.clmBuild.ReadOnly = true;
            this.clmBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBuild.Width = 80;
            // 
            // clmRoom
            // 
            this.clmRoom.HeaderText = "Помещение";
            this.clmRoom.Name = "clmRoom";
            this.clmRoom.ReadOnly = true;
            this.clmRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(884, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShowAccUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 402);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvAccountUnits);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowAccUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ядерные материалы";
            this.Load += new System.EventHandler(this.ShowAccUnits_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowAccUnits_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountUnits;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScales;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmZBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoom;
    }
}
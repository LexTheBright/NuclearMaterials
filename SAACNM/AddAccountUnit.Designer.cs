namespace SAACNM {
    partial class AddAccountUnit {
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clmSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMatForm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmMatType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmScaleNum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmContNum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPlace = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountUnits
            // 
            this.dgvAccountUnits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAccountUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSerialNum,
            this.clmMass,
            this.clmMatForm,
            this.clmMatType,
            this.clmScaleNum,
            this.clmContNum,
            this.clmPlace});
            this.dgvAccountUnits.Location = new System.Drawing.Point(12, 12);
            this.dgvAccountUnits.MultiSelect = false;
            this.dgvAccountUnits.Name = "dgvAccountUnits";
            this.dgvAccountUnits.RowHeadersVisible = false;
            this.dgvAccountUnits.RowHeadersWidth = 20;
            this.dgvAccountUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountUnits.Size = new System.Drawing.Size(994, 330);
            this.dgvAccountUnits.TabIndex = 0;
            this.dgvAccountUnits.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountUnits_CellValueChanged);
            this.dgvAccountUnits.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAccountUnits_DataError);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(12, 9);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(89, 34);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Ок";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(893, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(12, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 49);
            this.panel1.TabIndex = 24;
            // 
            // clmSerialNum
            // 
            this.clmSerialNum.HeaderText = "Идентификатор";
            this.clmSerialNum.Name = "clmSerialNum";
            this.clmSerialNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSerialNum.Width = 130;
            // 
            // clmMass
            // 
            this.clmMass.HeaderText = "Масса, кг";
            this.clmMass.Name = "clmMass";
            this.clmMass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMatForm
            // 
            this.clmMatForm.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmMatForm.HeaderText = "Форма материала";
            this.clmMatForm.Items.AddRange(new object[] {
            "Балк-форма",
            "Твердая форма",
            "Газ"});
            this.clmMatForm.Name = "clmMatForm";
            this.clmMatForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMatForm.Width = 135;
            // 
            // clmMatType
            // 
            this.clmMatType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmMatType.HeaderText = "Тип материала";
            this.clmMatType.Name = "clmMatType";
            this.clmMatType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMatType.Width = 130;
            // 
            // clmScaleNum
            // 
            this.clmScaleNum.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmScaleNum.HeaderText = "№ весов";
            this.clmScaleNum.Name = "clmScaleNum";
            this.clmScaleNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmScaleNum.Width = 130;
            // 
            // clmContNum
            // 
            this.clmContNum.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmContNum.HeaderText = "№ контейнера";
            this.clmContNum.Name = "clmContNum";
            this.clmContNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmContNum.Width = 130;
            // 
            // clmPlace
            // 
            this.clmPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPlace.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmPlace.HeaderText = "Местоположение";
            this.clmPlace.Name = "clmPlace";
            this.clmPlace.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AddAccountUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 400);
            this.Controls.Add(this.dgvAccountUnits);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddAccountUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список учетных единиц для накладной";
            this.Load += new System.EventHandler(this.AddAccountUnit_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddAccountUnit_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountUnits;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmMatForm;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmMatType;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmScaleNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmContNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmPlace;
    }
}
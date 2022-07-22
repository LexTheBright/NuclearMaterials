namespace SAACNM {
    partial class AccountUnitsForm {
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
            this.clmSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmZBMNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMatCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountUnits
            // 
            this.dgvAccountUnits.AllowUserToAddRows = false;
            this.dgvAccountUnits.AllowUserToDeleteRows = false;
            this.dgvAccountUnits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAccountUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSend,
            this.clmSerialNum,
            this.clmMatType,
            this.clmMass,
            this.clmZBMNum,
            this.clmBuildNum,
            this.clmRoomNum,
            this.clmMatCode});
            this.dgvAccountUnits.Location = new System.Drawing.Point(12, 12);
            this.dgvAccountUnits.MultiSelect = false;
            this.dgvAccountUnits.Name = "dgvAccountUnits";
            this.dgvAccountUnits.RowHeadersVisible = false;
            this.dgvAccountUnits.RowHeadersWidth = 20;
            this.dgvAccountUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountUnits.Size = new System.Drawing.Size(863, 392);
            this.dgvAccountUnits.TabIndex = 0;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(12, 8);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(89, 34);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Ок";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(762, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(12, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 49);
            this.panel1.TabIndex = 25;
            // 
            // clmSend
            // 
            this.clmSend.HeaderText = "Отправить?";
            this.clmSend.Name = "clmSend";
            this.clmSend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSend.TrueValue = "true";
            // 
            // clmSerialNum
            // 
            this.clmSerialNum.HeaderText = "Идентификатор";
            this.clmSerialNum.Name = "clmSerialNum";
            this.clmSerialNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSerialNum.Width = 150;
            // 
            // clmMatType
            // 
            this.clmMatType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMatType.HeaderText = "Тип материала";
            this.clmMatType.Name = "clmMatType";
            this.clmMatType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMass
            // 
            this.clmMass.HeaderText = "Масса, кг";
            this.clmMass.Name = "clmMass";
            this.clmMass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmZBMNum
            // 
            this.clmZBMNum.HeaderText = "№ ЗБМ";
            this.clmZBMNum.Name = "clmZBMNum";
            this.clmZBMNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmBuildNum
            // 
            this.clmBuildNum.HeaderText = "№ Здания";
            this.clmBuildNum.Name = "clmBuildNum";
            this.clmBuildNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmBuildNum.Width = 120;
            // 
            // clmRoomNum
            // 
            this.clmRoomNum.HeaderText = "№ Помещения";
            this.clmRoomNum.Name = "clmRoomNum";
            this.clmRoomNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmRoomNum.Width = 120;
            // 
            // clmMatCode
            // 
            this.clmMatCode.HeaderText = "Код типа материала";
            this.clmMatCode.Name = "clmMatCode";
            this.clmMatCode.Visible = false;
            // 
            // AccountUnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAccountUnits);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AccountUnitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список учетных единиц для накладной";
            this.Load += new System.EventHandler(this.AccountUnitsForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountUnitsForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUnits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountUnits;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmZBMNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatCode;
    }
}
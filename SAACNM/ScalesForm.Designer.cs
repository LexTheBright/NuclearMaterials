namespace SAACNM
{
    partial class ScalesForm
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
            this.dgvScales = new System.Windows.Forms.DataGridView();
            this.lblScaleNum = new System.Windows.Forms.Label();
            this.txtScaleNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clmScaleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScaleMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScaleSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalibDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScaleLim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScaleError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScales
            // 
            this.dgvScales.AllowUserToAddRows = false;
            this.dgvScales.AllowUserToDeleteRows = false;
            this.dgvScales.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvScales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmScaleNum,
            this.clmScaleMark,
            this.clmScaleSerial,
            this.clmCalibDate,
            this.clmScaleLim,
            this.clmScaleError});
            this.dgvScales.Location = new System.Drawing.Point(12, 12);
            this.dgvScales.MultiSelect = false;
            this.dgvScales.Name = "dgvScales";
            this.dgvScales.ReadOnly = true;
            this.dgvScales.RowHeadersVisible = false;
            this.dgvScales.RowHeadersWidth = 20;
            this.dgvScales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScales.Size = new System.Drawing.Size(700, 292);
            this.dgvScales.TabIndex = 0;
            this.dgvScales.SelectionChanged += new System.EventHandler(this.dgvScales_SelectionChanged);
            // 
            // lblScaleNum
            // 
            this.lblScaleNum.AutoSize = true;
            this.lblScaleNum.Location = new System.Drawing.Point(7, 15);
            this.lblScaleNum.Name = "lblScaleNum";
            this.lblScaleNum.Size = new System.Drawing.Size(61, 14);
            this.lblScaleNum.TabIndex = 1;
            this.lblScaleNum.Text = "№ весов:";
            // 
            // txtScaleNum
            // 
            this.txtScaleNum.Location = new System.Drawing.Point(74, 12);
            this.txtScaleNum.Name = "txtScaleNum";
            this.txtScaleNum.Size = new System.Drawing.Size(150, 22);
            this.txtScaleNum.TabIndex = 2;
            this.txtScaleNum.TextChanged += new System.EventHandler(this.txtScaleNum_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(397, 5);
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
            this.btnEdit.Location = new System.Drawing.Point(492, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(608, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblScaleNum);
            this.panel1.Controls.Add(this.txtScaleNum);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(12, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 43);
            this.panel1.TabIndex = 16;
            // 
            // clmScaleNum
            // 
            this.clmScaleNum.HeaderText = "№";
            this.clmScaleNum.Name = "clmScaleNum";
            this.clmScaleNum.ReadOnly = true;
            this.clmScaleNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmScaleNum.Width = 80;
            // 
            // clmScaleMark
            // 
            this.clmScaleMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmScaleMark.HeaderText = "Марка";
            this.clmScaleMark.Name = "clmScaleMark";
            this.clmScaleMark.ReadOnly = true;
            this.clmScaleMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmScaleSerial
            // 
            this.clmScaleSerial.HeaderText = "Серийный номер";
            this.clmScaleSerial.Name = "clmScaleSerial";
            this.clmScaleSerial.ReadOnly = true;
            this.clmScaleSerial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmScaleSerial.Width = 135;
            // 
            // clmCalibDate
            // 
            this.clmCalibDate.HeaderText = "Дата калибровки";
            this.clmCalibDate.Name = "clmCalibDate";
            this.clmCalibDate.ReadOnly = true;
            this.clmCalibDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCalibDate.Width = 135;
            // 
            // clmScaleLim
            // 
            this.clmScaleLim.HeaderText = "Предел, кг";
            this.clmScaleLim.Name = "clmScaleLim";
            this.clmScaleLim.ReadOnly = true;
            this.clmScaleLim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmScaleError
            // 
            this.clmScaleError.HeaderText = "Погрешность, %";
            this.clmScaleError.Name = "clmScaleError";
            this.clmScaleError.ReadOnly = true;
            this.clmScaleError.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmScaleError.Width = 125;
            // 
            // ScalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvScales);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ScalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Весы";
            this.Load += new System.EventHandler(this.ScalesForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScalesForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScales;
        private System.Windows.Forms.Label lblScaleNum;
        private System.Windows.Forms.TextBox txtScaleNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScaleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScaleMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScaleSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalibDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScaleLim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScaleError;
    }
}
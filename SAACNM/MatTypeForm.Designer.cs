namespace SAACNM
{
    partial class MatTypeForm
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
            this.dgvMaterialType = new System.Windows.Forms.DataGridView();
            this.lblMatType = new System.Windows.Forms.Label();
            this.txtMatType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clmMatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialType)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterialType
            // 
            this.dgvMaterialType.AllowUserToAddRows = false;
            this.dgvMaterialType.AllowUserToDeleteRows = false;
            this.dgvMaterialType.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMaterialType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMatName,
            this.clmComposition,
            this.clmMass});
            this.dgvMaterialType.Location = new System.Drawing.Point(12, 12);
            this.dgvMaterialType.MultiSelect = false;
            this.dgvMaterialType.Name = "dgvMaterialType";
            this.dgvMaterialType.ReadOnly = true;
            this.dgvMaterialType.RowHeadersVisible = false;
            this.dgvMaterialType.RowHeadersWidth = 20;
            this.dgvMaterialType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialType.Size = new System.Drawing.Size(664, 286);
            this.dgvMaterialType.TabIndex = 0;
            this.dgvMaterialType.SelectionChanged += new System.EventHandler(this.DgvMaterialType_SelectionChanged);
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(3, 14);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(86, 14);
            this.lblMatType.TabIndex = 1;
            this.lblMatType.Text = "Выделить тип";
            // 
            // txtMatType
            // 
            this.txtMatType.Location = new System.Drawing.Point(95, 11);
            this.txtMatType.Name = "txtMatType";
            this.txtMatType.Size = new System.Drawing.Size(200, 22);
            this.txtMatType.TabIndex = 2;
            this.txtMatType.TextChanged += new System.EventHandler(this.TxtMatType_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(358, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(453, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(569, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // clmMatName
            // 
            this.clmMatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMatName.HeaderText = "Название";
            this.clmMatName.Name = "clmMatName";
            this.clmMatName.ReadOnly = true;
            this.clmMatName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmComposition
            // 
            this.clmComposition.HeaderText = "Код ";
            this.clmComposition.Name = "clmComposition";
            this.clmComposition.ReadOnly = true;
            this.clmComposition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmComposition.Width = 250;
            // 
            // clmMass
            // 
            this.clmMass.HeaderText = "Масса";
            this.clmMass.Name = "clmMass";
            this.clmMass.ReadOnly = true;
            this.clmMass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMass.Width = 230;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtMatType);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblMatType);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(12, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 43);
            this.panel2.TabIndex = 17;
            // 
            // MatTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvMaterialType);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MatTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Типы материалов";
            this.Load += new System.EventHandler(this.MatTypeForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatTypeForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterialType;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.TextBox txtMatType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
        private System.Windows.Forms.Panel panel2;
    }
}
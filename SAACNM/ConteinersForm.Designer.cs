namespace SAACNM
{
    partial class ConteinersForm
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
            this.dgvConteiners = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContType = new System.Windows.Forms.Label();
            this.txtContType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteiners)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConteiners
            // 
            this.dgvConteiners.AllowUserToAddRows = false;
            this.dgvConteiners.AllowUserToDeleteRows = false;
            this.dgvConteiners.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvConteiners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConteiners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumber,
            this.clmContType,
            this.clmMat,
            this.clmWidth,
            this.clmHeight,
            this.clmMass});
            this.dgvConteiners.Location = new System.Drawing.Point(12, 12);
            this.dgvConteiners.MultiSelect = false;
            this.dgvConteiners.Name = "dgvConteiners";
            this.dgvConteiners.ReadOnly = true;
            this.dgvConteiners.RowHeadersVisible = false;
            this.dgvConteiners.RowHeadersWidth = 20;
            this.dgvConteiners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConteiners.Size = new System.Drawing.Size(580, 214);
            this.dgvConteiners.TabIndex = 0;
            this.dgvConteiners.SelectionChanged += new System.EventHandler(this.dgvConteiners_SelectionChanged);
            // 
            // clmNumber
            // 
            this.clmNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmNumber.HeaderText = "№";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumber.Width = 27;
            // 
            // clmContType
            // 
            this.clmContType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmContType.HeaderText = "Тип контейнера";
            this.clmContType.Name = "clmContType";
            this.clmContType.ReadOnly = true;
            this.clmContType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMat
            // 
            this.clmMat.HeaderText = "Материал";
            this.clmMat.Name = "clmMat";
            this.clmMat.ReadOnly = true;
            this.clmMat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMat.Width = 90;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ширина, см";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmHeight
            // 
            this.clmHeight.HeaderText = "Высота, см";
            this.clmHeight.Name = "clmHeight";
            this.clmHeight.ReadOnly = true;
            this.clmHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmHeight.Width = 95;
            // 
            // clmMass
            // 
            this.clmMass.HeaderText = "Масса, кг";
            this.clmMass.Name = "clmMass";
            this.clmMass.ReadOnly = true;
            this.clmMass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMass.Width = 90;
            // 
            // lblContType
            // 
            this.lblContType.AutoSize = true;
            this.lblContType.Location = new System.Drawing.Point(3, 15);
            this.lblContType.Name = "lblContType";
            this.lblContType.Size = new System.Drawing.Size(65, 14);
            this.lblContType.TabIndex = 1;
            this.lblContType.Text = "Найти тип";
            // 
            // txtContType
            // 
            this.txtContType.Location = new System.Drawing.Point(74, 12);
            this.txtContType.Name = "txtContType";
            this.txtContType.Size = new System.Drawing.Size(152, 22);
            this.txtContType.TabIndex = 4;
            this.txtContType.TextChanged += new System.EventHandler(this.txtContType_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(279, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(374, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(488, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblContType);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtContType);
            this.panel1.Location = new System.Drawing.Point(12, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 43);
            this.panel1.TabIndex = 16;
            // 
            // ConteinersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvConteiners);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConteinersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Контейнеры";
            this.Load += new System.EventHandler(this.ConteinersForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConteinersForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteiners)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConteiners;
        private System.Windows.Forms.Label lblContType;
        private System.Windows.Forms.TextBox txtContType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
        private System.Windows.Forms.Panel panel1;
    }
}
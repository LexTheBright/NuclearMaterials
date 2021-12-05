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
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContType = new System.Windows.Forms.Label();
            this.txtContType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteiners)).BeginInit();
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
            this.clmLength,
            this.clmWidth,
            this.clmHeight,
            this.clmMass});
            this.dgvConteiners.Location = new System.Drawing.Point(12, 12);
            this.dgvConteiners.MultiSelect = false;
            this.dgvConteiners.Name = "dgvConteiners";
            this.dgvConteiners.ReadOnly = true;
            this.dgvConteiners.RowHeadersWidth = 20;
            this.dgvConteiners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConteiners.Size = new System.Drawing.Size(580, 214);
            this.dgvConteiners.TabIndex = 0;
            this.dgvConteiners.SelectionChanged += new System.EventHandler(this.dgvConteiners_SelectionChanged);
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "№";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNumber.Width = 50;
            // 
            // clmContType
            // 
            this.clmContType.HeaderText = "Тип контейнера";
            this.clmContType.Name = "clmContType";
            this.clmContType.ReadOnly = true;
            this.clmContType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmContType.Width = 130;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Длина, см";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            this.clmLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmLength.Width = 90;
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
            this.lblContType.Location = new System.Drawing.Point(12, 234);
            this.lblContType.Name = "lblContType";
            this.lblContType.Size = new System.Drawing.Size(104, 14);
            this.lblContType.TabIndex = 1;
            this.lblContType.Text = "Тип контейнера:";
            // 
            // txtContType
            // 
            this.txtContType.Location = new System.Drawing.Point(12, 251);
            this.txtContType.Name = "txtContType";
            this.txtContType.Size = new System.Drawing.Size(170, 22);
            this.txtContType.TabIndex = 4;
            this.txtContType.TextChanged += new System.EventHandler(this.txtContType_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(323, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(404, 232);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 25);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ConteinersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 324);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContType);
            this.Controls.Add(this.lblContType);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConteiners;
        private System.Windows.Forms.Label lblContType;
        private System.Windows.Forms.TextBox txtContType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMass;
    }
}
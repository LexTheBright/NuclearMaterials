namespace SAACNM
{
    partial class PostForm
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
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.clmPostNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPostPowers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPostName = new System.Windows.Forms.Label();
            this.txtPostName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPostNum,
            this.clmPostName,
            this.clmPostPowers});
            this.dgvPosts.Location = new System.Drawing.Point(12, 12);
            this.dgvPosts.MultiSelect = false;
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ReadOnly = true;
            this.dgvPosts.RowHeadersWidth = 20;
            this.dgvPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosts.Size = new System.Drawing.Size(592, 244);
            this.dgvPosts.TabIndex = 0;
            this.dgvPosts.SelectionChanged += new System.EventHandler(this.dgvPosts_SelectionChanged);
            // 
            // clmPostNum
            // 
            this.clmPostNum.HeaderText = "№ должности";
            this.clmPostNum.Name = "clmPostNum";
            this.clmPostNum.ReadOnly = true;
            this.clmPostNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPostNum.Width = 120;
            // 
            // clmPostName
            // 
            this.clmPostName.HeaderText = "Наименование должности";
            this.clmPostName.Name = "clmPostName";
            this.clmPostName.ReadOnly = true;
            this.clmPostName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPostName.Width = 210;
            // 
            // clmPostPowers
            // 
            this.clmPostPowers.HeaderText = "Полномочия";
            this.clmPostPowers.Name = "clmPostPowers";
            this.clmPostPowers.ReadOnly = true;
            this.clmPostPowers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPostPowers.Width = 240;
            // 
            // lblPostName
            // 
            this.lblPostName.AutoSize = true;
            this.lblPostName.Location = new System.Drawing.Point(12, 269);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(75, 14);
            this.lblPostName.TabIndex = 1;
            this.lblPostName.Text = "Должность:";
            // 
            // txtPostName
            // 
            this.txtPostName.Location = new System.Drawing.Point(93, 266);
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.Size = new System.Drawing.Size(150, 22);
            this.txtPostName.TabIndex = 2;
            this.txtPostName.TextChanged += new System.EventHandler(this.txtPostName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(355, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(436, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPostName);
            this.Controls.Add(this.lblPostName);
            this.Controls.Add(this.dgvPosts);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label lblPostName;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostPowers;
    }
}
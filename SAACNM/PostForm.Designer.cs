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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgvPosts.RowHeadersVisible = false;
            this.dgvPosts.RowHeadersWidth = 20;
            this.dgvPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosts.Size = new System.Drawing.Size(592, 244);
            this.dgvPosts.TabIndex = 0;
            this.dgvPosts.SelectionChanged += new System.EventHandler(this.dgvPosts_SelectionChanged);
            // 
            // clmPostNum
            // 
            this.clmPostNum.HeaderText = "Код должности";
            this.clmPostNum.Name = "clmPostNum";
            this.clmPostNum.ReadOnly = true;
            this.clmPostNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPostNum.Width = 120;
            // 
            // clmPostName
            // 
            this.clmPostName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPostName.HeaderText = "Наименование должности";
            this.clmPostName.Name = "clmPostName";
            this.clmPostName.ReadOnly = true;
            this.clmPostName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPostName.Width = 148;
            // 
            // clmPostPowers
            // 
            this.clmPostPowers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPostPowers.HeaderText = "Полномочия";
            this.clmPostPowers.Name = "clmPostPowers";
            this.clmPostPowers.ReadOnly = true;
            this.clmPostPowers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPostName
            // 
            this.lblPostName.AutoSize = true;
            this.lblPostName.Location = new System.Drawing.Point(3, 15);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(71, 14);
            this.lblPostName.TabIndex = 1;
            this.lblPostName.Text = "Должность";
            // 
            // txtPostName
            // 
            this.txtPostName.Location = new System.Drawing.Point(80, 12);
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.Size = new System.Drawing.Size(150, 22);
            this.txtPostName.TabIndex = 2;
            this.txtPostName.TextChanged += new System.EventHandler(this.txtPostName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(289, 5);
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
            this.btnEdit.Location = new System.Drawing.Point(384, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(500, 5);
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
            this.panel1.Controls.Add(this.txtPostName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblPostName);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(12, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 43);
            this.panel1.TabIndex = 16;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 313);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label lblPostName;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostPowers;
    }
}
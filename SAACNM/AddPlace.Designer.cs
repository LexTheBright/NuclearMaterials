﻿namespace SAACNM
{
    partial class AddPlace
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
            this.lblZBMNum = new System.Windows.Forms.Label();
            this.txtZBMNum = new System.Windows.Forms.TextBox();
            this.lblBuildNum = new System.Windows.Forms.Label();
            this.txtBuildNum = new System.Windows.Forms.TextBox();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtSecName = new System.Windows.Forms.TextBox();
            this.btnChooseEmp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZBMNum
            // 
            this.lblZBMNum.AutoSize = true;
            this.lblZBMNum.Location = new System.Drawing.Point(12, 21);
            this.lblZBMNum.Name = "lblZBMNum";
            this.lblZBMNum.Size = new System.Drawing.Size(47, 14);
            this.lblZBMNum.TabIndex = 0;
            this.lblZBMNum.Text = "№ ЗБМ";
            // 
            // txtZBMNum
            // 
            this.txtZBMNum.Location = new System.Drawing.Point(15, 38);
            this.txtZBMNum.Name = "txtZBMNum";
            this.txtZBMNum.Size = new System.Drawing.Size(100, 22);
            this.txtZBMNum.TabIndex = 1;
            this.txtZBMNum.TextChanged += new System.EventHandler(this.TxtZBMNum_TextChanged);
            // 
            // lblBuildNum
            // 
            this.lblBuildNum.AutoSize = true;
            this.lblBuildNum.Location = new System.Drawing.Point(139, 21);
            this.lblBuildNum.Name = "lblBuildNum";
            this.lblBuildNum.Size = new System.Drawing.Size(64, 14);
            this.lblBuildNum.TabIndex = 2;
            this.lblBuildNum.Text = "№ здания";
            // 
            // txtBuildNum
            // 
            this.txtBuildNum.Location = new System.Drawing.Point(142, 38);
            this.txtBuildNum.Name = "txtBuildNum";
            this.txtBuildNum.Size = new System.Drawing.Size(122, 22);
            this.txtBuildNum.TabIndex = 3;
            this.txtBuildNum.TextChanged += new System.EventHandler(this.TxtBuildNum_TextChanged);
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Location = new System.Drawing.Point(12, 73);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(91, 14);
            this.lblRoomNum.TabIndex = 4;
            this.lblRoomNum.Text = "№ помещения";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(15, 90);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(100, 22);
            this.txtRoomNum.TabIndex = 5;
            this.txtRoomNum.TextChanged += new System.EventHandler(this.TxtRoomNum_TextChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(139, 73);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(158, 14);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Ответственный сотрудник";
            // 
            // txtSecName
            // 
            this.txtSecName.Location = new System.Drawing.Point(142, 90);
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.ReadOnly = true;
            this.txtSecName.Size = new System.Drawing.Size(122, 22);
            this.txtSecName.TabIndex = 7;
            // 
            // btnChooseEmp
            // 
            this.btnChooseEmp.Location = new System.Drawing.Point(272, 90);
            this.btnChooseEmp.Name = "btnChooseEmp";
            this.btnChooseEmp.Size = new System.Drawing.Size(33, 22);
            this.btnChooseEmp.TabIndex = 8;
            this.btnChooseEmp.Text = "...";
            this.btnChooseEmp.UseVisualStyleBackColor = true;
            this.btnChooseEmp.Click += new System.EventHandler(this.BtnChooseEmp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(216, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 43);
            this.panel1.TabIndex = 15;
            // 
            // AddPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 181);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChooseEmp);
            this.Controls.Add(this.txtSecName);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.txtBuildNum);
            this.Controls.Add(this.lblBuildNum);
            this.Controls.Add(this.txtZBMNum);
            this.Controls.Add(this.lblZBMNum);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Помещение";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPlace_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZBMNum;
        private System.Windows.Forms.TextBox txtZBMNum;
        private System.Windows.Forms.Label lblBuildNum;
        private System.Windows.Forms.TextBox txtBuildNum;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtSecName;
        private System.Windows.Forms.Button btnChooseEmp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}
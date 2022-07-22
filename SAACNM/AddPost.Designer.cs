namespace SAACNM
{
    partial class AddPost
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
            this.lblPostNum = new System.Windows.Forms.Label();
            this.txtPostNum = new System.Windows.Forms.TextBox();
            this.lblPostName = new System.Windows.Forms.Label();
            this.txtPostName = new System.Windows.Forms.TextBox();
            this.lblPostPower = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMove = new System.Windows.Forms.CheckBox();
            this.cbSend = new System.Windows.Forms.CheckBox();
            this.cbGet = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPostNum
            // 
            this.lblPostNum.AutoSize = true;
            this.lblPostNum.Location = new System.Drawing.Point(12, 9);
            this.lblPostNum.Name = "lblPostNum";
            this.lblPostNum.Size = new System.Drawing.Size(96, 14);
            this.lblPostNum.TabIndex = 0;
            this.lblPostNum.Text = "Код должности";
            // 
            // txtPostNum
            // 
            this.txtPostNum.Location = new System.Drawing.Point(15, 26);
            this.txtPostNum.Name = "txtPostNum";
            this.txtPostNum.Size = new System.Drawing.Size(150, 22);
            this.txtPostNum.TabIndex = 1;
            this.txtPostNum.TextChanged += new System.EventHandler(this.TxtPostNum_TextChanged);
            // 
            // lblPostName
            // 
            this.lblPostName.AutoSize = true;
            this.lblPostName.Location = new System.Drawing.Point(12, 62);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(158, 14);
            this.lblPostName.TabIndex = 2;
            this.lblPostName.Text = "Наименование должности";
            // 
            // txtPostName
            // 
            this.txtPostName.Location = new System.Drawing.Point(15, 79);
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.Size = new System.Drawing.Size(265, 22);
            this.txtPostName.TabIndex = 3;
            this.txtPostName.TextChanged += new System.EventHandler(this.TxtPostName_TextChanged);
            // 
            // lblPostPower
            // 
            this.lblPostPower.AutoSize = true;
            this.lblPostPower.Location = new System.Drawing.Point(12, 113);
            this.lblPostPower.Name = "lblPostPower";
            this.lblPostPower.Size = new System.Drawing.Size(79, 14);
            this.lblPostPower.TabIndex = 4;
            this.lblPostPower.Text = "Полномочия";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(191, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cbMove
            // 
            this.cbMove.AutoSize = true;
            this.cbMove.Location = new System.Drawing.Point(15, 132);
            this.cbMove.Name = "cbMove";
            this.cbMove.Size = new System.Drawing.Size(107, 18);
            this.cbMove.TabIndex = 5;
            this.cbMove.Text = "Перемещение";
            this.cbMove.UseVisualStyleBackColor = true;
            // 
            // cbSend
            // 
            this.cbSend.AutoSize = true;
            this.cbSend.Location = new System.Drawing.Point(128, 132);
            this.cbSend.Name = "cbSend";
            this.cbSend.Size = new System.Drawing.Size(102, 18);
            this.cbSend.TabIndex = 6;
            this.cbSend.Text = "Отправление";
            this.cbSend.UseVisualStyleBackColor = true;
            // 
            // cbGet
            // 
            this.cbGet.AutoSize = true;
            this.cbGet.Location = new System.Drawing.Point(15, 156);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(101, 18);
            this.cbGet.TabIndex = 7;
            this.cbGet.Text = "Поступление";
            this.cbGet.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 43);
            this.panel1.TabIndex = 16;
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.cbSend);
            this.Controls.Add(this.cbMove);
            this.Controls.Add(this.lblPostPower);
            this.Controls.Add(this.txtPostName);
            this.Controls.Add(this.lblPostName);
            this.Controls.Add(this.txtPostNum);
            this.Controls.Add(this.lblPostNum);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Должность";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPost_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostNum;
        private System.Windows.Forms.TextBox txtPostNum;
        private System.Windows.Forms.Label lblPostName;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.Label lblPostPower;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbMove;
        private System.Windows.Forms.CheckBox cbSend;
        private System.Windows.Forms.CheckBox cbGet;
        private System.Windows.Forms.Panel panel1;
    }
}
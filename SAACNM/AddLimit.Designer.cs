namespace SAACNM
{
    partial class AddLimit
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
            this.lblMatType = new System.Windows.Forms.Label();
            this.cbMatType = new System.Windows.Forms.ComboBox();
            this.lblLimAmount = new System.Windows.Forms.Label();
            this.txtLimValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(9, 9);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(97, 14);
            this.lblMatType.TabIndex = 0;
            this.lblMatType.Text = "Тип материала:";
            // 
            // cbMatType
            // 
            this.cbMatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatType.FormattingEnabled = true;
            this.cbMatType.Location = new System.Drawing.Point(12, 26);
            this.cbMatType.Name = "cbMatType";
            this.cbMatType.Size = new System.Drawing.Size(120, 22);
            this.cbMatType.TabIndex = 1;
            this.cbMatType.SelectedIndexChanged += new System.EventHandler(this.cbMatType_SelectedIndexChanged);
            // 
            // lblLimAmount
            // 
            this.lblLimAmount.AutoSize = true;
            this.lblLimAmount.Location = new System.Drawing.Point(9, 61);
            this.lblLimAmount.Name = "lblLimAmount";
            this.lblLimAmount.Size = new System.Drawing.Size(219, 14);
            this.lblLimAmount.TabIndex = 2;
            this.lblLimAmount.Text = "Величина критического предела, кг:";
            // 
            // txtLimValue
            // 
            this.txtLimValue.Location = new System.Drawing.Point(12, 78);
            this.txtLimValue.Name = "txtLimValue";
            this.txtLimValue.Size = new System.Drawing.Size(140, 22);
            this.txtLimValue.TabIndex = 3;
            this.txtLimValue.TextChanged += new System.EventHandler(this.txtLimValue_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 172);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLimValue);
            this.Controls.Add(this.lblLimAmount);
            this.Controls.Add(this.cbMatType);
            this.Controls.Add(this.lblMatType);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddLimit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пределы";
            this.Load += new System.EventHandler(this.AddLimit_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddLimit_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.ComboBox cbMatType;
        private System.Windows.Forms.Label lblLimAmount;
        private System.Windows.Forms.TextBox txtLimValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace SAACNM
{
    partial class AddMatType
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
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblCompose = new System.Windows.Forms.Label();
            this.txtCompose = new System.Windows.Forms.TextBox();
            this.lblMass = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(12, 9);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(157, 14);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Название типа материала:";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(15, 26);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(154, 22);
            this.txtTypeName.TabIndex = 1;
            this.txtTypeName.TextChanged += new System.EventHandler(this.txtTypeName_TextChanged);
            // 
            // lblCompose
            // 
            this.lblCompose.AutoSize = true;
            this.lblCompose.Location = new System.Drawing.Point(12, 60);
            this.lblCompose.Name = "lblCompose";
            this.lblCompose.Size = new System.Drawing.Size(123, 14);
            this.lblCompose.TabIndex = 2;
            this.lblCompose.Text = "Элементный состав:";
            // 
            // txtCompose
            // 
            this.txtCompose.Location = new System.Drawing.Point(15, 77);
            this.txtCompose.Name = "txtCompose";
            this.txtCompose.Size = new System.Drawing.Size(154, 22);
            this.txtCompose.TabIndex = 3;
            this.txtCompose.TextChanged += new System.EventHandler(this.txtCompose_TextChanged);
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(12, 111);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(44, 14);
            this.lblMass.TabIndex = 4;
            this.lblMass.Text = "Масса:";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(15, 128);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(154, 22);
            this.txtMass.TabIndex = 5;
            this.txtMass.TextChanged += new System.EventHandler(this.txtMass_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.txtCompose);
            this.Controls.Add(this.lblCompose);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.lblTypeName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddMatType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тип материала";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddMatType_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblCompose;
        private System.Windows.Forms.TextBox txtCompose;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace SAACNM
{
    partial class AddConteiners
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
            this.lblContNum = new System.Windows.Forms.Label();
            this.txtContNum = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblMass = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblContType = new System.Windows.Forms.Label();
            this.txtContType = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContNum
            // 
            this.lblContNum.AutoSize = true;
            this.lblContNum.Location = new System.Drawing.Point(12, 17);
            this.lblContNum.Name = "lblContNum";
            this.lblContNum.Size = new System.Drawing.Size(92, 14);
            this.lblContNum.TabIndex = 0;
            this.lblContNum.Text = "№ контейнера";
            // 
            // txtContNum
            // 
            this.txtContNum.Location = new System.Drawing.Point(15, 34);
            this.txtContNum.Name = "txtContNum";
            this.txtContNum.Size = new System.Drawing.Size(150, 22);
            this.txtContNum.TabIndex = 1;
            this.txtContNum.TextChanged += new System.EventHandler(this.txtContNum_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(182, 110);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(62, 14);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Материал";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(185, 127);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(150, 22);
            this.txtLength.TabIndex = 5;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 68);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 14);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Ширина, см";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(15, 85);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(150, 22);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 110);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(69, 14);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Высота, см";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(15, 127);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(150, 22);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(182, 68);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(130, 14);
            this.lblMass.TabIndex = 10;
            this.lblMass.Text = "Масса контейнера, кг";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(185, 85);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(150, 22);
            this.txtMass.TabIndex = 11;
            this.txtMass.TextChanged += new System.EventHandler(this.txtMass_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(15, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(257, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 34);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblContType
            // 
            this.lblContType.AutoSize = true;
            this.lblContType.Location = new System.Drawing.Point(182, 17);
            this.lblContType.Name = "lblContType";
            this.lblContType.Size = new System.Drawing.Size(100, 14);
            this.lblContType.TabIndex = 2;
            this.lblContType.Text = "Тип контейнера";
            // 
            // txtContType
            // 
            this.txtContType.Location = new System.Drawing.Point(185, 34);
            this.txtContType.Name = "txtContType";
            this.txtContType.Size = new System.Drawing.Size(150, 22);
            this.txtContType.TabIndex = 3;
            this.txtContType.TextChanged += new System.EventHandler(this.txtContType_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 43);
            this.panel1.TabIndex = 14;
            // 
            // AddConteiners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 216);
            this.Controls.Add(this.txtContType);
            this.Controls.Add(this.lblContType);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtContNum);
            this.Controls.Add(this.lblContNum);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddConteiners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Контейнер";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddConteiners_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContNum;
        private System.Windows.Forms.TextBox txtContNum;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblContType;
        private System.Windows.Forms.TextBox txtContType;
        private System.Windows.Forms.Panel panel1;
    }
}
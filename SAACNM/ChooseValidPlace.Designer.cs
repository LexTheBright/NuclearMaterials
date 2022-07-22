namespace SAACNM {
    partial class ChooseValidPlace {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblValidPlaces = new System.Windows.Forms.Label();
            this.cbValidPlaces = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValidPlaces
            // 
            this.lblValidPlaces.AutoSize = true;
            this.lblValidPlaces.Location = new System.Drawing.Point(12, 9);
            this.lblValidPlaces.Name = "lblValidPlaces";
            this.lblValidPlaces.Size = new System.Drawing.Size(173, 14);
            this.lblValidPlaces.TabIndex = 0;
            this.lblValidPlaces.Text = "Доступные местоположения";
            // 
            // cbValidPlaces
            // 
            this.cbValidPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValidPlaces.FormattingEnabled = true;
            this.cbValidPlaces.Location = new System.Drawing.Point(15, 26);
            this.cbValidPlaces.Name = "cbValidPlaces";
            this.cbValidPlaces.Size = new System.Drawing.Size(322, 22);
            this.cbValidPlaces.TabIndex = 1;
            this.cbValidPlaces.SelectedIndexChanged += new System.EventHandler(this.CbValidPlaces_SelectedIndexChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(12, 6);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(89, 34);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Ок";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(248, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 43);
            this.panel1.TabIndex = 15;
            // 
            // ChooseValidPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 116);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbValidPlaces);
            this.Controls.Add(this.lblValidPlaces);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ChooseValidPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Укажите новое местоположение";
            this.Load += new System.EventHandler(this.ChooseValidPlace_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChooseValidPlace_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidPlaces;
        private System.Windows.Forms.ComboBox cbValidPlaces;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}
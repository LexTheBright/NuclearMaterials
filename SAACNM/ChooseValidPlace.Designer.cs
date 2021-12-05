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
            this.SuspendLayout();
            // 
            // lblValidPlaces
            // 
            this.lblValidPlaces.AutoSize = true;
            this.lblValidPlaces.Location = new System.Drawing.Point(12, 9);
            this.lblValidPlaces.Name = "lblValidPlaces";
            this.lblValidPlaces.Size = new System.Drawing.Size(177, 14);
            this.lblValidPlaces.TabIndex = 0;
            this.lblValidPlaces.Text = "Доступные местоположения:";
            // 
            // cbValidPlaces
            // 
            this.cbValidPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValidPlaces.FormattingEnabled = true;
            this.cbValidPlaces.Location = new System.Drawing.Point(15, 26);
            this.cbValidPlaces.Name = "cbValidPlaces";
            this.cbValidPlaces.Size = new System.Drawing.Size(322, 22);
            this.cbValidPlaces.TabIndex = 1;
            this.cbValidPlaces.SelectedIndexChanged += new System.EventHandler(this.cbValidPlaces_SelectedIndexChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(15, 81);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 25);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Завершить";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChooseValidPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 116);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidPlaces;
        private System.Windows.Forms.ComboBox cbValidPlaces;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
    }
}
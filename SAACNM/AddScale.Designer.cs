namespace SAACNM
{
    partial class AddScale
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
            this.lblScaleNum = new System.Windows.Forms.Label();
            this.txtScaleNum = new System.Windows.Forms.TextBox();
            this.lblScaleMark = new System.Windows.Forms.Label();
            this.txtScaleMark = new System.Windows.Forms.TextBox();
            this.lblScaleSerial = new System.Windows.Forms.Label();
            this.txtScaleSerial = new System.Windows.Forms.TextBox();
            this.lblScaleLim = new System.Windows.Forms.Label();
            this.txtScaleLim = new System.Windows.Forms.TextBox();
            this.lblScaleError = new System.Windows.Forms.Label();
            this.txtScaleError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpScaleDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScaleNum
            // 
            this.lblScaleNum.AutoSize = true;
            this.lblScaleNum.Location = new System.Drawing.Point(9, 22);
            this.lblScaleNum.Name = "lblScaleNum";
            this.lblScaleNum.Size = new System.Drawing.Size(86, 14);
            this.lblScaleNum.TabIndex = 0;
            this.lblScaleNum.Text = "Инв. № весов";
            // 
            // txtScaleNum
            // 
            this.txtScaleNum.Location = new System.Drawing.Point(12, 39);
            this.txtScaleNum.Name = "txtScaleNum";
            this.txtScaleNum.Size = new System.Drawing.Size(150, 22);
            this.txtScaleNum.TabIndex = 1;
            this.txtScaleNum.TextChanged += new System.EventHandler(this.txtScaleNum_TextChanged);
            // 
            // lblScaleMark
            // 
            this.lblScaleMark.AutoSize = true;
            this.lblScaleMark.Location = new System.Drawing.Point(9, 124);
            this.lblScaleMark.Name = "lblScaleMark";
            this.lblScaleMark.Size = new System.Drawing.Size(77, 14);
            this.lblScaleMark.TabIndex = 2;
            this.lblScaleMark.Text = "Марка весов";
            // 
            // txtScaleMark
            // 
            this.txtScaleMark.Location = new System.Drawing.Point(12, 141);
            this.txtScaleMark.Name = "txtScaleMark";
            this.txtScaleMark.Size = new System.Drawing.Size(150, 22);
            this.txtScaleMark.TabIndex = 5;
            this.txtScaleMark.TextChanged += new System.EventHandler(this.txtScaleMark_TextChanged);
            // 
            // lblScaleSerial
            // 
            this.lblScaleSerial.AutoSize = true;
            this.lblScaleSerial.Location = new System.Drawing.Point(9, 73);
            this.lblScaleSerial.Name = "lblScaleSerial";
            this.lblScaleSerial.Size = new System.Drawing.Size(104, 14);
            this.lblScaleSerial.TabIndex = 4;
            this.lblScaleSerial.Text = "Серийный номер";
            // 
            // txtScaleSerial
            // 
            this.txtScaleSerial.Location = new System.Drawing.Point(12, 90);
            this.txtScaleSerial.Name = "txtScaleSerial";
            this.txtScaleSerial.Size = new System.Drawing.Size(150, 22);
            this.txtScaleSerial.TabIndex = 3;
            this.txtScaleSerial.TextChanged += new System.EventHandler(this.txtScaleSerial_TextChanged);
            // 
            // lblScaleLim
            // 
            this.lblScaleLim.AutoSize = true;
            this.lblScaleLim.Location = new System.Drawing.Point(187, 22);
            this.lblScaleLim.Name = "lblScaleLim";
            this.lblScaleLim.Size = new System.Drawing.Size(69, 14);
            this.lblScaleLim.TabIndex = 6;
            this.lblScaleLim.Text = "Предел, кг";
            // 
            // txtScaleLim
            // 
            this.txtScaleLim.Location = new System.Drawing.Point(190, 39);
            this.txtScaleLim.Name = "txtScaleLim";
            this.txtScaleLim.Size = new System.Drawing.Size(150, 22);
            this.txtScaleLim.TabIndex = 7;
            this.txtScaleLim.TextChanged += new System.EventHandler(this.txtScaleLim_TextChanged);
            // 
            // lblScaleError
            // 
            this.lblScaleError.AutoSize = true;
            this.lblScaleError.Location = new System.Drawing.Point(187, 73);
            this.lblScaleError.Name = "lblScaleError";
            this.lblScaleError.Size = new System.Drawing.Size(101, 14);
            this.lblScaleError.TabIndex = 8;
            this.lblScaleError.Text = "Погрешность, %";
            // 
            // txtScaleError
            // 
            this.txtScaleError.Location = new System.Drawing.Point(190, 90);
            this.txtScaleError.Name = "txtScaleError";
            this.txtScaleError.Size = new System.Drawing.Size(150, 22);
            this.txtScaleError.TabIndex = 9;
            this.txtScaleError.TextChanged += new System.EventHandler(this.txtScaleError_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата калибровки";
            // 
            // dtpScaleDate
            // 
            this.dtpScaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScaleDate.Location = new System.Drawing.Point(188, 141);
            this.dtpScaleDate.Name = "dtpScaleDate";
            this.dtpScaleDate.Size = new System.Drawing.Size(152, 22);
            this.dtpScaleDate.TabIndex = 11;
            this.dtpScaleDate.Value = new System.DateTime(2019, 6, 1, 12, 57, 52, 0);
            this.dtpScaleDate.ValueChanged += new System.EventHandler(this.dtpScaleDate_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(12, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(251, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 43);
            this.panel1.TabIndex = 14;
            // 
            // AddScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 239);
            this.Controls.Add(this.dtpScaleDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScaleError);
            this.Controls.Add(this.lblScaleError);
            this.Controls.Add(this.txtScaleLim);
            this.Controls.Add(this.lblScaleLim);
            this.Controls.Add(this.txtScaleSerial);
            this.Controls.Add(this.lblScaleSerial);
            this.Controls.Add(this.txtScaleMark);
            this.Controls.Add(this.lblScaleMark);
            this.Controls.Add(this.txtScaleNum);
            this.Controls.Add(this.lblScaleNum);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddScale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Весы";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddScale_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScaleNum;
        private System.Windows.Forms.TextBox txtScaleNum;
        private System.Windows.Forms.Label lblScaleMark;
        private System.Windows.Forms.TextBox txtScaleMark;
        private System.Windows.Forms.Label lblScaleSerial;
        private System.Windows.Forms.TextBox txtScaleSerial;
        private System.Windows.Forms.Label lblScaleLim;
        private System.Windows.Forms.TextBox txtScaleLim;
        private System.Windows.Forms.Label lblScaleError;
        private System.Windows.Forms.TextBox txtScaleError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpScaleDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}
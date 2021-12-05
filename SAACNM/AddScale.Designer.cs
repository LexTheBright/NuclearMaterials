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
            this.SuspendLayout();
            // 
            // lblScaleNum
            // 
            this.lblScaleNum.AutoSize = true;
            this.lblScaleNum.Location = new System.Drawing.Point(12, 9);
            this.lblScaleNum.Name = "lblScaleNum";
            this.lblScaleNum.Size = new System.Drawing.Size(90, 14);
            this.lblScaleNum.TabIndex = 0;
            this.lblScaleNum.Text = "Инв. № весов:";
            // 
            // txtScaleNum
            // 
            this.txtScaleNum.Location = new System.Drawing.Point(15, 26);
            this.txtScaleNum.Name = "txtScaleNum";
            this.txtScaleNum.Size = new System.Drawing.Size(150, 22);
            this.txtScaleNum.TabIndex = 1;
            this.txtScaleNum.TextChanged += new System.EventHandler(this.txtScaleNum_TextChanged);
            // 
            // lblScaleMark
            // 
            this.lblScaleMark.AutoSize = true;
            this.lblScaleMark.Location = new System.Drawing.Point(12, 60);
            this.lblScaleMark.Name = "lblScaleMark";
            this.lblScaleMark.Size = new System.Drawing.Size(81, 14);
            this.lblScaleMark.TabIndex = 2;
            this.lblScaleMark.Text = "Марка весов:";
            // 
            // txtScaleMark
            // 
            this.txtScaleMark.Location = new System.Drawing.Point(15, 77);
            this.txtScaleMark.Name = "txtScaleMark";
            this.txtScaleMark.Size = new System.Drawing.Size(150, 22);
            this.txtScaleMark.TabIndex = 3;
            this.txtScaleMark.TextChanged += new System.EventHandler(this.txtScaleMark_TextChanged);
            // 
            // lblScaleSerial
            // 
            this.lblScaleSerial.AutoSize = true;
            this.lblScaleSerial.Location = new System.Drawing.Point(187, 60);
            this.lblScaleSerial.Name = "lblScaleSerial";
            this.lblScaleSerial.Size = new System.Drawing.Size(108, 14);
            this.lblScaleSerial.TabIndex = 4;
            this.lblScaleSerial.Text = "Серийный номер:";
            // 
            // txtScaleSerial
            // 
            this.txtScaleSerial.Location = new System.Drawing.Point(190, 77);
            this.txtScaleSerial.Name = "txtScaleSerial";
            this.txtScaleSerial.Size = new System.Drawing.Size(150, 22);
            this.txtScaleSerial.TabIndex = 5;
            this.txtScaleSerial.TextChanged += new System.EventHandler(this.txtScaleSerial_TextChanged);
            // 
            // lblScaleLim
            // 
            this.lblScaleLim.AutoSize = true;
            this.lblScaleLim.Location = new System.Drawing.Point(12, 102);
            this.lblScaleLim.Name = "lblScaleLim";
            this.lblScaleLim.Size = new System.Drawing.Size(73, 14);
            this.lblScaleLim.TabIndex = 6;
            this.lblScaleLim.Text = "Предел, кг:";
            // 
            // txtScaleLim
            // 
            this.txtScaleLim.Location = new System.Drawing.Point(15, 119);
            this.txtScaleLim.Name = "txtScaleLim";
            this.txtScaleLim.Size = new System.Drawing.Size(150, 22);
            this.txtScaleLim.TabIndex = 7;
            this.txtScaleLim.TextChanged += new System.EventHandler(this.txtScaleLim_TextChanged);
            // 
            // lblScaleError
            // 
            this.lblScaleError.AutoSize = true;
            this.lblScaleError.Location = new System.Drawing.Point(187, 102);
            this.lblScaleError.Name = "lblScaleError";
            this.lblScaleError.Size = new System.Drawing.Size(105, 14);
            this.lblScaleError.TabIndex = 8;
            this.lblScaleError.Text = "Погрешность, %:";
            // 
            // txtScaleError
            // 
            this.txtScaleError.Location = new System.Drawing.Point(190, 119);
            this.txtScaleError.Name = "txtScaleError";
            this.txtScaleError.Size = new System.Drawing.Size(150, 22);
            this.txtScaleError.TabIndex = 9;
            this.txtScaleError.TextChanged += new System.EventHandler(this.txtScaleError_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата калибровки:";
            // 
            // dtpScaleDate
            // 
            this.dtpScaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScaleDate.Location = new System.Drawing.Point(15, 170);
            this.dtpScaleDate.Name = "dtpScaleDate";
            this.dtpScaleDate.Size = new System.Drawing.Size(104, 22);
            this.dtpScaleDate.TabIndex = 11;
            this.dtpScaleDate.Value = new System.DateTime(2019, 6, 1, 12, 57, 52, 0);
            this.dtpScaleDate.ValueChanged += new System.EventHandler(this.dtpScaleDate_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
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
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddScale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Весы";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddScale_KeyPress);
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
    }
}
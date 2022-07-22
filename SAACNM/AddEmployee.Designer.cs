namespace SAACNM
{
    partial class AddEmployee
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
            this.lblSecName = new System.Windows.Forms.Label();
            this.txtSecName = new System.Windows.Forms.TextBox();
            this.lblFirName = new System.Windows.Forms.Label();
            this.txtFirName = new System.Windows.Forms.TextBox();
            this.lblFatName = new System.Windows.Forms.Label();
            this.txtFatName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.cbPosts = new System.Windows.Forms.ComboBox();
            this.checkWork = new System.Windows.Forms.CheckBox();
            this.lblMale = new System.Windows.Forms.Label();
            this.cbMale = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblINN = new System.Windows.Forms.Label();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.lblSNILS = new System.Windows.Forms.Label();
            this.txtSNILS = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Location = new System.Drawing.Point(12, 15);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(59, 14);
            this.lblSecName.TabIndex = 0;
            this.lblSecName.Text = "Фамилия";
            // 
            // txtSecName
            // 
            this.txtSecName.Location = new System.Drawing.Point(15, 32);
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.Size = new System.Drawing.Size(150, 22);
            this.txtSecName.TabIndex = 1;
            this.txtSecName.TextChanged += new System.EventHandler(this.TxtSecName_TextChanged);
            // 
            // lblFirName
            // 
            this.lblFirName.AutoSize = true;
            this.lblFirName.Location = new System.Drawing.Point(12, 60);
            this.lblFirName.Name = "lblFirName";
            this.lblFirName.Size = new System.Drawing.Size(30, 14);
            this.lblFirName.TabIndex = 2;
            this.lblFirName.Text = "Имя";
            // 
            // txtFirName
            // 
            this.txtFirName.Location = new System.Drawing.Point(15, 77);
            this.txtFirName.Name = "txtFirName";
            this.txtFirName.Size = new System.Drawing.Size(150, 22);
            this.txtFirName.TabIndex = 3;
            this.txtFirName.TextChanged += new System.EventHandler(this.TxtFirName_TextChanged);
            // 
            // lblFatName
            // 
            this.lblFatName.AutoSize = true;
            this.lblFatName.Location = new System.Drawing.Point(12, 107);
            this.lblFatName.Name = "lblFatName";
            this.lblFatName.Size = new System.Drawing.Size(61, 14);
            this.lblFatName.TabIndex = 4;
            this.lblFatName.Text = "Отчество";
            // 
            // txtFatName
            // 
            this.txtFatName.Location = new System.Drawing.Point(15, 124);
            this.txtFatName.Name = "txtFatName";
            this.txtFatName.Size = new System.Drawing.Size(150, 22);
            this.txtFatName.TabIndex = 5;
            this.txtFatName.TextChanged += new System.EventHandler(this.TxtFatName_TextChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(206, 60);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(96, 14);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Дата рождения";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(209, 77);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(150, 22);
            this.dtpBirthDate.TabIndex = 9;
            this.dtpBirthDate.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.DtpBirthDate_ValueChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 153);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(42, 14);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Адрес";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 170);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(344, 22);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(12, 200);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(71, 14);
            this.lblPost.TabIndex = 12;
            this.lblPost.Text = "Должность";
            // 
            // cbPosts
            // 
            this.cbPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosts.FormattingEnabled = true;
            this.cbPosts.Location = new System.Drawing.Point(15, 217);
            this.cbPosts.Name = "cbPosts";
            this.cbPosts.Size = new System.Drawing.Size(150, 22);
            this.cbPosts.TabIndex = 13;
            this.cbPosts.SelectedIndexChanged += new System.EventHandler(this.CbPosts_SelectedIndexChanged);
            // 
            // checkWork
            // 
            this.checkWork.AutoSize = true;
            this.checkWork.Checked = true;
            this.checkWork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWork.Location = new System.Drawing.Point(251, 172);
            this.checkWork.Name = "checkWork";
            this.checkWork.Size = new System.Drawing.Size(97, 18);
            this.checkWork.TabIndex = 14;
            this.checkWork.Text = "Работающий";
            this.checkWork.UseVisualStyleBackColor = true;
            this.checkWork.CheckedChanged += new System.EventHandler(this.CheckWork_CheckedChanged);
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Location = new System.Drawing.Point(206, 13);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(29, 14);
            this.lblMale.TabIndex = 8;
            this.lblMale.Text = "Пол";
            // 
            // cbMale
            // 
            this.cbMale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMale.FormattingEnabled = true;
            this.cbMale.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.cbMale.Location = new System.Drawing.Point(209, 32);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(150, 22);
            this.cbMale.TabIndex = 7;
            this.cbMale.SelectedIndexChanged += new System.EventHandler(this.CbMale_SelectedIndexChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(206, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(105, 14);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Номер телефона";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(209, 124);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Location = new System.Drawing.Point(206, 200);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(54, 14);
            this.lblPassport.TabIndex = 15;
            this.lblPassport.Text = "Паспорт";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(209, 217);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(150, 22);
            this.txtPassport.TabIndex = 16;
            this.txtPassport.TextChanged += new System.EventHandler(this.TxtPassport_TextChanged);
            // 
            // lblINN
            // 
            this.lblINN.AutoSize = true;
            this.lblINN.Location = new System.Drawing.Point(206, 245);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(31, 14);
            this.lblINN.TabIndex = 17;
            this.lblINN.Text = "ИНН";
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(209, 262);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(150, 22);
            this.txtINN.TabIndex = 18;
            this.txtINN.TextChanged += new System.EventHandler(this.TxtINN_TextChanged);
            // 
            // lblSNILS
            // 
            this.lblSNILS.AutoSize = true;
            this.lblSNILS.Location = new System.Drawing.Point(206, 291);
            this.lblSNILS.Name = "lblSNILS";
            this.lblSNILS.Size = new System.Drawing.Size(45, 14);
            this.lblSNILS.TabIndex = 19;
            this.lblSNILS.Text = "СНИЛС";
            // 
            // txtSNILS
            // 
            this.txtSNILS.Location = new System.Drawing.Point(209, 308);
            this.txtSNILS.Name = "txtSNILS";
            this.txtSNILS.Size = new System.Drawing.Size(150, 22);
            this.txtSNILS.TabIndex = 20;
            this.txtSNILS.TextChanged += new System.EventHandler(this.TxtSNILS_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(15, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(273, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(-3, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 42);
            this.panel1.TabIndex = 23;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 395);
            this.Controls.Add(this.txtSNILS);
            this.Controls.Add(this.lblSNILS);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.lblINN);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.lblMale);
            this.Controls.Add(this.cbPosts);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtFatName);
            this.Controls.Add(this.lblFatName);
            this.Controls.Add(this.txtFirName);
            this.Controls.Add(this.lblFirName);
            this.Controls.Add(this.txtSecName);
            this.Controls.Add(this.lblSecName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkWork);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddEmployee_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.TextBox txtSecName;
        private System.Windows.Forms.Label lblFirName;
        private System.Windows.Forms.TextBox txtFirName;
        private System.Windows.Forms.Label lblFatName;
        private System.Windows.Forms.TextBox txtFatName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.ComboBox cbPosts;
        private System.Windows.Forms.CheckBox checkWork;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.ComboBox cbMale;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label lblINN;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.Label lblSNILS;
        private System.Windows.Forms.TextBox txtSNILS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}
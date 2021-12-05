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
            this.SuspendLayout();
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Location = new System.Drawing.Point(12, 9);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(63, 14);
            this.lblSecName.TabIndex = 0;
            this.lblSecName.Text = "Фамилия:";
            // 
            // txtSecName
            // 
            this.txtSecName.Location = new System.Drawing.Point(15, 26);
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.Size = new System.Drawing.Size(150, 22);
            this.txtSecName.TabIndex = 1;
            this.txtSecName.TextChanged += new System.EventHandler(this.txtSecName_TextChanged);
            // 
            // lblFirName
            // 
            this.lblFirName.AutoSize = true;
            this.lblFirName.Location = new System.Drawing.Point(206, 9);
            this.lblFirName.Name = "lblFirName";
            this.lblFirName.Size = new System.Drawing.Size(34, 14);
            this.lblFirName.TabIndex = 2;
            this.lblFirName.Text = "Имя:";
            // 
            // txtFirName
            // 
            this.txtFirName.Location = new System.Drawing.Point(209, 26);
            this.txtFirName.Name = "txtFirName";
            this.txtFirName.Size = new System.Drawing.Size(150, 22);
            this.txtFirName.TabIndex = 3;
            this.txtFirName.TextChanged += new System.EventHandler(this.txtFirName_TextChanged);
            // 
            // lblFatName
            // 
            this.lblFatName.AutoSize = true;
            this.lblFatName.Location = new System.Drawing.Point(12, 51);
            this.lblFatName.Name = "lblFatName";
            this.lblFatName.Size = new System.Drawing.Size(65, 14);
            this.lblFatName.TabIndex = 4;
            this.lblFatName.Text = "Отчество:";
            // 
            // txtFatName
            // 
            this.txtFatName.Location = new System.Drawing.Point(15, 68);
            this.txtFatName.Name = "txtFatName";
            this.txtFatName.Size = new System.Drawing.Size(150, 22);
            this.txtFatName.TabIndex = 5;
            this.txtFatName.TextChanged += new System.EventHandler(this.txtFatName_TextChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(206, 51);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(100, 14);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(209, 68);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(110, 22);
            this.dtpBirthDate.TabIndex = 7;
            this.dtpBirthDate.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 147);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 14);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Адрес:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 164);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 22);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(12, 198);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(75, 14);
            this.lblPost.TabIndex = 12;
            this.lblPost.Text = "Должность:";
            // 
            // cbPosts
            // 
            this.cbPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosts.FormattingEnabled = true;
            this.cbPosts.Location = new System.Drawing.Point(15, 215);
            this.cbPosts.Name = "cbPosts";
            this.cbPosts.Size = new System.Drawing.Size(150, 22);
            this.cbPosts.TabIndex = 13;
            this.cbPosts.SelectedIndexChanged += new System.EventHandler(this.cbPosts_SelectedIndexChanged);
            // 
            // checkWork
            // 
            this.checkWork.AutoSize = true;
            this.checkWork.Checked = true;
            this.checkWork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWork.Location = new System.Drawing.Point(209, 217);
            this.checkWork.Name = "checkWork";
            this.checkWork.Size = new System.Drawing.Size(97, 18);
            this.checkWork.TabIndex = 14;
            this.checkWork.Text = "Работающий";
            this.checkWork.UseVisualStyleBackColor = true;
            this.checkWork.CheckedChanged += new System.EventHandler(this.checkWork_CheckedChanged);
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Location = new System.Drawing.Point(12, 93);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(33, 14);
            this.lblMale.TabIndex = 8;
            this.lblMale.Text = "Пол:";
            // 
            // cbMale
            // 
            this.cbMale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMale.FormattingEnabled = true;
            this.cbMale.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.cbMale.Location = new System.Drawing.Point(15, 112);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(100, 22);
            this.cbMale.TabIndex = 9;
            this.cbMale.SelectedIndexChanged += new System.EventHandler(this.cbMale_SelectedIndexChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(206, 93);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 14);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Номер телефона:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(209, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Location = new System.Drawing.Point(12, 249);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(126, 14);
            this.lblPassport.TabIndex = 15;
            this.lblPassport.Text = "Паспортные данные:";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(15, 266);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(150, 22);
            this.txtPassport.TabIndex = 16;
            this.txtPassport.TextChanged += new System.EventHandler(this.txtPassport_TextChanged);
            // 
            // lblINN
            // 
            this.lblINN.AutoSize = true;
            this.lblINN.Location = new System.Drawing.Point(12, 291);
            this.lblINN.Name = "lblINN";
            this.lblINN.Size = new System.Drawing.Size(35, 14);
            this.lblINN.TabIndex = 17;
            this.lblINN.Text = "ИНН:";
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(15, 308);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(150, 22);
            this.txtINN.TabIndex = 18;
            this.txtINN.TextChanged += new System.EventHandler(this.txtINN_TextChanged);
            // 
            // lblSNILS
            // 
            this.lblSNILS.AutoSize = true;
            this.lblSNILS.Location = new System.Drawing.Point(12, 333);
            this.lblSNILS.Name = "lblSNILS";
            this.lblSNILS.Size = new System.Drawing.Size(49, 14);
            this.lblSNILS.TabIndex = 19;
            this.lblSNILS.Text = "СНИЛС:";
            // 
            // txtSNILS
            // 
            this.txtSNILS.Location = new System.Drawing.Point(15, 350);
            this.txtSNILS.Name = "txtSNILS";
            this.txtSNILS.Size = new System.Drawing.Size(150, 22);
            this.txtSNILS.TabIndex = 20;
            this.txtSNILS.TextChanged += new System.EventHandler(this.txtSNILS_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.checkWork);
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
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddEmployee_KeyPress);
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
    }
}
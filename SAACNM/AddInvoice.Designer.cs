namespace SAACNM {
    partial class AddInvoice {
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
            this.lblInvType = new System.Windows.Forms.Label();
            this.cbInvType = new System.Windows.Forms.ComboBox();
            this.lblPartner = new System.Windows.Forms.Label();
            this.cbPartner = new System.Windows.Forms.ComboBox();
            this.lblRespEmp = new System.Windows.Forms.Label();
            this.txtRespEmp = new System.Windows.Forms.TextBox();
            this.btnChooseResp = new System.Windows.Forms.Button();
            this.lblStartEmp = new System.Windows.Forms.Label();
            this.txtStartEmp = new System.Windows.Forms.TextBox();
            this.btnChooseSt = new System.Windows.Forms.Button();
            this.lblEndEmp = new System.Windows.Forms.Label();
            this.txtEndEmp = new System.Windows.Forms.TextBox();
            this.btnChooseEnd = new System.Windows.Forms.Button();
            this.lblAgent = new System.Windows.Forms.Label();
            this.cbAgent = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInvNum = new System.Windows.Forms.Label();
            this.txtInvNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvType
            // 
            this.lblInvType.AutoSize = true;
            this.lblInvType.Location = new System.Drawing.Point(12, 9);
            this.lblInvType.Name = "lblInvType";
            this.lblInvType.Size = new System.Drawing.Size(93, 14);
            this.lblInvType.TabIndex = 0;
            this.lblInvType.Text = "Тип накладной";
            // 
            // cbInvType
            // 
            this.cbInvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvType.FormattingEnabled = true;
            this.cbInvType.Items.AddRange(new object[] {
            "Перемещение",
            "Отправление",
            "Поступление"});
            this.cbInvType.Location = new System.Drawing.Point(15, 26);
            this.cbInvType.Name = "cbInvType";
            this.cbInvType.Size = new System.Drawing.Size(208, 22);
            this.cbInvType.TabIndex = 1;
            this.cbInvType.SelectedIndexChanged += new System.EventHandler(this.cbInvType_SelectedIndexChanged);
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Location = new System.Drawing.Point(12, 120);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(131, 14);
            this.lblPartner.TabIndex = 4;
            this.lblPartner.Text = "Организация-партнер";
            // 
            // cbPartner
            // 
            this.cbPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartner.FormattingEnabled = true;
            this.cbPartner.Location = new System.Drawing.Point(15, 137);
            this.cbPartner.Name = "cbPartner";
            this.cbPartner.Size = new System.Drawing.Size(208, 22);
            this.cbPartner.TabIndex = 5;
            this.cbPartner.SelectedIndexChanged += new System.EventHandler(this.cbPartner_SelectedIndexChanged);
            // 
            // lblRespEmp
            // 
            this.lblRespEmp.AutoSize = true;
            this.lblRespEmp.Location = new System.Drawing.Point(252, 52);
            this.lblRespEmp.Name = "lblRespEmp";
            this.lblRespEmp.Size = new System.Drawing.Size(146, 14);
            this.lblRespEmp.TabIndex = 12;
            this.lblRespEmp.Text = "Подписавший сотрудник";
            // 
            // txtRespEmp
            // 
            this.txtRespEmp.Location = new System.Drawing.Point(255, 69);
            this.txtRespEmp.Name = "txtRespEmp";
            this.txtRespEmp.ReadOnly = true;
            this.txtRespEmp.Size = new System.Drawing.Size(207, 22);
            this.txtRespEmp.TabIndex = 13;
            // 
            // btnChooseResp
            // 
            this.btnChooseResp.Location = new System.Drawing.Point(468, 69);
            this.btnChooseResp.Name = "btnChooseResp";
            this.btnChooseResp.Size = new System.Drawing.Size(27, 22);
            this.btnChooseResp.TabIndex = 14;
            this.btnChooseResp.Text = "...";
            this.btnChooseResp.UseVisualStyleBackColor = true;
            this.btnChooseResp.Click += new System.EventHandler(this.btnChooseResp_Click);
            // 
            // lblStartEmp
            // 
            this.lblStartEmp.AutoSize = true;
            this.lblStartEmp.Location = new System.Drawing.Point(252, 120);
            this.lblStartEmp.Name = "lblStartEmp";
            this.lblStartEmp.Size = new System.Drawing.Size(143, 14);
            this.lblStartEmp.TabIndex = 15;
            this.lblStartEmp.Text = "Сотрудник-отправитель";
            // 
            // txtStartEmp
            // 
            this.txtStartEmp.Enabled = false;
            this.txtStartEmp.Location = new System.Drawing.Point(255, 137);
            this.txtStartEmp.Name = "txtStartEmp";
            this.txtStartEmp.ReadOnly = true;
            this.txtStartEmp.Size = new System.Drawing.Size(207, 22);
            this.txtStartEmp.TabIndex = 16;
            // 
            // btnChooseSt
            // 
            this.btnChooseSt.Enabled = false;
            this.btnChooseSt.Location = new System.Drawing.Point(468, 137);
            this.btnChooseSt.Name = "btnChooseSt";
            this.btnChooseSt.Size = new System.Drawing.Size(27, 22);
            this.btnChooseSt.TabIndex = 17;
            this.btnChooseSt.Text = "...";
            this.btnChooseSt.UseVisualStyleBackColor = true;
            this.btnChooseSt.Click += new System.EventHandler(this.btnChooseSt_Click);
            // 
            // lblEndEmp
            // 
            this.lblEndEmp.AutoSize = true;
            this.lblEndEmp.Location = new System.Drawing.Point(252, 162);
            this.lblEndEmp.Name = "lblEndEmp";
            this.lblEndEmp.Size = new System.Drawing.Size(137, 14);
            this.lblEndEmp.TabIndex = 18;
            this.lblEndEmp.Text = "Сотрудник-получатель";
            // 
            // txtEndEmp
            // 
            this.txtEndEmp.Enabled = false;
            this.txtEndEmp.Location = new System.Drawing.Point(255, 179);
            this.txtEndEmp.Name = "txtEndEmp";
            this.txtEndEmp.ReadOnly = true;
            this.txtEndEmp.Size = new System.Drawing.Size(207, 22);
            this.txtEndEmp.TabIndex = 19;
            // 
            // btnChooseEnd
            // 
            this.btnChooseEnd.Enabled = false;
            this.btnChooseEnd.Location = new System.Drawing.Point(468, 179);
            this.btnChooseEnd.Name = "btnChooseEnd";
            this.btnChooseEnd.Size = new System.Drawing.Size(27, 22);
            this.btnChooseEnd.TabIndex = 20;
            this.btnChooseEnd.Text = "...";
            this.btnChooseEnd.UseVisualStyleBackColor = true;
            this.btnChooseEnd.Click += new System.EventHandler(this.btnChooseEnd_Click);
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(12, 162);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(168, 14);
            this.lblAgent.TabIndex = 6;
            this.lblAgent.Text = "Представитель организации";
            // 
            // cbAgent
            // 
            this.cbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgent.FormattingEnabled = true;
            this.cbAgent.Location = new System.Drawing.Point(15, 179);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(208, 22);
            this.cbAgent.TabIndex = 7;
            this.cbAgent.SelectedIndexChanged += new System.EventHandler(this.cbAgent_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(252, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 14);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Дата";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(255, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 22);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.Value = new System.DateTime(2019, 6, 23, 17, 58, 51, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(148, 259);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 14);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Время:";
            this.lblTime.Visible = false;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(213, 251);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 11;
            this.txtTime.Visible = false;
            this.txtTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTime_MaskInputRejected);
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(15, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(406, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInvNum
            // 
            this.lblInvNum.AutoSize = true;
            this.lblInvNum.Location = new System.Drawing.Point(12, 52);
            this.lblInvNum.Name = "lblInvNum";
            this.lblInvNum.Size = new System.Drawing.Size(85, 14);
            this.lblInvNum.TabIndex = 2;
            this.lblInvNum.Text = "№ накладной";
            // 
            // txtInvNum
            // 
            this.txtInvNum.Location = new System.Drawing.Point(15, 69);
            this.txtInvNum.Name = "txtInvNum";
            this.txtInvNum.Size = new System.Drawing.Size(208, 22);
            this.txtInvNum.TabIndex = 3;
            this.txtInvNum.TextChanged += new System.EventHandler(this.txtInvNum_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 43);
            this.panel1.TabIndex = 23;
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInvNum);
            this.Controls.Add(this.lblInvNum);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbAgent);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.btnChooseEnd);
            this.Controls.Add(this.txtEndEmp);
            this.Controls.Add(this.lblEndEmp);
            this.Controls.Add(this.btnChooseSt);
            this.Controls.Add(this.txtStartEmp);
            this.Controls.Add(this.lblStartEmp);
            this.Controls.Add(this.btnChooseResp);
            this.Controls.Add(this.txtRespEmp);
            this.Controls.Add(this.lblRespEmp);
            this.Controls.Add(this.cbPartner);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.cbInvType);
            this.Controls.Add(this.lblInvType);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Накладная";
            this.Load += new System.EventHandler(this.AddInvoice_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddInvoice_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvType;
        private System.Windows.Forms.ComboBox cbInvType;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.ComboBox cbPartner;
        private System.Windows.Forms.Label lblRespEmp;
        private System.Windows.Forms.TextBox txtRespEmp;
        private System.Windows.Forms.Button btnChooseResp;
        private System.Windows.Forms.Label lblStartEmp;
        private System.Windows.Forms.TextBox txtStartEmp;
        private System.Windows.Forms.Button btnChooseSt;
        private System.Windows.Forms.Label lblEndEmp;
        private System.Windows.Forms.TextBox txtEndEmp;
        private System.Windows.Forms.Button btnChooseEnd;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.ComboBox cbAgent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInvNum;
        private System.Windows.Forms.TextBox txtInvNum;
        private System.Windows.Forms.Panel panel1;
    }
}
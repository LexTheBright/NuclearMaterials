namespace SAACNM
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHandbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPartners = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaterialsType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContainers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsScales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPlaces = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPosts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHandbooks,
            this.tsLocation,
            this.tsStaff,
            this.tsDocuments});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainStrip";
            // 
            // tsHandbooks
            // 
            this.tsHandbooks.BackColor = System.Drawing.SystemColors.Control;
            this.tsHandbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPartners,
            this.tsMaterialsType,
            this.tsContainers,
            this.tsScales,
            this.tsMaterials});
            this.tsHandbooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsHandbooks.Name = "tsHandbooks";
            this.tsHandbooks.Size = new System.Drawing.Size(119, 25);
            this.tsHandbooks.Text = "Справочники";
            // 
            // tsPartners
            // 
            this.tsPartners.Name = "tsPartners";
            this.tsPartners.Size = new System.Drawing.Size(206, 26);
            this.tsPartners.Text = "Партнеры";
            this.tsPartners.Click += new System.EventHandler(this.TsPartners_Click);
            // 
            // tsMaterialsType
            // 
            this.tsMaterialsType.Name = "tsMaterialsType";
            this.tsMaterialsType.Size = new System.Drawing.Size(206, 26);
            this.tsMaterialsType.Text = "Типы материалов";
            this.tsMaterialsType.Click += new System.EventHandler(this.TsMaterialsType_Click);
            // 
            // tsContainers
            // 
            this.tsContainers.Name = "tsContainers";
            this.tsContainers.Size = new System.Drawing.Size(206, 26);
            this.tsContainers.Text = "Контейнеры";
            this.tsContainers.Click += new System.EventHandler(this.TsContainers_Click);
            // 
            // tsScales
            // 
            this.tsScales.Name = "tsScales";
            this.tsScales.Size = new System.Drawing.Size(206, 26);
            this.tsScales.Text = "Весы";
            this.tsScales.Click += new System.EventHandler(this.TsScales_Click);
            // 
            // tsMaterials
            // 
            this.tsMaterials.Name = "tsMaterials";
            this.tsMaterials.Size = new System.Drawing.Size(206, 26);
            this.tsMaterials.Text = "Материалы";
            this.tsMaterials.Click += new System.EventHandler(this.TsMaterials_Click);
            // 
            // tsLocation
            // 
            this.tsLocation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPlaces});
            this.tsLocation.Name = "tsLocation";
            this.tsLocation.Size = new System.Drawing.Size(127, 25);
            this.tsLocation.Text = "Расположение";
            // 
            // tsPlaces
            // 
            this.tsPlaces.Name = "tsPlaces";
            this.tsPlaces.Size = new System.Drawing.Size(203, 26);
            this.tsPlaces.Text = "Места и пределы";
            this.tsPlaces.Click += new System.EventHandler(this.TsPlaces_Click);
            // 
            // tsStaff
            // 
            this.tsStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPosts,
            this.tsEmployees});
            this.tsStaff.Name = "tsStaff";
            this.tsStaff.Size = new System.Drawing.Size(68, 25);
            this.tsStaff.Text = "Кадры";
            // 
            // tsPosts
            // 
            this.tsPosts.Name = "tsPosts";
            this.tsPosts.Size = new System.Drawing.Size(167, 26);
            this.tsPosts.Text = "Должности";
            this.tsPosts.Click += new System.EventHandler(this.TsPosts_Click);
            // 
            // tsEmployees
            // 
            this.tsEmployees.Name = "tsEmployees";
            this.tsEmployees.Size = new System.Drawing.Size(167, 26);
            this.tsEmployees.Text = "Сотрудники";
            this.tsEmployees.Click += new System.EventHandler(this.TsEmployees_Click);
            // 
            // tsDocuments
            // 
            this.tsDocuments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInvoices});
            this.tsDocuments.Name = "tsDocuments";
            this.tsDocuments.Size = new System.Drawing.Size(104, 25);
            this.tsDocuments.Text = "Документы";
            // 
            // tsInvoices
            // 
            this.tsInvoices.Name = "tsInvoices";
            this.tsInvoices.Size = new System.Drawing.Size(160, 26);
            this.tsInvoices.Text = "Накладные";
            this.tsInvoices.Click += new System.EventHandler(this.TsInvoices_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SAACNM.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система УиК ЯМ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHandbooks;
        private System.Windows.Forms.ToolStripMenuItem tsPartners;
        private System.Windows.Forms.ToolStripMenuItem tsMaterialsType;
        private System.Windows.Forms.ToolStripMenuItem tsContainers;
        private System.Windows.Forms.ToolStripMenuItem tsScales;
        private System.Windows.Forms.ToolStripMenuItem tsMaterials;
        private System.Windows.Forms.ToolStripMenuItem tsLocation;
        private System.Windows.Forms.ToolStripMenuItem tsPlaces;
        private System.Windows.Forms.ToolStripMenuItem tsStaff;
        private System.Windows.Forms.ToolStripMenuItem tsPosts;
        private System.Windows.Forms.ToolStripMenuItem tsEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsDocuments;
        private System.Windows.Forms.ToolStripMenuItem tsInvoices;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


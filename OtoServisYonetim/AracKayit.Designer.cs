namespace OtoServisYonetim
{
    partial class AracKayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasiNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet5 = new OtoServisYonetim.OtoServisYonetimDataSet5();
            this.araclarTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet5TableAdapters.AraclarTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRAÇKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVİSKAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMDETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARÇADETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtMotorNumarasi = new System.Windows.Forms.TextBox();
            this.txtSasiNumarasi = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSasiNumarasi = new System.Windows.Forms.Label();
            this.lblMotorNumarasi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(513, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARAÇ KAYIT SİSTEMİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracIDDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.sasiNumarasiDataGridViewTextBoxColumn,
            this.motorNumarasiDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.araclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 281);
            this.dataGridView1.TabIndex = 3;
            // 
            // aracIDDataGridViewTextBoxColumn
            // 
            this.aracIDDataGridViewTextBoxColumn.DataPropertyName = "AracID";
            this.aracIDDataGridViewTextBoxColumn.HeaderText = "AracID";
            this.aracIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracIDDataGridViewTextBoxColumn.Name = "aracIDDataGridViewTextBoxColumn";
            this.aracIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aracIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "Yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "Yil";
            this.yilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            this.yilDataGridViewTextBoxColumn.Width = 125;
            // 
            // sasiNumarasiDataGridViewTextBoxColumn
            // 
            this.sasiNumarasiDataGridViewTextBoxColumn.DataPropertyName = "SasiNumarasi";
            this.sasiNumarasiDataGridViewTextBoxColumn.HeaderText = "SasiNumarasi";
            this.sasiNumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sasiNumarasiDataGridViewTextBoxColumn.Name = "sasiNumarasiDataGridViewTextBoxColumn";
            this.sasiNumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // motorNumarasiDataGridViewTextBoxColumn
            // 
            this.motorNumarasiDataGridViewTextBoxColumn.DataPropertyName = "MotorNumarasi";
            this.motorNumarasiDataGridViewTextBoxColumn.HeaderText = "MotorNumarasi";
            this.motorNumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motorNumarasiDataGridViewTextBoxColumn.Name = "motorNumarasiDataGridViewTextBoxColumn";
            this.motorNumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "Renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "Renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            this.renkDataGridViewTextBoxColumn.Width = 125;
            // 
            // araclarBindingSource
            // 
            this.araclarBindingSource.DataMember = "Araclar";
            this.araclarBindingSource.DataSource = this.otoServisYonetimDataSet5;
            // 
            // otoServisYonetimDataSet5
            // 
            this.otoServisYonetimDataSet5.DataSetName = "OtoServisYonetimDataSet5";
            this.otoServisYonetimDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araclarTableAdapter
            // 
            this.araclarTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONELToolStripMenuItem,
            this.mÜŞTERİToolStripMenuItem,
            this.aRAÇKAYITToolStripMenuItem,
            this.sERVİSKAYITLARToolStripMenuItem,
            this.iŞLEMDETAYLARIToolStripMenuItem,
            this.pARÇADETAYLARIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1446, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pERSONELToolStripMenuItem
            // 
            this.pERSONELToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pERSONELToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pERSONELToolStripMenuItem.Name = "pERSONELToolStripMenuItem";
            this.pERSONELToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.pERSONELToolStripMenuItem.Text = "PERSONEL";
            this.pERSONELToolStripMenuItem.Click += new System.EventHandler(this.pERSONELToolStripMenuItem_Click);
            // 
            // mÜŞTERİToolStripMenuItem
            // 
            this.mÜŞTERİToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mÜŞTERİToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mÜŞTERİToolStripMenuItem.Name = "mÜŞTERİToolStripMenuItem";
            this.mÜŞTERİToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.mÜŞTERİToolStripMenuItem.Text = "MÜŞTERİ";
            this.mÜŞTERİToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİToolStripMenuItem_Click);
            // 
            // aRAÇKAYITToolStripMenuItem
            // 
            this.aRAÇKAYITToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRAÇKAYITToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aRAÇKAYITToolStripMenuItem.Name = "aRAÇKAYITToolStripMenuItem";
            this.aRAÇKAYITToolStripMenuItem.Size = new System.Drawing.Size(140, 28);
            this.aRAÇKAYITToolStripMenuItem.Text = "ARAÇ KAYIT";
            this.aRAÇKAYITToolStripMenuItem.Click += new System.EventHandler(this.aRAÇKAYITToolStripMenuItem_Click);
            // 
            // sERVİSKAYITLARToolStripMenuItem
            // 
            this.sERVİSKAYITLARToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sERVİSKAYITLARToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sERVİSKAYITLARToolStripMenuItem.Name = "sERVİSKAYITLARToolStripMenuItem";
            this.sERVİSKAYITLARToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.sERVİSKAYITLARToolStripMenuItem.Text = "SERVİS KAYITLAR";
            this.sERVİSKAYITLARToolStripMenuItem.Click += new System.EventHandler(this.sERVİSKAYITLARToolStripMenuItem_Click);
            // 
            // iŞLEMDETAYLARIToolStripMenuItem
            // 
            this.iŞLEMDETAYLARIToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iŞLEMDETAYLARIToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iŞLEMDETAYLARIToolStripMenuItem.Name = "iŞLEMDETAYLARIToolStripMenuItem";
            this.iŞLEMDETAYLARIToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.iŞLEMDETAYLARIToolStripMenuItem.Text = "İŞLEM DETAYLARI";
            this.iŞLEMDETAYLARIToolStripMenuItem.Click += new System.EventHandler(this.iŞLEMDETAYLARIToolStripMenuItem_Click);
            // 
            // pARÇADETAYLARIToolStripMenuItem
            // 
            this.pARÇADETAYLARIToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pARÇADETAYLARIToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pARÇADETAYLARIToolStripMenuItem.Name = "pARÇADETAYLARIToolStripMenuItem";
            this.pARÇADETAYLARIToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.pARÇADETAYLARIToolStripMenuItem.Text = "PARÇA DETAYLARI";
            this.pARÇADETAYLARIToolStripMenuItem.Click += new System.EventHandler(this.pARÇADETAYLARIToolStripMenuItem_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaMenu.Location = new System.Drawing.Point(1282, 48);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(143, 42);
            this.btnAnaMenu.TabIndex = 28;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(51, 187);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 22);
            this.txtPlaka.TabIndex = 29;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(202, 187);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 30;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(352, 187);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 31;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(507, 187);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 22);
            this.txtYil.TabIndex = 32;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(925, 187);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 22);
            this.txtRenk.TabIndex = 33;
            // 
            // txtMotorNumarasi
            // 
            this.txtMotorNumarasi.Location = new System.Drawing.Point(785, 187);
            this.txtMotorNumarasi.Name = "txtMotorNumarasi";
            this.txtMotorNumarasi.Size = new System.Drawing.Size(100, 22);
            this.txtMotorNumarasi.TabIndex = 34;
            // 
            // txtSasiNumarasi
            // 
            this.txtSasiNumarasi.Location = new System.Drawing.Point(646, 187);
            this.txtSasiNumarasi.Name = "txtSasiNumarasi";
            this.txtSasiNumarasi.Size = new System.Drawing.Size(100, 22);
            this.txtSasiNumarasi.TabIndex = 35;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(199, 142);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(45, 16);
            this.lblMarka.TabIndex = 36;
            this.lblMarka.Text = "Marka";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(922, 142);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(39, 16);
            this.lblRenk.TabIndex = 37;
            this.lblRenk.Text = "Renk";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(48, 142);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(42, 16);
            this.lblPlaka.TabIndex = 38;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblSasiNumarasi
            // 
            this.lblSasiNumarasi.AutoSize = true;
            this.lblSasiNumarasi.Location = new System.Drawing.Point(643, 142);
            this.lblSasiNumarasi.Name = "lblSasiNumarasi";
            this.lblSasiNumarasi.Size = new System.Drawing.Size(95, 16);
            this.lblSasiNumarasi.TabIndex = 39;
            this.lblSasiNumarasi.Text = "Şasi Numarası";
            // 
            // lblMotorNumarasi
            // 
            this.lblMotorNumarasi.AutoSize = true;
            this.lblMotorNumarasi.Location = new System.Drawing.Point(782, 142);
            this.lblMotorNumarasi.Name = "lblMotorNumarasi";
            this.lblMotorNumarasi.Size = new System.Drawing.Size(102, 16);
            this.lblMotorNumarasi.TabIndex = 40;
            this.lblMotorNumarasi.Text = "Motor Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Yıl";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(349, 142);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 42;
            this.lblModel.Text = "Model";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Turquoise;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(1090, 167);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 42);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1087, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 36);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(916, 262);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 22);
            this.txtSearch.TabIndex = 52;
            
            // 
            // AracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1446, 670);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMotorNumarasi);
            this.Controls.Add(this.lblSasiNumarasi);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtSasiNumarasi);
            this.Controls.Add(this.txtMotorNumarasi);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AracKayit";
            this.Text = "AracKayit";
            this.Load += new System.EventHandler(this.AracKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoServisYonetimDataSet5 otoServisYonetimDataSet5;
        private System.Windows.Forms.BindingSource araclarBindingSource;
        private OtoServisYonetimDataSet5TableAdapters.AraclarTableAdapter araclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasiNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRAÇKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVİSKAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMDETAYLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARÇADETAYLARIToolStripMenuItem;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtMotorNumarasi;
        private System.Windows.Forms.TextBox txtSasiNumarasi;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblSasiNumarasi;
        private System.Windows.Forms.Label lblMotorNumarasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
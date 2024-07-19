namespace OtoServisYonetim
{
    partial class FrmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteri));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.musteriyonetimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet1 = new OtoServisYonetim.OtoServisYonetimDataSet1();
            this.musteri_yonetimTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet1TableAdapters.musteri_yonetimTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet2 = new OtoServisYonetim.OtoServisYonetimDataSet2();
            this.musterilerTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet2TableAdapters.MusterilerTableAdapter();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRAÇKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVİSKAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMDETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARÇADETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musteriyonetimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÜŞTERİ YÖNETİM SİSTEMİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(674, 175);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 42);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(768, 175);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 42);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // musteriyonetimBindingSource
            // 
            this.musteriyonetimBindingSource.DataMember = "musteri_yonetim";
            this.musteriyonetimBindingSource.DataSource = this.otoServisYonetimDataSet1;
            // 
            // otoServisYonetimDataSet1
            // 
            this.otoServisYonetimDataSet1.DataSetName = "OtoServisYonetimDataSet1";
            this.otoServisYonetimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteri_yonetimTableAdapter
            // 
            this.musteri_yonetimTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musterilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 268);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
            this.epostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            this.epostaDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.otoServisYonetimDataSet2;
            // 
            // otoServisYonetimDataSet2
            // 
            this.otoServisYonetimDataSet2.DataSetName = "OtoServisYonetimDataSet2";
            this.otoServisYonetimDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(124, 149);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblAdSoyad.TabIndex = 18;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(531, 149);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(43, 16);
            this.lblAdres.TabIndex = 19;
            this.lblAdres.Text = "Adres";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(397, 149);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(54, 16);
            this.lblEposta.TabIndex = 20;
            this.lblEposta.Text = "E Posta";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(262, 149);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(53, 16);
            this.lblTelNo.TabIndex = 21;
            this.lblTelNo.Text = "Telefon";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(127, 195);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 22;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(534, 195);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 23;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(400, 195);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 22);
            this.txtEposta.TabIndex = 24;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(265, 195);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 25;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged_1);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaMenu.Location = new System.Drawing.Point(1288, 35);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(143, 42);
            this.btnAnaMenu.TabIndex = 26;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1645, 32);
            this.menuStrip1.TabIndex = 27;
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(959, 186);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 22);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1243, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 36);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1645, 754);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMusteri";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriyonetimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private OtoServisYonetimDataSet1 otoServisYonetimDataSet1;
        private System.Windows.Forms.BindingSource musteriyonetimBindingSource;
        private OtoServisYonetimDataSet1TableAdapters.musteri_yonetimTableAdapter musteri_yonetimTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoServisYonetimDataSet2 otoServisYonetimDataSet2;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private OtoServisYonetimDataSet2TableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRAÇKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVİSKAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMDETAYLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARÇADETAYLARIToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
namespace OtoServisYonetim
{
    partial class IslemDetayları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemDetayları));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıslemDetayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisKayitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDetaylariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet6 = new OtoServisYonetim.OtoServisYonetimDataSet6();
            this.islemDetaylariTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet6TableAdapters.IslemDetaylariTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRAÇKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVİSKAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMDETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARÇADETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblslemTarihi = new System.Windows.Forms.Label();
            this.lblIslemAciklamasi = new System.Windows.Forms.Label();
            this.lblIslemTutari = new System.Windows.Forms.Label();
            this.lblIslemDurumu = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblServisKayitId = new System.Windows.Forms.Label();
            this.cmbxServisKayitId = new System.Windows.Forms.ComboBox();
            this.servisKayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet9 = new OtoServisYonetim.OtoServisYonetimDataSet9();
            this.servisKayitlarTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet9TableAdapters.ServisKayitlarTableAdapter();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisKayitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(489, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "İŞLEM DETAYLARI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıslemDetayIDDataGridViewTextBoxColumn,
            this.servisKayitIDDataGridViewTextBoxColumn,
            this.ıslemTarihiDataGridViewTextBoxColumn,
            this.ıslemAciklamasiDataGridViewTextBoxColumn,
            this.ıslemTutariDataGridViewTextBoxColumn,
            this.ıslemDurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ıslemDetaylariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 267);
            this.dataGridView1.TabIndex = 4;
            // 
            // ıslemDetayIDDataGridViewTextBoxColumn
            // 
            this.ıslemDetayIDDataGridViewTextBoxColumn.DataPropertyName = "IslemDetayID";
            this.ıslemDetayIDDataGridViewTextBoxColumn.HeaderText = "IslemDetayID";
            this.ıslemDetayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemDetayIDDataGridViewTextBoxColumn.Name = "ıslemDetayIDDataGridViewTextBoxColumn";
            this.ıslemDetayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıslemDetayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // servisKayitIDDataGridViewTextBoxColumn
            // 
            this.servisKayitIDDataGridViewTextBoxColumn.DataPropertyName = "ServisKayitID";
            this.servisKayitIDDataGridViewTextBoxColumn.HeaderText = "ServisKayitID";
            this.servisKayitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servisKayitIDDataGridViewTextBoxColumn.Name = "servisKayitIDDataGridViewTextBoxColumn";
            this.servisKayitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemTarihiDataGridViewTextBoxColumn
            // 
            this.ıslemTarihiDataGridViewTextBoxColumn.DataPropertyName = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.HeaderText = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemTarihiDataGridViewTextBoxColumn.Name = "ıslemTarihiDataGridViewTextBoxColumn";
            this.ıslemTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemAciklamasiDataGridViewTextBoxColumn
            // 
            this.ıslemAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "IslemAciklamasi";
            this.ıslemAciklamasiDataGridViewTextBoxColumn.HeaderText = "IslemAciklamasi";
            this.ıslemAciklamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemAciklamasiDataGridViewTextBoxColumn.Name = "ıslemAciklamasiDataGridViewTextBoxColumn";
            this.ıslemAciklamasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemTutariDataGridViewTextBoxColumn
            // 
            this.ıslemTutariDataGridViewTextBoxColumn.DataPropertyName = "IslemTutari";
            this.ıslemTutariDataGridViewTextBoxColumn.HeaderText = "IslemTutari";
            this.ıslemTutariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemTutariDataGridViewTextBoxColumn.Name = "ıslemTutariDataGridViewTextBoxColumn";
            this.ıslemTutariDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemDurumuDataGridViewTextBoxColumn
            // 
            this.ıslemDurumuDataGridViewTextBoxColumn.DataPropertyName = "IslemDurumu";
            this.ıslemDurumuDataGridViewTextBoxColumn.HeaderText = "IslemDurumu";
            this.ıslemDurumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemDurumuDataGridViewTextBoxColumn.Name = "ıslemDurumuDataGridViewTextBoxColumn";
            this.ıslemDurumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemDetaylariBindingSource
            // 
            this.ıslemDetaylariBindingSource.DataMember = "IslemDetaylari";
            this.ıslemDetaylariBindingSource.DataSource = this.otoServisYonetimDataSet6;
            // 
            // otoServisYonetimDataSet6
            // 
            this.otoServisYonetimDataSet6.DataSetName = "OtoServisYonetimDataSet6";
            this.otoServisYonetimDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemDetaylariTableAdapter
            // 
            this.islemDetaylariTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1439, 32);
            this.menuStrip1.TabIndex = 5;
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
            this.btnAnaMenu.Location = new System.Drawing.Point(1271, 50);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(143, 42);
            this.btnAnaMenu.TabIndex = 29;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(676, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(804, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 33;
            // 
            // lblslemTarihi
            // 
            this.lblslemTarihi.AutoSize = true;
            this.lblslemTarihi.Location = new System.Drawing.Point(314, 137);
            this.lblslemTarihi.Name = "lblslemTarihi";
            this.lblslemTarihi.Size = new System.Drawing.Size(76, 16);
            this.lblslemTarihi.TabIndex = 34;
            this.lblslemTarihi.Text = "İşlem Tarihi";
            // 
            // lblIslemAciklamasi
            // 
            this.lblIslemAciklamasi.AutoSize = true;
            this.lblIslemAciklamasi.Location = new System.Drawing.Point(524, 137);
            this.lblIslemAciklamasi.Name = "lblIslemAciklamasi";
            this.lblIslemAciklamasi.Size = new System.Drawing.Size(108, 16);
            this.lblIslemAciklamasi.TabIndex = 35;
            this.lblIslemAciklamasi.Text = "İşlem Açıklaması";
            // 
            // lblIslemTutari
            // 
            this.lblIslemTutari.AutoSize = true;
            this.lblIslemTutari.Location = new System.Drawing.Point(673, 137);
            this.lblIslemTutari.Name = "lblIslemTutari";
            this.lblIslemTutari.Size = new System.Drawing.Size(76, 16);
            this.lblIslemTutari.TabIndex = 36;
            this.lblIslemTutari.Text = "İşlem Tutarı";
            // 
            // lblIslemDurumu
            // 
            this.lblIslemDurumu.AutoSize = true;
            this.lblIslemDurumu.Location = new System.Drawing.Point(801, 137);
            this.lblIslemDurumu.Name = "lblIslemDurumu";
            this.lblIslemDurumu.Size = new System.Drawing.Size(88, 16);
            this.lblIslemDurumu.TabIndex = 37;
            this.lblIslemDurumu.Text = "İşlem Durumu";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(981, 172);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 42);
            this.btnEkle.TabIndex = 42;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblServisKayitId
            // 
            this.lblServisKayitId.AutoSize = true;
            this.lblServisKayitId.Location = new System.Drawing.Point(134, 137);
            this.lblServisKayitId.Name = "lblServisKayitId";
            this.lblServisKayitId.Size = new System.Drawing.Size(91, 16);
            this.lblServisKayitId.TabIndex = 44;
            this.lblServisKayitId.Text = "Servis Kayıt Id";
            // 
            // cmbxServisKayitId
            // 
            this.cmbxServisKayitId.DataSource = this.servisKayitlarBindingSource;
            this.cmbxServisKayitId.FormattingEnabled = true;
            this.cmbxServisKayitId.Location = new System.Drawing.Point(137, 181);
            this.cmbxServisKayitId.Name = "cmbxServisKayitId";
            this.cmbxServisKayitId.Size = new System.Drawing.Size(121, 24);
            this.cmbxServisKayitId.TabIndex = 45;
            this.cmbxServisKayitId.SelectedIndexChanged += new System.EventHandler(this.cmbxServisKayitId_SelectedIndexChanged);
            // 
            // servisKayitlarBindingSource
            // 
            this.servisKayitlarBindingSource.DataMember = "ServisKayitlar";
            this.servisKayitlarBindingSource.DataSource = this.otoServisYonetimDataSet9;
            // 
            // otoServisYonetimDataSet9
            // 
            this.otoServisYonetimDataSet9.DataSetName = "OtoServisYonetimDataSet9";
            this.otoServisYonetimDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisKayitlarTableAdapter
            // 
            this.servisKayitlarTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(1091, 172);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 42);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(981, 259);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 22);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1152, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 36);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // IslemDetayları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 645);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbxServisKayitId);
            this.Controls.Add(this.lblServisKayitId);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblIslemDurumu);
            this.Controls.Add(this.lblIslemTutari);
            this.Controls.Add(this.lblIslemAciklamasi);
            this.Controls.Add(this.lblslemTarihi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IslemDetayları";
            this.Text = "IslemDetayları";
            this.Load += new System.EventHandler(this.IslemDetayları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisKayitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoServisYonetimDataSet6 otoServisYonetimDataSet6;
        private System.Windows.Forms.BindingSource ıslemDetaylariBindingSource;
        private OtoServisYonetimDataSet6TableAdapters.IslemDetaylariTableAdapter islemDetaylariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDetayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisKayitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRAÇKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVİSKAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMDETAYLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARÇADETAYLARIToolStripMenuItem;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblslemTarihi;
        private System.Windows.Forms.Label lblIslemAciklamasi;
        private System.Windows.Forms.Label lblIslemTutari;
        private System.Windows.Forms.Label lblIslemDurumu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblServisKayitId;
        private System.Windows.Forms.ComboBox cmbxServisKayitId;
        private OtoServisYonetimDataSet9 otoServisYonetimDataSet9;
        private System.Windows.Forms.BindingSource servisKayitlarBindingSource;
        private OtoServisYonetimDataSet9TableAdapters.ServisKayitlarTableAdapter servisKayitlarTableAdapter;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
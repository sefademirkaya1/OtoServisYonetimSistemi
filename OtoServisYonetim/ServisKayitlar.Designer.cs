namespace OtoServisYonetim
{
    partial class ServisKayitlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServisKayitlar));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servisKayitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisKayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet8 = new OtoServisYonetim.OtoServisYonetimDataSet8();
            this.servisKayitlarTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet8TableAdapters.ServisKayitlarTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRAÇKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVİSKAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMDETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARÇADETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.cmbxAracId = new System.Windows.Forms.ComboBox();
            this.araclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet11 = new OtoServisYonetim.OtoServisYonetimDataSet11();
            this.cmbxMusteriId = new System.Windows.Forms.ComboBox();
            this.musterilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet13 = new OtoServisYonetim.OtoServisYonetimDataSet13();
            this.servisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtServisDurumu = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblMusteriId = new System.Windows.Forms.Label();
            this.lblServisTarihi = new System.Windows.Forms.Label();
            this.lblServisDurumu = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblAracId = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.araclarTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet11TableAdapters.AraclarTableAdapter();
            this.otoServisYonetimDataSet12 = new OtoServisYonetim.OtoServisYonetimDataSet12();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet12TableAdapters.MusterilerTableAdapter();
            this.musterilerTableAdapter1 = new OtoServisYonetim.OtoServisYonetimDataSet13TableAdapters.MusterilerTableAdapter();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisKayitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(481, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "SERVİS KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisKayitIDDataGridViewTextBoxColumn,
            this.aracIDDataGridViewTextBoxColumn,
            this.musteriIDDataGridViewTextBoxColumn,
            this.servisTarihiDataGridViewTextBoxColumn,
            this.servisDurumuDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servisKayitlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 279);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // servisKayitIDDataGridViewTextBoxColumn
            // 
            this.servisKayitIDDataGridViewTextBoxColumn.DataPropertyName = "ServisKayitID";
            this.servisKayitIDDataGridViewTextBoxColumn.HeaderText = "ServisKayitID";
            this.servisKayitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servisKayitIDDataGridViewTextBoxColumn.Name = "servisKayitIDDataGridViewTextBoxColumn";
            this.servisKayitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.servisKayitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aracIDDataGridViewTextBoxColumn
            // 
            this.aracIDDataGridViewTextBoxColumn.DataPropertyName = "AracID";
            this.aracIDDataGridViewTextBoxColumn.HeaderText = "AracID";
            this.aracIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracIDDataGridViewTextBoxColumn.Name = "aracIDDataGridViewTextBoxColumn";
            this.aracIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // servisTarihiDataGridViewTextBoxColumn
            // 
            this.servisTarihiDataGridViewTextBoxColumn.DataPropertyName = "ServisTarihi";
            this.servisTarihiDataGridViewTextBoxColumn.HeaderText = "ServisTarihi";
            this.servisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servisTarihiDataGridViewTextBoxColumn.Name = "servisTarihiDataGridViewTextBoxColumn";
            this.servisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // servisDurumuDataGridViewTextBoxColumn
            // 
            this.servisDurumuDataGridViewTextBoxColumn.DataPropertyName = "ServisDurumu";
            this.servisDurumuDataGridViewTextBoxColumn.HeaderText = "ServisDurumu";
            this.servisDurumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servisDurumuDataGridViewTextBoxColumn.Name = "servisDurumuDataGridViewTextBoxColumn";
            this.servisDurumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // servisKayitlarBindingSource
            // 
            this.servisKayitlarBindingSource.DataMember = "ServisKayitlar";
            this.servisKayitlarBindingSource.DataSource = this.otoServisYonetimDataSet8;
            // 
            // otoServisYonetimDataSet8
            // 
            this.otoServisYonetimDataSet8.DataSetName = "OtoServisYonetimDataSet8";
            this.otoServisYonetimDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisKayitlarTableAdapter
            // 
            this.servisKayitlarTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1400, 32);
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
            this.btnAnaMenu.Location = new System.Drawing.Point(1250, 46);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(143, 42);
            this.btnAnaMenu.TabIndex = 28;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // cmbxAracId
            // 
            this.cmbxAracId.DataSource = this.araclarBindingSource;
            this.cmbxAracId.FormattingEnabled = true;
            this.cmbxAracId.Location = new System.Drawing.Point(50, 290);
            this.cmbxAracId.Name = "cmbxAracId";
            this.cmbxAracId.Size = new System.Drawing.Size(121, 24);
            this.cmbxAracId.TabIndex = 30;
            // 
            // araclarBindingSource
            // 
            this.araclarBindingSource.DataMember = "Araclar";
            this.araclarBindingSource.DataSource = this.otoServisYonetimDataSet11;
            // 
            // otoServisYonetimDataSet11
            // 
            this.otoServisYonetimDataSet11.DataSetName = "OtoServisYonetimDataSet11";
            this.otoServisYonetimDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbxMusteriId
            // 
            this.cmbxMusteriId.DataSource = this.musterilerBindingSource1;
            this.cmbxMusteriId.FormattingEnabled = true;
            this.cmbxMusteriId.Location = new System.Drawing.Point(192, 292);
            this.cmbxMusteriId.Name = "cmbxMusteriId";
            this.cmbxMusteriId.Size = new System.Drawing.Size(118, 24);
            this.cmbxMusteriId.TabIndex = 31;
            // 
            // musterilerBindingSource1
            // 
            this.musterilerBindingSource1.DataMember = "Musteriler";
            this.musterilerBindingSource1.DataSource = this.otoServisYonetimDataSet13;
            // 
            // otoServisYonetimDataSet13
            // 
            this.otoServisYonetimDataSet13.DataSetName = "OtoServisYonetimDataSet13";
            this.otoServisYonetimDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisTarihi
            // 
            this.servisTarihi.Location = new System.Drawing.Point(331, 292);
            this.servisTarihi.Name = "servisTarihi";
            this.servisTarihi.Size = new System.Drawing.Size(175, 22);
            this.servisTarihi.TabIndex = 32;
            // 
            // txtServisDurumu
            // 
            this.txtServisDurumu.Location = new System.Drawing.Point(529, 294);
            this.txtServisDurumu.Name = "txtServisDurumu";
            this.txtServisDurumu.Size = new System.Drawing.Size(100, 22);
            this.txtServisDurumu.TabIndex = 33;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(667, 294);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 22);
            this.txtToplamTutar.TabIndex = 34;
            // 
            // lblMusteriId
            // 
            this.lblMusteriId.AutoSize = true;
            this.lblMusteriId.Location = new System.Drawing.Point(189, 250);
            this.lblMusteriId.Name = "lblMusteriId";
            this.lblMusteriId.Size = new System.Drawing.Size(73, 16);
            this.lblMusteriId.TabIndex = 36;
            this.lblMusteriId.Text = "Müşteri Adı";
            // 
            // lblServisTarihi
            // 
            this.lblServisTarihi.AutoSize = true;
            this.lblServisTarihi.Location = new System.Drawing.Point(328, 250);
            this.lblServisTarihi.Name = "lblServisTarihi";
            this.lblServisTarihi.Size = new System.Drawing.Size(79, 16);
            this.lblServisTarihi.TabIndex = 37;
            this.lblServisTarihi.Text = "ServisTarihi";
            // 
            // lblServisDurumu
            // 
            this.lblServisDurumu.AutoSize = true;
            this.lblServisDurumu.Location = new System.Drawing.Point(526, 250);
            this.lblServisDurumu.Name = "lblServisDurumu";
            this.lblServisDurumu.Size = new System.Drawing.Size(94, 16);
            this.lblServisDurumu.TabIndex = 38;
            this.lblServisDurumu.Text = "Servis Durumu";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(664, 250);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(88, 16);
            this.lblToplamTutar.TabIndex = 39;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblAracId
            // 
            this.lblAracId.AutoSize = true;
            this.lblAracId.Location = new System.Drawing.Point(47, 250);
            this.lblAracId.Name = "lblAracId";
            this.lblAracId.Size = new System.Drawing.Size(73, 16);
            this.lblAracId.TabIndex = 40;
            this.lblAracId.Text = "Araç Plaka";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Turquoise;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(786, 283);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 42);
            this.btnEkle.TabIndex = 41;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // araclarTableAdapter
            // 
            this.araclarTableAdapter.ClearBeforeFill = true;
            // 
            // otoServisYonetimDataSet12
            // 
            this.otoServisYonetimDataSet12.DataSetName = "OtoServisYonetimDataSet12";
            this.otoServisYonetimDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.otoServisYonetimDataSet12;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // musterilerTableAdapter1
            // 
            this.musterilerTableAdapter1.ClearBeforeFill = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(880, 283);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 42);
            this.btnGuncelle.TabIndex = 47;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1226, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 36);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1048, 238);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 22);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ServisKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 697);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblAracId);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblServisDurumu);
            this.Controls.Add(this.lblServisTarihi);
            this.Controls.Add(this.lblMusteriId);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtServisDurumu);
            this.Controls.Add(this.servisTarihi);
            this.Controls.Add(this.cmbxMusteriId);
            this.Controls.Add(this.cmbxAracId);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServisKayitlar";
            this.Text = "ServisKayitlar";
            this.Load += new System.EventHandler(this.ServisKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisKayitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoServisYonetimDataSet8 otoServisYonetimDataSet8;
        private System.Windows.Forms.BindingSource servisKayitlarBindingSource;
        private OtoServisYonetimDataSet8TableAdapters.ServisKayitlarTableAdapter servisKayitlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisKayitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRAÇKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVİSKAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMDETAYLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARÇADETAYLARIToolStripMenuItem;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.ComboBox cmbxAracId;
        private System.Windows.Forms.ComboBox cmbxMusteriId;
        private System.Windows.Forms.DateTimePicker servisTarihi;
        private System.Windows.Forms.TextBox txtServisDurumu;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblMusteriId;
        private System.Windows.Forms.Label lblServisTarihi;
        private System.Windows.Forms.Label lblServisDurumu;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblAracId;
        private System.Windows.Forms.Button btnEkle;
        private OtoServisYonetimDataSet11 otoServisYonetimDataSet11;
        private System.Windows.Forms.BindingSource araclarBindingSource;
        private OtoServisYonetimDataSet11TableAdapters.AraclarTableAdapter araclarTableAdapter;
        private OtoServisYonetimDataSet12 otoServisYonetimDataSet12;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private OtoServisYonetimDataSet12TableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private OtoServisYonetimDataSet13 otoServisYonetimDataSet13;
        private System.Windows.Forms.BindingSource musterilerBindingSource1;
        private OtoServisYonetimDataSet13TableAdapters.MusterilerTableAdapter musterilerTableAdapter1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
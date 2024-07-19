namespace OtoServisYonetim
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.label1 = new System.Windows.Forms.Label();
            this.lblpersAdSoyad = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblisegiristarihi = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblpersonelTelNo = new System.Windows.Forms.Label();
            this.lblpersonelMail = new System.Windows.Forms.Label();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelMaas = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtpersonelmail = new System.Windows.Forms.TextBox();
            this.txttelno = new System.Windows.Forms.TextBox();
            this.txtpozisyon = new System.Windows.Forms.TextBox();
            this.personelyonetimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet1Personel = new OtoServisYonetim.OtoServisYonetimDataSet1Personel();
            this.personel_yonetimTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet1PersonelTableAdapters.personel_yonetimTableAdapter();
            this.otoServisYonetimDataSet3 = new OtoServisYonetim.OtoServisYonetimDataSet3();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet3TableAdapters.PersonelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isegiristarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelyonetimBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet4 = new OtoServisYonetim.OtoServisYonetimDataSet4();
            this.personel_yonetimTableAdapter1 = new OtoServisYonetim.OtoServisYonetimDataSet4TableAdapters.personel_yonetimTableAdapter();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.personelyonetimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet1Personel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelyonetimBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(457, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL YÖNETİM SİSTEMİ";
            // 
            // lblpersAdSoyad
            // 
            this.lblpersAdSoyad.AutoSize = true;
            this.lblpersAdSoyad.Location = new System.Drawing.Point(33, 149);
            this.lblpersAdSoyad.Name = "lblpersAdSoyad";
            this.lblpersAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblpersAdSoyad.TabIndex = 1;
            this.lblpersAdSoyad.Text = "Ad Soyad";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(167, 149);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(41, 16);
            this.lblMaas.TabIndex = 2;
            this.lblMaas.Text = "Maaş";
            // 
            // lblisegiristarihi
            // 
            this.lblisegiristarihi.AutoSize = true;
            this.lblisegiristarihi.Location = new System.Drawing.Point(285, 149);
            this.lblisegiristarihi.Name = "lblisegiristarihi";
            this.lblisegiristarihi.Size = new System.Drawing.Size(92, 16);
            this.lblisegiristarihi.TabIndex = 3;
            this.lblisegiristarihi.Text = "İşe Giriş Tarihi";
           
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Location = new System.Drawing.Point(435, 149);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(62, 16);
            this.lblPozisyon.TabIndex = 4;
            this.lblPozisyon.Text = "Pozisyon";
  
            // 
            // lblpersonelTelNo
            // 
            this.lblpersonelTelNo.AutoSize = true;
            this.lblpersonelTelNo.Location = new System.Drawing.Point(549, 149);
            this.lblpersonelTelNo.Name = "lblpersonelTelNo";
            this.lblpersonelTelNo.Size = new System.Drawing.Size(48, 16);
            this.lblpersonelTelNo.TabIndex = 5;
            this.lblpersonelTelNo.Text = "Tel No";
            // 
            // lblpersonelMail
            // 
            this.lblpersonelMail.AutoSize = true;
            this.lblpersonelMail.Location = new System.Drawing.Point(662, 149);
            this.lblpersonelMail.Name = "lblpersonelMail";
            this.lblpersonelMail.Size = new System.Drawing.Size(92, 16);
            this.lblpersonelMail.TabIndex = 6;
            this.lblpersonelMail.Text = " Personel Mail";
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(36, 186);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(92, 22);
            this.txtPersonelAdSoyad.TabIndex = 7;
           
            // 
            // txtPersonelMaas
            // 
            this.txtPersonelMaas.Location = new System.Drawing.Point(170, 186);
            this.txtPersonelMaas.Name = "txtPersonelMaas";
            this.txtPersonelMaas.Size = new System.Drawing.Size(92, 22);
            this.txtPersonelMaas.TabIndex = 12;
           
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(792, 175);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 32);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(886, 175);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 32);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(989, 175);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 32);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtpersonelmail
            // 
            this.txtpersonelmail.Location = new System.Drawing.Point(665, 186);
            this.txtpersonelmail.Name = "txtpersonelmail";
            this.txtpersonelmail.Size = new System.Drawing.Size(92, 22);
            this.txtpersonelmail.TabIndex = 16;
          
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(552, 185);
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(92, 22);
            this.txttelno.TabIndex = 17;
           
            // 
            // txtpozisyon
            // 
            this.txtpozisyon.Location = new System.Drawing.Point(438, 185);
            this.txtpozisyon.Name = "txtpozisyon";
            this.txtpozisyon.Size = new System.Drawing.Size(92, 22);
            this.txtpozisyon.TabIndex = 18;
         
            // 
            // personelyonetimBindingSource
            // 
            this.personelyonetimBindingSource.DataMember = "personel_yonetim";
            this.personelyonetimBindingSource.DataSource = this.otoServisYonetimDataSet1Personel;
            // 
            // otoServisYonetimDataSet1Personel
            // 
            this.otoServisYonetimDataSet1Personel.DataSetName = "OtoServisYonetimDataSet1Personel";
            this.otoServisYonetimDataSet1Personel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_yonetimTableAdapter
            // 
            this.personel_yonetimTableAdapter.ClearBeforeFill = true;
            // 
            // otoServisYonetimDataSet3
            // 
            this.otoServisYonetimDataSet3.DataSetName = "OtoServisYonetimDataSet3";
            this.otoServisYonetimDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.otoServisYonetimDataSet3;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.isegiristarihiDataGridViewTextBoxColumn,
            this.pozisyonDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.personelmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelyonetimBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 345);
            this.dataGridView1.TabIndex = 20;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personel_id";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "ad_soyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "ad_soyad";
            this.adsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            this.adsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "maas";
            this.maasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.Width = 125;
            // 
            // isegiristarihiDataGridViewTextBoxColumn
            // 
            this.isegiristarihiDataGridViewTextBoxColumn.DataPropertyName = "ise_giris_tarihi";
            this.isegiristarihiDataGridViewTextBoxColumn.HeaderText = "ise_giris_tarihi";
            this.isegiristarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isegiristarihiDataGridViewTextBoxColumn.Name = "isegiristarihiDataGridViewTextBoxColumn";
            this.isegiristarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // pozisyonDataGridViewTextBoxColumn
            // 
            this.pozisyonDataGridViewTextBoxColumn.DataPropertyName = "pozisyon";
            this.pozisyonDataGridViewTextBoxColumn.HeaderText = "pozisyon";
            this.pozisyonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pozisyonDataGridViewTextBoxColumn.Name = "pozisyonDataGridViewTextBoxColumn";
            this.pozisyonDataGridViewTextBoxColumn.Width = 125;
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "telno";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "telno";
            this.telnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            this.telnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelmailDataGridViewTextBoxColumn
            // 
            this.personelmailDataGridViewTextBoxColumn.DataPropertyName = "personel_mail";
            this.personelmailDataGridViewTextBoxColumn.HeaderText = "personel_mail";
            this.personelmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelmailDataGridViewTextBoxColumn.Name = "personelmailDataGridViewTextBoxColumn";
            this.personelmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelyonetimBindingSource1
            // 
            this.personelyonetimBindingSource1.DataMember = "personel_yonetim";
            this.personelyonetimBindingSource1.DataSource = this.otoServisYonetimDataSet4;
            // 
            // otoServisYonetimDataSet4
            // 
            this.otoServisYonetimDataSet4.DataSetName = "OtoServisYonetimDataSet4";
            this.otoServisYonetimDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_yonetimTableAdapter1
            // 
            this.personel_yonetimTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpIseGirisTarihi
            // 
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(288, 185);
            this.dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(144, 22);
            this.dtpIseGirisTarihi.TabIndex = 21;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaMenu.Location = new System.Drawing.Point(1292, 45);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(143, 42);
            this.btnAnaMenu.TabIndex = 27;
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
            this.menuStrip1.Size = new System.Drawing.Size(1447, 32);
            this.menuStrip1.TabIndex = 28;
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
            this.txtSearch.Location = new System.Drawing.Point(1140, 173);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 22);
            this.txtSearch.TabIndex = 55;
 
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1323, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 36);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1447, 688);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dtpIseGirisTarihi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpozisyon);
            this.Controls.Add(this.txttelno);
            this.Controls.Add(this.txtpersonelmail);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtPersonelMaas);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.lblpersonelMail);
            this.Controls.Add(this.lblpersonelTelNo);
            this.Controls.Add(this.lblPozisyon);
            this.Controls.Add(this.lblisegiristarihi);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblpersAdSoyad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelyonetimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet1Personel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelyonetimBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpersAdSoyad;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblisegiristarihi;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblpersonelTelNo;
        private System.Windows.Forms.Label lblpersonelMail;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelMaas;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtpersonelmail;
        private System.Windows.Forms.TextBox txttelno;
        private System.Windows.Forms.TextBox txtpozisyon;
        private OtoServisYonetimDataSet1Personel otoServisYonetimDataSet1Personel;
        private System.Windows.Forms.BindingSource personelyonetimBindingSource;
        private OtoServisYonetimDataSet1PersonelTableAdapters.personel_yonetimTableAdapter personel_yonetimTableAdapter;
        private OtoServisYonetimDataSet3 otoServisYonetimDataSet3;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private OtoServisYonetimDataSet3TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoServisYonetimDataSet4 otoServisYonetimDataSet4;
        private System.Windows.Forms.BindingSource personelyonetimBindingSource1;
        private OtoServisYonetimDataSet4TableAdapters.personel_yonetimTableAdapter personel_yonetimTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isegiristarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
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
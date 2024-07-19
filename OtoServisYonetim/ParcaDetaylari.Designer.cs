namespace OtoServisYonetim
{
    partial class ParcaDetaylari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParcaDetaylari));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parcaDetayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDetayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcaMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcaFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcaDetaylariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet7 = new OtoServisYonetim.OtoServisYonetimDataSet7();
            this.parcaDetaylariTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet7TableAdapters.ParcaDetaylariTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRAÇKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVİSKAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMDETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARÇADETAYLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.lblParcaAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParcaAdi = new System.Windows.Forms.TextBox();
            this.txtParcaFiyati = new System.Windows.Forms.TextBox();
            this.txtParcaMiktari = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblIslemDetayId = new System.Windows.Forms.Label();
            this.cmbxIslemDetayId = new System.Windows.Forms.ComboBox();
            this.ıslemDetaylariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoServisYonetimDataSet10 = new OtoServisYonetim.OtoServisYonetimDataSet10();
            this.islemDetaylariTableAdapter = new OtoServisYonetim.OtoServisYonetimDataSet10TableAdapters.IslemDetaylariTableAdapter();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcaDetaylariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(523, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "PARÇA DETAYLARI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcaDetayIDDataGridViewTextBoxColumn,
            this.ıslemDetayIDDataGridViewTextBoxColumn,
            this.parcaAdiDataGridViewTextBoxColumn,
            this.parcaMiktariDataGridViewTextBoxColumn,
            this.parcaFiyatiDataGridViewTextBoxColumn,
            this.toplamFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parcaDetaylariBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(109, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 305);
            this.dataGridView1.TabIndex = 5;
            // 
            // parcaDetayIDDataGridViewTextBoxColumn
            // 
            this.parcaDetayIDDataGridViewTextBoxColumn.DataPropertyName = "ParcaDetayID";
            this.parcaDetayIDDataGridViewTextBoxColumn.HeaderText = "ParcaDetayID";
            this.parcaDetayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcaDetayIDDataGridViewTextBoxColumn.Name = "parcaDetayIDDataGridViewTextBoxColumn";
            this.parcaDetayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.parcaDetayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemDetayIDDataGridViewTextBoxColumn
            // 
            this.ıslemDetayIDDataGridViewTextBoxColumn.DataPropertyName = "IslemDetayID";
            this.ıslemDetayIDDataGridViewTextBoxColumn.HeaderText = "IslemDetayID";
            this.ıslemDetayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemDetayIDDataGridViewTextBoxColumn.Name = "ıslemDetayIDDataGridViewTextBoxColumn";
            this.ıslemDetayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcaAdiDataGridViewTextBoxColumn
            // 
            this.parcaAdiDataGridViewTextBoxColumn.DataPropertyName = "ParcaAdi";
            this.parcaAdiDataGridViewTextBoxColumn.HeaderText = "ParcaAdi";
            this.parcaAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcaAdiDataGridViewTextBoxColumn.Name = "parcaAdiDataGridViewTextBoxColumn";
            this.parcaAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcaMiktariDataGridViewTextBoxColumn
            // 
            this.parcaMiktariDataGridViewTextBoxColumn.DataPropertyName = "ParcaMiktari";
            this.parcaMiktariDataGridViewTextBoxColumn.HeaderText = "ParcaMiktari";
            this.parcaMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcaMiktariDataGridViewTextBoxColumn.Name = "parcaMiktariDataGridViewTextBoxColumn";
            this.parcaMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcaFiyatiDataGridViewTextBoxColumn
            // 
            this.parcaFiyatiDataGridViewTextBoxColumn.DataPropertyName = "ParcaFiyati";
            this.parcaFiyatiDataGridViewTextBoxColumn.HeaderText = "ParcaFiyati";
            this.parcaFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcaFiyatiDataGridViewTextBoxColumn.Name = "parcaFiyatiDataGridViewTextBoxColumn";
            this.parcaFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamFiyatDataGridViewTextBoxColumn
            // 
            this.toplamFiyatDataGridViewTextBoxColumn.DataPropertyName = "ToplamFiyat";
            this.toplamFiyatDataGridViewTextBoxColumn.HeaderText = "ToplamFiyat";
            this.toplamFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamFiyatDataGridViewTextBoxColumn.Name = "toplamFiyatDataGridViewTextBoxColumn";
            this.toplamFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcaDetaylariBindingSource
            // 
            this.parcaDetaylariBindingSource.DataMember = "ParcaDetaylari";
            this.parcaDetaylariBindingSource.DataSource = this.otoServisYonetimDataSet7;
            // 
            // otoServisYonetimDataSet7
            // 
            this.otoServisYonetimDataSet7.DataSetName = "OtoServisYonetimDataSet7";
            this.otoServisYonetimDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parcaDetaylariTableAdapter
            // 
            this.parcaDetaylariTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1487, 32);
            this.menuStrip1.TabIndex = 6;
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
            this.btnAnaMenu.Location = new System.Drawing.Point(1332, 45);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(143, 42);
            this.btnAnaMenu.TabIndex = 28;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // lblParcaAdi
            // 
            this.lblParcaAdi.AutoSize = true;
            this.lblParcaAdi.Location = new System.Drawing.Point(231, 166);
            this.lblParcaAdi.Name = "lblParcaAdi";
            this.lblParcaAdi.Size = new System.Drawing.Size(66, 16);
            this.lblParcaAdi.TabIndex = 29;
            this.lblParcaAdi.Text = "Parça Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Parça Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Parça Fiyatı";
            // 
            // txtParcaAdi
            // 
            this.txtParcaAdi.Location = new System.Drawing.Point(234, 203);
            this.txtParcaAdi.Name = "txtParcaAdi";
            this.txtParcaAdi.Size = new System.Drawing.Size(92, 22);
            this.txtParcaAdi.TabIndex = 32;
            // 
            // txtParcaFiyati
            // 
            this.txtParcaFiyati.Location = new System.Drawing.Point(475, 203);
            this.txtParcaFiyati.Name = "txtParcaFiyati";
            this.txtParcaFiyati.Size = new System.Drawing.Size(96, 22);
            this.txtParcaFiyati.TabIndex = 33;
            // 
            // txtParcaMiktari
            // 
            this.txtParcaMiktari.Location = new System.Drawing.Point(351, 203);
            this.txtParcaMiktari.Name = "txtParcaMiktari";
            this.txtParcaMiktari.Size = new System.Drawing.Size(95, 22);
            this.txtParcaMiktari.TabIndex = 34;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Turquoise;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(642, 180);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(78, 42);
            this.btnEkle.TabIndex = 42;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblIslemDetayId
            // 
            this.lblIslemDetayId.AutoSize = true;
            this.lblIslemDetayId.Location = new System.Drawing.Point(106, 166);
            this.lblIslemDetayId.Name = "lblIslemDetayId";
            this.lblIslemDetayId.Size = new System.Drawing.Size(92, 16);
            this.lblIslemDetayId.TabIndex = 43;
            this.lblIslemDetayId.Text = "İşlem Detay Id";
            // 
            // cmbxIslemDetayId
            // 
            this.cmbxIslemDetayId.DataSource = this.ıslemDetaylariBindingSource;
            this.cmbxIslemDetayId.FormattingEnabled = true;
            this.cmbxIslemDetayId.Location = new System.Drawing.Point(108, 203);
            this.cmbxIslemDetayId.Name = "cmbxIslemDetayId";
            this.cmbxIslemDetayId.Size = new System.Drawing.Size(108, 24);
            this.cmbxIslemDetayId.TabIndex = 44;
            // 
            // ıslemDetaylariBindingSource
            // 
            this.ıslemDetaylariBindingSource.DataMember = "IslemDetaylari";
            this.ıslemDetaylariBindingSource.DataSource = this.otoServisYonetimDataSet10;
            // 
            // otoServisYonetimDataSet10
            // 
            this.otoServisYonetimDataSet10.DataSetName = "OtoServisYonetimDataSet10";
            this.otoServisYonetimDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemDetaylariTableAdapter
            // 
            this.islemDetaylariTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(750, 180);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 42);
            this.btnGuncelle.TabIndex = 48;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(950, 174);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 22);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1128, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 36);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ParcaDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1487, 689);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbxIslemDetayId);
            this.Controls.Add(this.lblIslemDetayId);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtParcaMiktari);
            this.Controls.Add(this.txtParcaFiyati);
            this.Controls.Add(this.txtParcaAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblParcaAdi);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParcaDetaylari";
            this.Text = "ParcaDetaylari";
            this.Load += new System.EventHandler(this.ParcaDetaylari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcaDetaylariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemDetaylariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoServisYonetimDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoServisYonetimDataSet7 otoServisYonetimDataSet7;
        private System.Windows.Forms.BindingSource parcaDetaylariBindingSource;
        private OtoServisYonetimDataSet7TableAdapters.ParcaDetaylariTableAdapter parcaDetaylariTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRAÇKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVİSKAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMDETAYLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARÇADETAYLARIToolStripMenuItem;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaDetayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDetayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblParcaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParcaAdi;
        private System.Windows.Forms.TextBox txtParcaFiyati;
        private System.Windows.Forms.TextBox txtParcaMiktari;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblIslemDetayId;
        private System.Windows.Forms.ComboBox cmbxIslemDetayId;
        private OtoServisYonetimDataSet10 otoServisYonetimDataSet10;
        private System.Windows.Forms.BindingSource ıslemDetaylariBindingSource;
        private OtoServisYonetimDataSet10TableAdapters.IslemDetaylariTableAdapter islemDetaylariTableAdapter;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
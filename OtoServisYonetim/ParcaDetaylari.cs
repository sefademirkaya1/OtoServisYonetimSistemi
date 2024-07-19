using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoServisYonetim
{
    public partial class ParcaDetaylari : Form
    {
        public ParcaDetaylari()
        {
            InitializeComponent();
        }

        private void ParcaDetaylari_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde işlem detaylarını ve parça detaylarını doldur
            LoadIslemDetaylari();
            LoadParcaDetaylari();
        }

        private void LoadIslemDetaylari()
        {
            // İşlem detaylarını yüklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT IslemDetayID FROM IslemDetaylari";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbxIslemDetayId.DataSource = dt;
                cmbxIslemDetayId.DisplayMember = "IslemDetayID";
                cmbxIslemDetayId.ValueMember = "IslemDetayID";
            }
        }

        private void LoadParcaDetaylari()
        {
            // Parça detaylarını yüklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ParcaDetaylari";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Yeni parça detayı eklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ParcaDetaylari (IslemDetayID, ParcaAdi, ParcaMiktari, ParcaFiyati, ToplamFiyat) VALUES (@IslemDetayID, @ParcaAdi, @ParcaMiktari, @ParcaFiyati, @ToplamFiyat)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IslemDetayID", (int)cmbxIslemDetayId.SelectedValue);
                    cmd.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                    cmd.Parameters.AddWithValue("@ParcaMiktari", int.Parse(txtParcaMiktari.Text));
                    cmd.Parameters.AddWithValue("@ParcaFiyati", decimal.Parse(txtParcaFiyati.Text));
                    cmd.Parameters.AddWithValue("@ToplamFiyat", decimal.Parse(txtParcaFiyati.Text) * int.Parse(txtParcaMiktari.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            LoadParcaDetaylari(); // Verileri yenile
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Parça detayı güncellemek için
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek kaydı seçiniz.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE ParcaDetaylari SET IslemDetayID = @IslemDetayID, ParcaAdi = @ParcaAdi, ParcaMiktari = @ParcaMiktari, ParcaFiyati = @ParcaFiyati, ToplamFiyat = @ToplamFiyat WHERE ParcaDetayID = @ParcaDetayID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IslemDetayID", (int)cmbxIslemDetayId.SelectedValue);
                    cmd.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                    cmd.Parameters.AddWithValue("@ParcaMiktari", int.Parse(txtParcaMiktari.Text));
                    cmd.Parameters.AddWithValue("@ParcaFiyati", decimal.Parse(txtParcaFiyati.Text));
                    cmd.Parameters.AddWithValue("@ToplamFiyat", decimal.Parse(txtParcaFiyati.Text) * int.Parse(txtParcaMiktari.Text));
                    cmd.Parameters.AddWithValue("@ParcaDetayID", (int)dataGridView1.SelectedRows[0].Cells["ParcaDetayID"].Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            LoadParcaDetaylari(); // Verileri yenile
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // DataGridView'deki seçim değiştiğinde
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["IslemDetayID"].Value != DBNull.Value)
                    cmbxIslemDetayId.SelectedValue = selectedRow.Cells["IslemDetayID"].Value;
                if (selectedRow.Cells["ParcaAdi"].Value != DBNull.Value)
                    txtParcaAdi.Text = selectedRow.Cells["ParcaAdi"].Value.ToString();
                if (selectedRow.Cells["ParcaMiktari"].Value != DBNull.Value)
                    txtParcaMiktari.Text = selectedRow.Cells["ParcaMiktari"].Value.ToString();
                if (selectedRow.Cells["ParcaFiyati"].Value != DBNull.Value)
                    txtParcaFiyati.Text = selectedRow.Cells["ParcaFiyati"].Value.ToString();
            }
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel personelyonetim = new FrmPersonel();
            personelyonetim.Show();
            this.Hide(); // Bu formu gizle
        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri musteriyonetim = new FrmMusteri();
            musteriyonetim.Show();
            this.Hide(); // Bu formu gizle
        }

        private void aRAÇKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracKayit aracKayit = new AracKayit();
            aracKayit.Show();
            this.Hide(); // Bu formu gizle
        }

        private void sERVİSKAYITLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServisKayitlar servisKayitlar = new ServisKayitlar();
            servisKayitlar.Show();
            this.Hide(); // Bu formu gizle
        }

        private void iŞLEMDETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemDetayları islemDetayları = new IslemDetayları();
            islemDetayları.Show();
            this.Hide(); // Bu formu gizle
        }

        private void pARÇADETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcaDetaylari parcaDetaylari = new ParcaDetaylari();
            parcaDetaylari.Show();
            this.Hide(); // Bu formu gizle
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide(); // Bu formu gizle
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Arama butonuna tıklandığında
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchParcaDetaylari(searchText);
            }
        }

        private void SearchParcaDetaylari(string searchText)
        {
            // Parça detaylarını aramak için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ParcaDetaylari WHERE ParcaAdi LIKE @SearchText";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}

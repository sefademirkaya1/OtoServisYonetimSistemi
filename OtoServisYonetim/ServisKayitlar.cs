using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoServisYonetim
{
    public partial class ServisKayitlar : Form
    {
        public ServisKayitlar()
        {
            InitializeComponent();
        }

        private void ServisKayitlar_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde araç, müşteri ve servis kayıtlarını doldur.
            LoadAraclar();
            LoadMusteriler();
            LoadServisKayitlar();
        }

        private void LoadAraclar()
        {
            // Araç verilerini yüklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT AracID, Plaka FROM Araclar";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbxAracId.DataSource = dt;
                cmbxAracId.DisplayMember = "Plaka";
                cmbxAracId.ValueMember = "AracID";
            }
        }

        private void LoadMusteriler()
        {
            // Müşteri verilerini yüklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT MusteriID, AdSoyad FROM Musteriler";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbxMusteriId.DataSource = dt;
                cmbxMusteriId.DisplayMember = "AdSoyad";
                cmbxMusteriId.ValueMember = "MusteriID";
            }
        }

        private void LoadServisKayitlar()
        {
            // Servis kayıtlarını yüklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ServisKayitlar";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Yeni servis kaydı eklemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ServisKayitlar (AracID, MusteriID, ServisTarihi, ServisDurumu, ToplamTutar) VALUES (@AracID, @MusteriID, @ServisTarihi, @ServisDurumu, @ToplamTutar)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AracID", (int)cmbxAracId.SelectedValue);
                    cmd.Parameters.AddWithValue("@MusteriID", (int)cmbxMusteriId.SelectedValue);
                    cmd.Parameters.AddWithValue("@ServisTarihi", servisTarihi.Value);
                    cmd.Parameters.AddWithValue("@ServisDurumu", txtServisDurumu.Text);
                    cmd.Parameters.AddWithValue("@ToplamTutar", decimal.Parse(txtToplamTutar.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            LoadServisKayitlar(); // Verileri yenile
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // DataGridView'deki seçim değiştiğinde
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                cmbxAracId.SelectedValue = selectedRow.Cells["AracID"].Value;
                cmbxMusteriId.SelectedValue = selectedRow.Cells["MusteriID"].Value;
                servisTarihi.Value = Convert.ToDateTime(selectedRow.Cells["ServisTarihi"].Value);
                txtServisDurumu.Text = selectedRow.Cells["ServisDurumu"].Value.ToString();
                txtToplamTutar.Text = selectedRow.Cells["ToplamTutar"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Servis kaydı güncellemek için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE ServisKayitlar SET AracID = @AracID, MusteriID = @MusteriID, ServisTarihi = @ServisTarihi, ServisDurumu = @ServisDurumu, ToplamTutar = @ToplamTutar WHERE ServisKayitID = @ServisKayitID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AracID", (int)cmbxAracId.SelectedValue);
                    cmd.Parameters.AddWithValue("@MusteriID", (int)cmbxMusteriId.SelectedValue);
                    cmd.Parameters.AddWithValue("@ServisTarihi", servisTarihi.Value);
                    cmd.Parameters.AddWithValue("@ServisDurumu", txtServisDurumu.Text);
                    cmd.Parameters.AddWithValue("@ToplamTutar", decimal.Parse(txtToplamTutar.Text));
                    cmd.Parameters.AddWithValue("@ServisKayitID", (int)dataGridView1.SelectedRows[0].Cells["ServisKayitID"].Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            LoadServisKayitlar(); // Verileri yenile
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Ara butonuna tıklandığında
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchServisKayitlar(searchText);
            }
        }

        private void SearchServisKayitlar(string searchText)
        {
            // Servis kayıtlarını aramak için
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ServisKayitlar WHERE ServisDurumu LIKE @SearchText";
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

using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Data;

namespace OtoServisYonetim
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde müşteri bilgilerini doldur
            this.musterilerTableAdapter.Fill(this.otoServisYonetimDataSet2.Musteriler);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Yeni müşteri eklemek için
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Musteriler (AdSoyad, Telefon, Eposta, Adres) " +
                                   "VALUES (@AdSoyad, @Telefon, @Eposta, @Adres)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                        command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        command.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                        command.Parameters.AddWithValue("@Adres", txtAdres.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Müşteri başarıyla eklendi");

                    // Müşteri listesini yenile
                    this.musterilerTableAdapter.Fill(this.otoServisYonetimDataSet2.Musteriler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçilen müşteriyi silmek için
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Musteriler WHERE MusteriID = @MusteriID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int selectedMusteriID = (int)dataGridView1.SelectedRows[0].Cells["MusteriID"].Value;
                        command.Parameters.AddWithValue("@MusteriID", selectedMusteriID);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Silme İşlemi Başarılı");

                    // Müşteri listesini yenile
                    this.musterilerTableAdapter.Fill(this.otoServisYonetimDataSet2.Musteriler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçilen müşteriyi güncellemek için
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Musteriler SET AdSoyad = @AdSoyad, Telefon = @Telefon, Eposta = @Eposta, Adres = @Adres " +
                                   "WHERE MusteriID = @MusteriID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                        command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        command.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                        command.Parameters.AddWithValue("@Adres", txtAdres.Text);
                        int selectedMusteriID = (int)dataGridView1.SelectedRows[0].Cells["MusteriID"].Value;
                        command.Parameters.AddWithValue("@MusteriID", selectedMusteriID);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");

                    // Müşteri listesini yenile
                    this.musterilerTableAdapter.Fill(this.otoServisYonetimDataSet2.Musteriler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // DataGridView'deki seçim değiştiğinde
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                try
                {
                    txtAdSoyad.Text = selectedRow.Cells["AdSoyad"].Value?.ToString() ?? string.Empty;
                    txtTelefon.Text = selectedRow.Cells["Telefon"].Value?.ToString() ?? string.Empty;
                    txtEposta.Text = selectedRow.Cells["Eposta"].Value?.ToString() ?? string.Empty;
                    txtAdres.Text = selectedRow.Cells["Adres"].Value?.ToString() ?? string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Kullanılmayan olay yöntemleri
        private void txtAdSoyad_TextChanged(object sender, EventArgs e) { }
        private void txtTelefon_TextChanged(object sender, EventArgs e) { }
        private void txtEposta_TextChanged(object sender, EventArgs e) { }
        private void txtAdres_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            // Ana menüye dönmek için
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide(); // Bu formu gizle
        }

        private void txtTelefon_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Personel formunu açmak için
            FrmPersonel personelyonetim = new FrmPersonel();
            personelyonetim.Show();
            this.Hide(); // Bu formu gizle
        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Müşteri formunu açmak için
            FrmMusteri musteriyonetim = new FrmMusteri();
            musteriyonetim.Show();
            this.Hide(); // Bu formu gizle
        }

        private void aRAÇKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Araç kayıt formunu açmak için
            AracKayit aracKayit = new AracKayit();
            aracKayit.Show();
            this.Hide(); // Bu formu gizle
        }

        private void sERVİSKAYITLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Servis kayıtlar formunu açmak için
            ServisKayitlar servisKayitlar = new ServisKayitlar();
            servisKayitlar.Show();
            this.Hide(); // Bu formu gizle
        }

        private void iŞLEMDETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // İşlem detayları formunu açmak için
            IslemDetayları islemDetayları = new IslemDetayları();
            islemDetayları.Show();
            this.Hide(); // Bu formu gizle
        }

        private void pARÇADETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Parça detayları formunu açmak için
            ParcaDetaylari parcaDetaylari = new ParcaDetaylari();
            parcaDetaylari.Show();
            this.Hide(); // Bu formu gizle
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Bu işlev kullanılmıyor
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Arama butonuna tıklandığında
            SearchMusteriler(txtSearch.Text);
        }

        private void SearchMusteriler(string searchTerm)
        {
            // Müşteri aramak için
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Musteriler WHERE AdSoyad LIKE @SearchTerm OR Telefon LIKE @SearchTerm OR Eposta LIKE @SearchTerm OR Adres LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OtoServisYonetim
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde personel verilerini doldur.
            this.personel_yonetimTableAdapter1.Fill(this.otoServisYonetimDataSet4.personel_yonetim);
            this.personel_yonetimTableAdapter.Fill(this.otoServisYonetimDataSet1Personel.personel_yonetim);
            LoadPersonelData();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Personel ekle butonuna tıklandığında
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            // SQL sorgusu ile personel ekleme
            string query = "INSERT INTO personel_yonetim (ad_soyad, maas, ise_giris_tarihi, pozisyon, telno, personel_mail) " +
                           "VALUES (@ad_soyad, @maas, @ise_giris_tarihi, @pozisyon, @telno, @personel_mail)";

            DateTime iseGirisTarihi = dtpIseGirisTarihi.Value;

            // SQL bağlantısı oluşturma ve verileri ekleme
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ad_soyad", txtPersonelAdSoyad.Text);
                    command.Parameters.AddWithValue("@maas", txtPersonelMaas.Text);
                    command.Parameters.AddWithValue("@ise_giris_tarihi", iseGirisTarihi);
                    command.Parameters.AddWithValue("@pozisyon", txtpozisyon.Text);
                    command.Parameters.AddWithValue("@telno", txttelno.Text);
                    command.Parameters.AddWithValue("@personel_mail", txtpersonelmail.Text);

                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Personel başarıyla eklendi.");
                        LoadPersonelData(); // Verileri yenile
                    }
                    else
                    {
                        MessageBox.Show("Personel ekleme başarısız.");
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Personel sil butonuna tıklandığında
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int personelId = Convert.ToInt32(selectedRow.Cells["personel_id"].Value);
                DialogResult dialogResult = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Personel Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
                    string query = "DELETE FROM personel_yonetim WHERE personel_id = @personel_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@personel_id", personelId);
                            connection.Open();
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Personel başarıyla silindi.");
                                LoadPersonelData(); // Verileri yenile
                            }
                            else
                            {
                                MessageBox.Show("Personel silme başarısız.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin.");
            }
        }

        private void LoadPersonelData()
        {
            // Personel verilerini yüklemek için
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            // SQL sorgusu ile personel verilerini getir
            string query = "SELECT personel_id, ad_soyad, maas, ise_giris_tarihi, pozisyon, telno, personel_mail FROM personel_yonetim";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Verileri DataGridView'e yükle
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Personel güncelle butonuna tıklandığında
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int personelId = Convert.ToInt32(selectedRow.Cells["personel_id"].Value);

                string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
                string query = "UPDATE personel_yonetim SET ad_soyad = @ad_soyad, maas = @maas, ise_giris_tarihi = @ise_giris_tarihi, pozisyon = @pozisyon, telno = @telno, personel_mail = @personel_mail WHERE personel_id = @personel_id";

                DateTime iseGirisTarihi = dtpIseGirisTarihi.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ad_soyad", txtPersonelAdSoyad.Text);
                        command.Parameters.AddWithValue("@maas", txtPersonelMaas.Text);
                        command.Parameters.AddWithValue("@ise_giris_tarihi", iseGirisTarihi);
                        command.Parameters.AddWithValue("@pozisyon", txtpozisyon.Text);
                        command.Parameters.AddWithValue("@telno", txttelno.Text);
                        command.Parameters.AddWithValue("@personel_mail", txtpersonelmail.Text);
                        command.Parameters.AddWithValue("@personel_id", personelId);

                        connection.Open();

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Personel başarıyla güncellendi.");
                            LoadPersonelData(); // Verileri yenile
                        }
                        else
                        {
                            MessageBox.Show("Personel güncelleme başarısız.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir personel seçin.");
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            // Ana menüye dön butonuna tıklandığında
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide(); // Bu formu gizle
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel personelyonetim = new FrmPersonel();
            personelyonetim.Show();
            this.Hide(); 
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
            this.Hide(); 
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Ara butonuna tıklandığında
            SearchPersonel(txtSearch.Text);
        }

        private void SearchPersonel(string searchTerm)
        {
            // Personel arama işlevi
            string connectionString = ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM personel_yonetim WHERE ad_soyad LIKE @SearchTerm OR maas LIKE @SearchTerm OR pozisyon LIKE @SearchTerm OR telno LIKE @SearchTerm OR personel_mail LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt; // Arama sonuçlarını DataGridView'e yükle
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

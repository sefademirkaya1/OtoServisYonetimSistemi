using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoServisYonetim
{
    public partial class IslemDetayları : Form
    {
        public IslemDetayları()
        {
            InitializeComponent();
        }

        private void IslemDetayları_Load(object sender, EventArgs e)
        {
            // ComboBox'a ServisKayitID'leri yükle
            LoadServisKayitlar();

            // İşlem detaylarını yükle
            LoadIslemDetaylari();
        }

        // Servis kayıtlarını ComboBox'a yükleme metodu
        private void LoadServisKayitlar()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ServisKayitID FROM ServisKayitlar";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbxServisKayitId.DataSource = dt;
                cmbxServisKayitId.DisplayMember = "ServisKayitID";
                cmbxServisKayitId.ValueMember = "ServisKayitID";
            }
        }

        // İşlem detaylarını DataGridView'a yükleme metodu
        private void LoadIslemDetaylari()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM IslemDetaylari";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // Yeni işlem detayı ekleme metodu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO IslemDetaylari (ServisKayitID, IslemTarihi, IslemAciklamasi, IslemTutari, IslemDurumu) VALUES (@ServisKayitID, @IslemTarihi, @IslemAciklamasi, @IslemTutari, @IslemDurumu)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ServisKayitID", (int)cmbxServisKayitId.SelectedValue);
                    cmd.Parameters.AddWithValue("@IslemTarihi", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@IslemAciklamasi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@IslemTutari", decimal.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@IslemDurumu", textBox3.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            // DataGridView'i yenile
            LoadIslemDetaylari();
        }

        // Seçili işlem detayını güncelleme metodu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int islemDetayID = Convert.ToInt32(selectedRow.Cells["IslemDetayID"].Value);

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE IslemDetaylari SET ServisKayitID = @ServisKayitID, IslemTarihi = @IslemTarihi, IslemAciklamasi = @IslemAciklamasi, IslemTutari = @IslemTutari, IslemDurumu = @IslemDurumu WHERE IslemDetayID = @IslemDetayID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ServisKayitID", (int)cmbxServisKayitId.SelectedValue);
                        cmd.Parameters.AddWithValue("@IslemTarihi", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@IslemAciklamasi", textBox1.Text);
                        cmd.Parameters.AddWithValue("@IslemTutari", decimal.Parse(textBox2.Text));
                        cmd.Parameters.AddWithValue("@IslemDurumu", textBox3.Text);
                        cmd.Parameters.AddWithValue("@IslemDetayID", islemDetayID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                // DataGridView'i yenile
                LoadIslemDetaylari();
            }
        }

        // DataGridView'de seçilen satır değiştiğinde tetiklenen metot
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                cmbxServisKayitId.SelectedValue = selectedRow.Cells["ServisKayitID"].Value;
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["IslemTarihi"].Value);
                textBox1.Text = selectedRow.Cells["IslemAciklamasi"].Value.ToString();
                textBox2.Text = selectedRow.Cells["IslemTutari"].Value.ToString();
                textBox3.Text = selectedRow.Cells["IslemDurumu"].Value.ToString();
            }
        }

        // Menü öğeleri için form açma ve bu formu gizleme metodları
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
            this.Hide();
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
            this.Hide();
        }

        private void iŞLEMDETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemDetayları islemDetayları = new IslemDetayları();
            islemDetayları.Show();
            this.Hide();
        }

        private void pARÇADETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcaDetaylari parcaDetaylari = new ParcaDetaylari();
            parcaDetaylari.Show();
            this.Hide();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void cmbxServisKayitId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        // İşlem detaylarını arama butonu
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchIslemDetaylari(searchText);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        // İşlem detaylarını arama metodu
        private void SearchIslemDetaylari(string searchText)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM IslemDetaylari WHERE IslemAciklamasi LIKE @SearchText";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

    }
}

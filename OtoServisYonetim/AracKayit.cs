using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoServisYonetim
{
    public partial class AracKayit : Form
    {
        public AracKayit()
        {
            InitializeComponent();
        }

        private void AracKayit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Araclar";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Araclar (Plaka, Marka, Model, Yil, SasiNumarasi, MotorNumarasi, Renk) VALUES (@Plaka, @Marka, @Model, @Yil, @SasiNumarasi, @MotorNumarasi, @Renk)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                    cmd.Parameters.AddWithValue("@Marka", txtMarka.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Yil", int.Parse(txtYil.Text));
                    cmd.Parameters.AddWithValue("@SasiNumarasi", txtSasiNumarasi.Text);
                    cmd.Parameters.AddWithValue("@MotorNumarasi", txtMotorNumarasi.Text);
                    cmd.Parameters.AddWithValue("@Renk", txtRenk.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            LoadData(); 
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchArac(txtSearch.Text);
        }

     
        private void SearchArac(string searchTerm)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtoServisYonetim.Properties.Settings.OtoServisYonetimConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Araclar WHERE Plaka LIKE @SearchTerm OR Marka LIKE @SearchTerm OR Model LIKE @SearchTerm OR Yil LIKE @SearchTerm OR SasiNumarasi LIKE @SearchTerm OR MotorNumarasi LIKE @SearchTerm OR Renk LIKE @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

    }
}

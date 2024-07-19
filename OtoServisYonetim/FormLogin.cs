using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient; 

namespace OtoServisYonetim
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı Adı ve Şifre boş mu diye kontrol et
            if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
               
                string connectionString = ConfigurationManager.ConnectionStrings["cstr"]?.ConnectionString;

                if (connectionString == null)
                {
                    MessageBox.Show("Bağlantı dizesi bulunamadı. Lütfen App.config dosyasını kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

       
                string query = "SELECT COUNT(1) FROM t_user WHERE LOWER(username) = LOWER(@username) AND password = @password";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@password", txtSifre.Text);

                    try
                    {
                        con.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        Console.WriteLine("Query executed. Count: " + count);

                        if (count == 1)
                        {
                           
                            FrmAnaMenu anaMenu = new FrmAnaMenu();
                            anaMenu.Show();
                            this.Hide(); // Giriş formunu kapat
                        }
                        else
                        {
                            // eğer kullanıcı adı ve şifre eşleşmezse
                            MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                        
                        Console.WriteLine("Exception: " + ex.Message);
                    }
                }
            }
            else
            {
                // Giriş butonuna bastığında kullanıcı adı ve şifre alanlarını doldurması gerektiğini bildir
                MessageBox.Show("Kullanıcı adı ve şifre alanlarını doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

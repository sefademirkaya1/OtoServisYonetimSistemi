using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoServisYonetim
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

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

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            AracKayit aracKayit = new AracKayit();
            aracKayit.Show();
            this.Hide();
        }

        private void BtnServisKayit_Click(object sender, EventArgs e)
        {
            ServisKayitlar servisKayitlar = new ServisKayitlar();
            servisKayitlar.Show();
            this.Hide();
        }

        private void btnIslemDetay_Click(object sender, EventArgs e)
        {
            IslemDetayları islemDetayları = new IslemDetayları();
            islemDetayları.Show();
            this.Hide();
        }

        private void btnParcaDetay_Click(object sender, EventArgs e)
        {
            ParcaDetaylari parcaDetaylari = new ParcaDetaylari();
            parcaDetaylari.Show();
            this.Hide();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel personelyonetim = new FrmPersonel();
            personelyonetim.Show();
            this.Hide();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri musteriyonetim = new FrmMusteri();
            musteriyonetim.Show();
            this.Hide();
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkinda hakkinda = new frmHakkinda();
            hakkinda.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary;
using CommonLibrary;
using DataLibrary;

namespace ProjeSınamÖdevi
{
    public partial class frm_Giris : Form
    {
        public frm_Giris()
        {
            InitializeComponent();
        }

        public Ogrenciler ogr;
        OgrencilerDB ogrGiris;

        public Ogretmen ogrtm;
        OgretmenDB ogrtmnGiris;

        private void bnf_btnGirisYap_Click(object sender, EventArgs e)
        {
            if (mtrbtnOgrenci.Checked == true )
            {
                ogrGiris = new OgrencilerDB();
                ogr = ogrGiris.OgrenciGetir(bnf_txtKullaniciAd.Text, bnf_txtKullaniciSifre.Text);
                if (ogr != null && ogr.ogrKullaniciAdi == bnf_txtKullaniciAd.Text && ogr.ogrSifre == bnf_txtKullaniciSifre.Text)
                {
                    GirisYapanBilgileri.ogrninAdi = bnf_txtKullaniciAd.Text;
                    GirisYapanBilgileri.ogrninNosu = ogr.ogrNo.ToString();
                    GirisYapanBilgileri.sınavId = ogr.sinavId;
                    frm_OgrenciMenu frm = new frm_OgrenciMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali Giris");
                }
            }
            else if (mtrdibtnOgretmen.Checked == true)
            {
                ogrtmnGiris = new OgretmenDB();
                ogrtm = ogrtmnGiris.OgretmenGetir(bnf_txtKullaniciAd.Text, bnf_txtKullaniciSifre.Text);
                if (ogrtm != null && ogrtm.ogrtmnKulAdi == bnf_txtKullaniciAd.Text && ogrtm.ogrtmnSifre == bnf_txtKullaniciSifre.Text)
                {
                    frm_OgretmenMenusu frmMenu = new frm_OgretmenMenusu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali Giris");
                }
            }
            else
                MessageBox.Show("Lütfen Seçim Yapınız !!");
        }
        
        private void bnf_txtOgrparola_Enter(object sender, EventArgs e)
        {
            bnf_txtKullaniciSifre.Text = "";
        }

        private void bnf_txtOgrtmenAd_Enter(object sender, EventArgs e)
        {
            bnf_txtKullaniciAd.Text = "";
        }

        private void bnf_txtOgrtmenSifre_Enter(object sender, EventArgs e)
        {
            bnf_txtKullaniciSifre.Text = "";
        }

        private void bnf_txtOgradi_MouseClick(object sender, MouseEventArgs e)
        {
            bnf_txtKullaniciAd.Text = "";
        }

        private void mtrdibtnOgretmen_MouseLeave(object sender, EventArgs e)
        {
            mtrdibtnOgretmen.ForeColor = Color.White;
        }

        private void mtrbtnOgrenci_MouseLeave(object sender, EventArgs e)
        {
            mtrbtnOgrenci.ForeColor = Color.White;
        }

        private void mtrbtnOgrenci_MouseMove(object sender, MouseEventArgs e)
        {
            mtrbtnOgrenci.ForeColor = Color.SeaGreen;
        }

        private void mtrdibtnOgretmen_MouseMove(object sender, MouseEventArgs e)
        {
            mtrdibtnOgretmen.ForeColor = Color.SeaGreen;
        }
        
        private void pcrebxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

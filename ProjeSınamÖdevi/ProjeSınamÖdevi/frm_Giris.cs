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

        private void bnf_btnOgrGiris_Click(object sender, EventArgs e)
        {
            ogrGiris = new OgrencilerDB();
            ogr = ogrGiris.OgrenciGetir(bnf_txtOgradi.Text, bnf_txtOgrparola.Text);
            if (ogr != null && ogr.ogrKullaniciAdi == bnf_txtOgradi.Text && ogr.ogrSifre == bnf_txtOgrparola.Text)
            {
                GirisYapanBilgileri.ogrninAdi = bnf_txtOgradi.Text;
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


        private void btn_btnOgrtmenGir_Click(object sender, EventArgs e)
        {
            ogrtmnGiris = new OgretmenDB();
            ogrtm = ogrtmnGiris.OgretmenGetir(bnf_txtOgrtmenAd.Text, bnf_txtOgrtmenSifre.Text);
            if (ogrtm != null && ogrtm.ogrtmnKulAdi == bnf_txtOgrtmenAd.Text && ogrtm.ogrtmnSifre == bnf_txtOgrtmenSifre.Text)
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

        private void bnf_txtOgrparola_Enter(object sender, EventArgs e)
        {
            bnf_txtOgrparola.Text = "";
        }

        private void bnf_txtOgrtmenAd_Enter(object sender, EventArgs e)
        {
            bnf_txtOgrtmenAd.Text = "";
        }

        private void bnf_txtOgrtmenSifre_Enter(object sender, EventArgs e)
        {
            bnf_txtOgrtmenSifre.Text = "";
        }

        private void bnf_txtOgradi_MouseClick(object sender, MouseEventArgs e)
        {
            bnf_txtOgradi.Text = "";
        }
    }
}

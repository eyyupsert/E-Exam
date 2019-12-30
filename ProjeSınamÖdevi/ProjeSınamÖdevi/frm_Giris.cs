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

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ogrGiris = new OgrencilerDB();
            ogr = ogrGiris.OgrenciGetir(txtAd.Text, txtSifre.Text);
            if (ogr != null && ogr.ogrKullaniciAdi == txtAd.Text && ogr.ogrSifre == txtSifre.Text)
            {
                GirisYapanBilgileri.ogrninAdi = txtAd.Text;
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


        private void btnOgrtmen_Click(object sender, EventArgs e)
        {
            ogrtmnGiris = new OgretmenDB();
            ogrtm = ogrtmnGiris.OgretmenGetir(txtOgrtmnAd.Text, txtOgrtmnSifre.Text);
            if (ogrtm != null && ogrtm.ogrtmnKulAdi == txtOgrtmnAd.Text && ogrtm.ogrtmnSifre == txtOgrtmnSifre.Text)
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

        private void frm_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}

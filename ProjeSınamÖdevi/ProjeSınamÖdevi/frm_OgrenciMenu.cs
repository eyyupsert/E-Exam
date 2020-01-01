using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CommonLibrary;
using BusinessLibrary;
using DataLibrary;


namespace ProjeSınamÖdevi
{
    public partial class frm_OgrenciMenu : Form
    {
        public frm_OgrenciMenu()
        {
            InitializeComponent();
        }
        public Ogrenciler ogr;
        OgrencilerDB ogrDB;

        private void btnIstatistikGor_Click(object sender, EventArgs e)
        {
            frm_OgrenciSinavSonuc frmsinav = new frm_OgrenciSinavSonuc();
            frmsinav.Show();
            this.Hide();
        }

        private void frm_OgrenciMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bnfbtn_Sinavol_Click(object sender, EventArgs e)
        {
            ogrDB = new OgrencilerDB();
            ogr = ogrDB.OgrenciSinavIdsiGuncelle();
            frm_OgrenciSinavEkran frmsinav = new frm_OgrenciSinavEkran();
            frmsinav.Show();
            this.Hide();
        }

        private void frm_OgrenciMenu_Load(object sender, EventArgs e)
        {
            bnflbl_ogrAd.Text = (GirisYapanBilgileri.ogrAd + " " + GirisYapanBilgileri.ogrSoyad);
        }

        private void pcrebxCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Ana menüye dönmek istiyor musunuz ? ", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                frm_Giris frmGiris = new frm_Giris();
                frmGiris.Show();
                this.Close();
            }
        }
    }
}

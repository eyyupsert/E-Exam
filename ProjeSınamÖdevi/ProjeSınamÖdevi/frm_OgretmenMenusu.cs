using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;
using BusinessLibrary;
using DataLibrary;

namespace ProjeSınamÖdevi
{
    public partial class frm_OgretmenMenusu : Form
    {
        public frm_OgretmenMenusu()
        {
            InitializeComponent();
        }

        private void btnSoruEkle_Click_1(object sender, EventArgs e)
        {
            frm_OgretmenSoruEkleme soruEkle = new frm_OgretmenSoruEkleme();
            soruEkle.Show();
            this.Hide();
        }



        private void btnSonuclariGoster_Click_1(object sender, EventArgs e)
        {
            frm_OgretmenSonuclariGor frmSonuclar = new frm_OgretmenSonuclariGor();
            frmSonuclar.Show();
            this.Hide();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
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

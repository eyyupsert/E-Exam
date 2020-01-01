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
using DataLibrary;
using BusinessLibrary;

namespace ProjeSınamÖdevi
{
    public partial class frm_OgretmenSoruEkleme : Form
    {
        public frm_OgretmenSoruEkleme()
        {
            InitializeComponent();
        }

        public Sorular soru;

        SorularDB soruDB = new SorularDB();
        KonuDB konuDB = new KonuDB();
        List<Konular> konuCek;


        private void frm_OgretmenEkrani_Load(object sender, EventArgs e)
        {
            konuCek = konuDB.KonularıGetir();
            for (int i = 0; i < konuCek.Count; i++)
            {
                drpdown_konular.Items.Add(konuCek[i].konu);
            }
        }
        


        private void btnSoruEkle_Click_1(object sender, EventArgs e)
        {
            if (drpdown_konular.selectedIndex == -1 || txt_soru.Text == null || txtA.Text == null || txtB.Text == null || txtC.Text == null || txtD.Text == null || drpdown_doruCevap.selectedIndex == -1)
            {
                MessageBox.Show("Lütfen Boş Yerleri Doldurunuz veya Seçim Yapınız !!");
            }
            else
            {
                soru = soruDB.SoruEkle(drpdown_konular.selectedValue, txt_soru.Text, txtA.Text, txtB.Text, txtC.Text, txtD.Text, drpdown_doruCevap.selectedValue.ToString());
                MessageBox.Show("Soru başarı ile eklenmiştir..");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox textB = (TextBox)item;
                        textB.Clear();
                    }
                }
                drpdown_konular.selectedIndex = -1;
                drpdown_doruCevap.selectedIndex = -1;
            }
        }



        private void txt_soru_MouseClick(object sender, MouseEventArgs e)
        {
            txt_soru.Text = "";
        }

        private void txtA_Enter(object sender, EventArgs e)
        {
            txtA.Text = "";
        }

        private void txtB_Enter(object sender, EventArgs e)
        {
            txtB.Text = "";
        }

        private void txtC_Enter(object sender, EventArgs e)
        {
            txtC.Text = "";
        }

        private void txtD_Enter(object sender, EventArgs e)
        {
            txtD.Text = "";
        }

        private void pcrebxCikis_Click(object sender, EventArgs e)
        {
            frm_OgretmenMenusu frmMenu = new frm_OgretmenMenusu();
            frmMenu.Show();
            this.Close();
        }
    }
}

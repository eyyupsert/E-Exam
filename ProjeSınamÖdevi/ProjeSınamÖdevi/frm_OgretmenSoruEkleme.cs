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
                cmbKonu.Items.Add(konuCek[i].konu);
            }
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            if (cmbKonu.SelectedItem == null || txtSoru.Text == null || txtA.Text == null || txtB.Text == null || txtC.Text == null || txtD.Text == null || txtSoru.Text == null || cmbCevap.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Boş Yerleri Doldurunuz veya Seçim Yapınız !!");
            }
            else
            {
                soru = soruDB.SoruEkle(cmbKonu.SelectedItem.ToString(), txtSoru.Text, txtA.Text, txtB.Text, txtC.Text, txtD.Text, cmbCevap.SelectedItem.ToString());
                MessageBox.Show("Soru başarı ile eklenmiştir..");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox textB = (TextBox)item;
                        textB.Clear();
                    }
                }
                cmbKonu.SelectedIndex = -1;
                cmbCevap.SelectedIndex = -1;
            }
        }

        private void frm_OgretmenEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_OgretmenMenusu frmMenu = new frm_OgretmenMenusu();
            frmMenu.Show();
        }
    }
}

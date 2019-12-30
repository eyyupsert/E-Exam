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
    public partial class frm_OgrenciSinavEkran : Form
    {
        public frm_OgrenciSinavEkran()
        {
            InitializeComponent();
        }
        SorularBusiness soruBS = new SorularBusiness();
        List<Sorular> bilgi;

        SinavBilgileriBusiness sinavlarBS = new SinavBilgileriBusiness();
        List<Sorular> eksikler;


        private void frm_SinavEkrani_Load(object sender, EventArgs e)
        {
            
            aktiflik();
            bilgi = soruBS.SoruGoruntule();
            eksikler = soruBS.EksikKonuluSoru(Convert.ToInt32(GirisYapanBilgileri.ogrninNosu));
            progressBar1.ForeColor = Color.Red;
        }


        private void aktiflik()
        {
            btnBasla.Enabled = true;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
        }

        int yanlis = 0;
        int dogru = 0;
        int x = 0;
        int y = 0;

        private void cevapKontrol(bool cevaplar)
        {
            OgrenciCevaplariBusiness ogrCevp = new OgrenciCevaplariBusiness();
            ogrCevp.CevapKontrol((Convert.ToInt32(label1.Text)),bilgi[x].konu,cevaplar,Convert.ToInt32(label5.Text));
        }
       
        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (btnBasla.Text != "Sonraki Soru")
            {

                progressBar1.ForeColor = Color.Red;
                timer1.Start();
            }
            x++;
            y++;

            btnBasla.Enabled = false;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;

            A.BackColor = Color.White;
            B.BackColor = Color.White;
            C.BackColor = Color.White;
            D.BackColor = Color.White;
            btnBasla.Text = "Sonraki Soru";

            if (GirisYapanBilgileri.sınavId==0)
            {
                if (x == 11)
                {
                    sinavlarBS.GecmisSinavlar(yanlis, dogru);
                    MessageBox.Show("Geçmiş Olsun...Sınavınız Bitmiştir..");
                    Application.Exit();
                }
                else
                {
                    txtSoru.Text = bilgi[x].soru;
                    A.Text = bilgi[x].cevapA;
                    B.Text = bilgi[x].cevapB;
                    C.Text = bilgi[x].cevapC;
                    D.Text = bilgi[x].cevapD;
                    label1.Text = bilgi[x].soruId.ToString();
                    label2.Text = bilgi[x].dogruCevap;
                    label3.Text = bilgi[x].konu;
                    label5.Text = bilgi[x].konuId.ToString();
                }
            }
            else
            {
                if (y<6 && eksikler[y].soru != null)
                {
                    txtSoru.Text = eksikler[y].soru;
                    A.Text = eksikler[y].cevapA;
                    B.Text = eksikler[y].cevapB;
                    C.Text = eksikler[y].cevapC;
                    D.Text = eksikler[y].cevapD;
                    label1.Text = eksikler[y].soruId.ToString();
                    label2.Text = eksikler[y].dogruCevap;
                    label3.Text = eksikler[y].konu;
                    label5.Text = bilgi[y].konuId.ToString();
                }
                else if (y>=6 || y <11 )
                {
                    txtSoru.Text = bilgi[y].soru;
                    A.Text = bilgi[y].cevapA;
                    B.Text = bilgi[y].cevapB;
                    C.Text = bilgi[y].cevapC;
                    D.Text = bilgi[y].cevapD;
                    label1.Text = bilgi[y].soruId.ToString();
                    label2.Text = bilgi[y].dogruCevap;
                    label3.Text = bilgi[y].konu;
                    label5.Text = bilgi[y].konuId.ToString();
                }
                else
                {
                    sinavlarBS.GecmisSinavlar(yanlis, dogru);
                    MessageBox.Show("Geçmiş Olsun...Sınavınız Bitmiştir..");
                    frm_OgrenciMenu ogrMenu = new frm_OgrenciMenu();
                    ogrMenu.Show();
                    this.Close(); 
                }
            }
        }
        
        private void A_Click(object sender, EventArgs e)
        {
            if (A.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                A.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                cevapKontrol(false);
                A.BackColor = Color.Red;
            }
            aktiflik();
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (B.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                B.BackColor = Color.Green;
            }
            else
            {

                yanlis++;
                cevapKontrol(false);
                B.BackColor = Color.Red;
            }
            aktiflik();
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (C.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                C.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                cevapKontrol(false);
                C.BackColor = Color.Red;
            }
            aktiflik();
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (D.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                D.BackColor = Color.Green;
            }
            else
            {

                yanlis++;
                cevapKontrol(false);
                D.BackColor = Color.Red;
            }
            aktiflik();
        }

        private void frm_SinavEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (y != 11 && progressBar1.Value !=0)
            {
                DialogResult secenek = MessageBox.Show("Sınavdan çıkmak isdeğnize emin msiniz ? Eğer çıkış yaparsanız diğer sorularınız yanlış olarak değerlendirilecektir", "Uyarı !!!", MessageBoxButtons.YesNo);

                if (secenek == DialogResult.Yes)
                {
                    for (int z =y; z<11; z++)
                    {
                        cevapKontrol(false);
                    }
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(progressBar1.Value != 0)
            {
                progressBar1.Value -= 10;
            }
           else
            {
                timer1.Stop();
                for (int z = y; z < 11; z++)
                {
                    cevapKontrol(false);
                }
                MessageBox.Show("sınıavınız bitmiştir");
                this.Close();
            }
              
        }
    }
}

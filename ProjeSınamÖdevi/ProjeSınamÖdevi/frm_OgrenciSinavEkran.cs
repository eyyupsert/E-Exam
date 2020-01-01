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
            lbl_ad.Text = (GirisYapanBilgileri.ogrAd + " " + GirisYapanBilgileri.ogrSoyad);
        }
        
        private void aktiflik()
        {
            bfnbtn_basla.Enabled = true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (bnfprgrsbar_süre.Value == 200 || bnfprgrsbar_süre.Value > 20)
            {
                bnfprgrsbar_süre.Value -= 1;
            }
           else if (bnfprgrsbar_süre.Value<=20 && bnfprgrsbar_süre.Value !=0)
            {
                bnfprgrsbar_süre.Value -= 1;
                bnfprgrsbar_süre.ProgressColor = Color.Red;
            }
           else
            {
                timer1.Stop();
                for (int z = y; z < 11; z++)
                {
                    cevapKontrol(false);
                }
                MessageBox.Show("sınavınız bitmiştir");
                frm_OgrenciMenu ogrMenu = new frm_OgrenciMenu();
                ogrMenu.Show();
                this.Close();
            }
        }

        private void A_Click_1(object sender, EventArgs e)
        {
            if (A.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                A.DisabledColor = Color.Green;
            }
            else
            {
                yanlis++;
                cevapKontrol(false);
                A.DisabledColor = Color.Red;
            }
            aktiflik();
        }

        private void B_Click_1(object sender, EventArgs e)
        {
            if (B.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                B.DisabledColor = Color.Green;
            }
            else
            {

                yanlis++;
                cevapKontrol(false);
                B.DisabledColor = Color.Red;
            }
            aktiflik();

        }

        private void C_Click_1(object sender, EventArgs e)
        {
            if (C.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                C.DisabledColor = Color.Green;
            }
            else
            {
                yanlis++;
                cevapKontrol(false);
                C.DisabledColor = Color.Red;
            }
            aktiflik();
        }

        private void D_Click_1(object sender, EventArgs e)
        {
            if (D.Name == label2.Text)
            {
                dogru++;
                cevapKontrol(true);
                D.DisabledColor = Color.Green;
            }
            else
            {

                yanlis++;
                cevapKontrol(false);
                D.DisabledColor = Color.Red;
            }
            aktiflik();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Sınavdan çıkmak isdeğnize emin msiniz ? Eğer çıkış yaparsanız diğer sorularınız yanlış olarak değerlendirilecektir", "Uyarı !!!", MessageBoxButtons.YesNo);

            if (secenek == DialogResult.Yes)
            {
                for (int z = y; z < 11; z++)
                {
                    cevapKontrol(false);
                }
                sinavlarBS.GecmisSinavlar((10-dogru), dogru);
                frm_OgrenciMenu frmOgrMenu = new frm_OgrenciMenu();
                frmOgrMenu.Show();
                this.Close();
            }
        }

        private void bfnbtn_basla_Click_1(object sender, EventArgs e)
        {
            lbl_soruSayisi.Text = (y + 1 + ". Soru");

            if (bfnbtn_basla.LabelText != "Sonraki Soru")
            {
                timer1.Start();
                bfnbtn_basla.LabelText = "Sonraki Soru";
            }

            x++;
            y++;

            A.DisabledColor = Color.Silver;
            B.DisabledColor = Color.Silver;
            C.DisabledColor = Color.Silver;
            D.DisabledColor = Color.Silver;

            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            bfnbtn_basla.Enabled = false;

            if (GirisYapanBilgileri.sınavId == 0)
            {
                if (x == 11)
                {
                    sinavlarBS.GecmisSinavlar(yanlis, dogru);
                    MessageBox.Show("Geçmiş Olsun...Sınavınız Bitmiştir..");
                    Application.Exit();
                }
                else
                {
                    bnftxt_Soru.Text = bilgi[x].soru;
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
                if (y < 6 && eksikler[y].soru != null)
                {
                    bnftxt_Soru.Text = eksikler[y].soru;
                    A.Text = eksikler[y].cevapA;
                    B.Text = eksikler[y].cevapB;
                    C.Text = eksikler[y].cevapC;
                    D.Text = eksikler[y].cevapD;
                    label1.Text = eksikler[y].soruId.ToString();
                    label2.Text = eksikler[y].dogruCevap;
                    label3.Text = eksikler[y].konu;
                    label5.Text = bilgi[y].konuId.ToString();
                }
                else if (y >= 6 && y < 11)
                {
                    bnftxt_Soru.Text = bilgi[y].soru;
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
    }
}

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
using DataLibrary;
using BusinessLibrary;

namespace ProjeSınamÖdevi
{
    public partial class frm_OgrenciSinavSonuc : Form
    {
        public frm_OgrenciSinavSonuc()
        {
            InitializeComponent();
        }
        SinavBilgileriBusiness sinavBS = new SinavBilgileriBusiness();
        List<SinavBilgileri> sinavBilgi;

        BasariBusiness basariBS = new BasariBusiness();
        List<Basari> konuBilgi;   
        int secilenSinav = 0;


        private void frm_SinavBilgileri_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            lbl_ograd.Text = (GirisYapanBilgileri.ogrAd + " " + GirisYapanBilgileri.ogrSoyad);

            sinavBilgi = sinavBS.SinavIcerigi(Convert.ToInt32(GirisYapanBilgileri.ogrninNosu));

            for (int i = 0; i <sinavBilgi.Count; i++)
            {
                bunifuDropdown1.Items.Add((sinavBilgi[i].sinavId)+1);
            }
        }
        


        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex == -1)
            { MessageBox.Show("Lütfen Görüntülenecek sinav bilgisiniz seçiniz !!"); }
            else
            {
                for (int i = 0; i < sinavBilgi.Count; i++)
                {
                    if (sinavBilgi[i].sinavId == bunifuDropdown1.selectedIndex)
                    {
                        secilenSinav = i;
                    }
                }
                konuBilgi = basariBS.KonularaGoreBasari(Convert.ToInt32(GirisYapanBilgileri.ogrninNosu), secilenSinav);

                foreach (var sonuclar in chart2.Series)
                {
                    sonuclar.Points.Clear();
                }
                for (int j = 0; j < konuBilgi.Count; j++)
                {
                    chart2.Series["BASARIORANLARI"].Points.AddXY(konuBilgi[j].konu.ToString(), konuBilgi[j].basariOran);
                }
            }
        }



        private void btnSinavBilgi_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            bunifuDropdown1.Visible = true;
            chart2.Visible = true;
            btnSonuclar.Visible = true;
            chart1.Visible = false;
            grid_GenelOranTablosu.Visible = false;
        }




        private void btnGenelSonuclar_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            bunifuDropdown1.Visible = false;
            chart2.Visible = false;
            btnSonuclar.Visible = false;
            chart1.Visible = true;
            grid_GenelOranTablosu.Visible = true;


            grid_GenelOranTablosu.RowCount = sinavBilgi.Count;
            for (int i = 0; i < sinavBilgi.Count; i++)
            {
                grid_GenelOranTablosu.Rows[i].Cells[0].Value = ((sinavBilgi[i].sinavId) + 1);
                grid_GenelOranTablosu.Rows[i].Cells[1].Value = sinavBilgi[i].dogruSay;
                grid_GenelOranTablosu.Rows[i].Cells[2].Value = sinavBilgi[i].yanlisSay;
                grid_GenelOranTablosu.Rows[i].Cells[3].Value = sinavBilgi[i].basYuzdesi;
            }
            foreach (var item in chart1.Series)
            {
                item.Points.Clear();
            }
            for (int k = 0; k < sinavBilgi.Count; k++)
            {
                chart1.Series["Genel Sonuçlar"].Points.AddXY(((sinavBilgi[k].sinavId) + 1).ToString() + ". Sınav", sinavBilgi[k].basYuzdesi);
            }
        }




        private void pcrebxCikis_Click(object sender, EventArgs e)
        {
            frm_OgrenciMenu frmMenu = new frm_OgrenciMenu();
            frmMenu.Show();
            this.Close();
        }
    }
}


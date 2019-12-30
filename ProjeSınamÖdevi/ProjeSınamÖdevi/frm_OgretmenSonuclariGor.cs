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
    public partial class frm_OgretmenSonuclariGor : Form
    {
        public frm_OgretmenSonuclariGor()
        {
            InitializeComponent();
        }

        SinavBilgileriBusiness sinavBS = new SinavBilgileriBusiness();
        List<SinavBilgileri> sinavBilgi;
        List<SinavBilgileri> ogrSinavSonuclari;
        int secilenOgrNo = 0;

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            { MessageBox.Show("Lütfen Sonuçlarını Görüntülemek İstediğiniz Öğrencinin Numarasını Seçiniz");}
            else
            {
                for (int i = 0; i < sinavBilgi.Count; i++)
                {
                    if (sinavBilgi[i].ogrNo == Convert.ToInt32(comboBox1.SelectedItem))
                    {
                        secilenOgrNo = sinavBilgi[i].ogrNo;
                    }
                }
                ogrSinavSonuclari = sinavBS.SinavIcerigi(secilenOgrNo);

                grid_GenelSonuclar.RowCount = ogrSinavSonuclari.Count();
                for (int i = 0; i < ogrSinavSonuclari.Count; i++)
                {
                    grid_GenelSonuclar.Rows[i].Cells[0].Value = (ogrSinavSonuclari[i].ogrNo);
                    grid_GenelSonuclar.Rows[i].Cells[1].Value = ((ogrSinavSonuclari[i].sinavId) + 1);
                    grid_GenelSonuclar.Rows[i].Cells[2].Value = ogrSinavSonuclari[i].dogruSay;
                    grid_GenelSonuclar.Rows[i].Cells[3].Value = ogrSinavSonuclari[i].yanlisSay;
                    grid_GenelSonuclar.Rows[i].Cells[4].Value = ogrSinavSonuclari[i].basYuzdesi;
                }
                foreach (var item in chr_SonucGrafik.Series)
                {
                    item.Points.Clear();
                }
                for (int k = 0; k < ogrSinavSonuclari.Count; k++)
                {
                    chr_SonucGrafik.Series["Başarı Oranları"].Points.AddXY(((ogrSinavSonuclari[k].sinavId) + 1).ToString() + ". Sınav", ogrSinavSonuclari[k].basYuzdesi);
                }
            }
        }

        private void frm_OgretmenSonuclariGor_Load(object sender, EventArgs e)
        {
            sinavBilgi = sinavBS.OgretmenSonuclariGoruntule();
            for (int i = 0; i < sinavBilgi.Count; i++)
            {
               comboBox1.Items.Add((sinavBilgi[i].ogrNo));
            }
        }

        private void frm_OgretmenSonuclariGor_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_OgretmenMenusu frmMenu = new frm_OgretmenMenusu();
            frmMenu.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CommonLibrary;

namespace DataLibrary
{
    public class OgrencilerDB
    {
        public Ogrenciler OgrenciGetir(string ad, string sifre)
        {
            Ogrenciler ogr = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_ogrenciler WHERE ogrKullaniciAdi = @adi AND ogrSifre = @sifre", connection);
                comm.Parameters.Add(new SqlParameter("@adi", ad));
                comm.Parameters.Add(new SqlParameter("@sifre", sifre));
                comm.ExecuteNonQuery();
                using (var read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ogr = new Ogrenciler();
                        ogr.ogrAdi = read["ogrAdi"].ToString();
                        ogr.ogrSoyad = read["ogrSoyad"].ToString();
                        ogr.ogrKullaniciAdi = read["ogrKullaniciAdi"].ToString();
                        ogr.ogrSifre = read["ogrSifre"].ToString();
                        ogr.ogrNo = (int)read["ogrNo"];
                        ogr.sinavId = (int)read["sinavId"];
                    }
                }
                connection.Close();
            }
            return ogr;
        }

        public Ogrenciler OgrenciSinavIdsiGuncelle()
        {
            Ogrenciler ogr = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("update tbl_ogrenciler set sinavId =@id where ogrNo=@ogrNo", connection);
                comm.Parameters.Add(new SqlParameter("@ogrNo", GirisYapanBilgileri.ogrninNosu));
                comm.Parameters.Add(new SqlParameter("@id",(Convert.ToInt32(GirisYapanBilgileri.sınavId)+1)));
                comm.ExecuteNonQuery();
                connection.Close();
            }
            return ogr;
        }
        
    }
}

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


        public List<Ogrenciler> SinavIdBilgisi()
        {
            List<Ogrenciler> sinavId = new List<Ogrenciler>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_ogrenciler WHERE ogrNo = @ogr", connection);
                comm.Parameters.Add(new SqlParameter("@ogr", GirisYapanBilgileri.ogrninNosu));
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ogrenciler sinavIdİcerik = new Ogrenciler();
                        sinavIdİcerik.sinavId = Convert.ToInt32(reader["sinavId"]);
                        sinavId.Add(sinavIdİcerik);
                    }
                }
                connection.Close();
            }
            return sinavId;
        }


        public Ogrenciler OgrenciSinavIdsiGuncelle(int sinavId)
        {
            Ogrenciler ogr = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("update tbl_ogrenciler set sinavId =@id where ogrNo=@ogrNo", connection);
                comm.Parameters.Add(new SqlParameter("@ogrNo", GirisYapanBilgileri.ogrninNosu));
                comm.Parameters.Add(new SqlParameter("@id",Convert.ToInt32(sinavId)+1));
                comm.ExecuteNonQuery();
                connection.Close();
            }
            return ogr;
        }


        
    }
}

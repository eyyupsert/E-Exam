using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CommonLibrary;

namespace DataLibrary
{
    public class SinavBilgileriDB
    {
        public SinavBilgileri GecmisSinavGoruntule(int yanlis ,int dogru)
        {
            SinavBilgileri bilgiler = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("insert into tbl_sinavBilgileri (sinavId,yanlisSay,dogruSay,basYuzdesi,ogrNo) values('" + GirisYapanBilgileri.sınavId + "','" + yanlis + "','" + dogru + "','" + (dogru*10) + "','" + GirisYapanBilgileri.ogrninNosu + "')", connection);
                comm.ExecuteNonQuery();
                connection.Close();
            }

            return bilgiler;
        }

        public List<SinavBilgileri> SinavIcerikleri(int ogrNo)
        {
            List<SinavBilgileri> sinavlar = new List<SinavBilgileri>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_sinavBilgileri WHERE ogrNo=@ogr ORDER BY sinavId", connection);
                comm.Parameters.Add(new SqlParameter("@ogr", ogrNo));
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SinavBilgileri sinavIcerik = new SinavBilgileri();
                        sinavIcerik.sinavId = Convert.ToInt32(reader["sinavId"]);
                        sinavIcerik.dogruSay = Convert.ToInt32(reader["dogruSay"]);
                        sinavIcerik.yanlisSay = Convert.ToInt32(reader["yanlisSay"]);
                        sinavIcerik.basYuzdesi = Convert.ToInt32(reader["basYuzdesi"]);
                        sinavIcerik.ogrNo = Convert.ToInt32(reader["ogrNo"]);
                        sinavlar.Add(sinavIcerik);
                    }
                }
                connection.Close();
            }
            return sinavlar;
        }

        public List<SinavBilgileri> OgretmenSonuclariGor()
        {
            List<SinavBilgileri> sinavlar = new List<SinavBilgileri>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_sinavBilgileri WHERE sinavId=0", connection);
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SinavBilgileri sinavIcerik = new SinavBilgileri();
                        sinavIcerik.ogrNo = Convert.ToInt32(reader["ogrNo"]);
                        sinavIcerik.sinavId = Convert.ToInt32(reader["sinavId"]);
                        sinavIcerik.dogruSay = Convert.ToInt32(reader["dogruSay"]);
                        sinavIcerik.yanlisSay = Convert.ToInt32(reader["yanlisSay"]);
                        sinavIcerik.basYuzdesi = Convert.ToInt32(reader["basYuzdesi"]);
                        sinavlar.Add(sinavIcerik);
                    }
                }
                connection.Close();
            }
            return sinavlar;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CommonLibrary;

namespace DataLibrary
{
    public class SorularDB
    {
        public Sorular SoruEkle(string konu, string soru, string a, string b, string c, string d, string cevap)
        {
            Sorular sorular = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("insert into tbl_sorular (konu,soru,cevapA,cevapB,cevapC,cevapD,dogruCevap) values('" + konu + "','" + soru + "','" + a + "','" + b + "','" + c + "','" + d + "','" + cevap + "')", connection);
                comm.ExecuteNonQuery();
                connection.Close();
            }
            return sorular;
                
        }
        public List<Sorular> SoruGoruntule()
        {
            List<Sorular> sorulars = new List<Sorular>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_sorular s inner join tbl_konular k on k.konu=s.konu order by NEWID()", connection);
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sorular soruIcerik = new Sorular();
                        soruIcerik.soruId = Convert.ToInt32(reader["soruId"]);
                        soruIcerik.konuId = Convert.ToInt32(reader["konuId"]);
                        soruIcerik.konu = reader["konu"].ToString();
                        soruIcerik.soru = reader["soru"].ToString();
                        soruIcerik.cevapA = reader["cevapA"].ToString();
                        soruIcerik.cevapB = reader["cevapB"].ToString();
                        soruIcerik.cevapC = reader["cevapC"].ToString();
                        soruIcerik.cevapD = reader["cevapD"].ToString();
                        soruIcerik.dogruCevap = reader["dogruCevap"].ToString();

                        sorulars.Add(soruIcerik);
                    }
                }
                connection.Close();
            }
            return sorulars;
        }

        public List<Sorular> EksikKonuluSorular(int ogrNo)
        {
            List<Sorular> eksikler = new List<Sorular>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_sorular S inner join tbl_konular K on K.konu = S.konu  WHERE S.konu IN (SELECT konu FROM tbl_ogrenciCevaplari WHERE ogrNo=@no and cevapNitelik=0) ", connection);
                comm.Parameters.Add(new SqlParameter("@no", ogrNo));
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sorular eksikSoru = new Sorular();
                        eksikSoru.soruId = Convert.ToInt32(reader["soruId"]);
                        eksikSoru.konu = reader["konu"].ToString();
                        eksikSoru.soru = reader["soru"].ToString();
                        eksikSoru.konuId = Convert.ToInt32(reader["konuId"]);
                        eksikSoru.cevapA = reader["cevapA"].ToString();
                        eksikSoru.cevapB = reader["cevapB"].ToString();
                        eksikSoru.cevapC = reader["cevapC"].ToString();
                        eksikSoru.cevapD = reader["cevapD"].ToString();
                        eksikSoru.dogruCevap = reader["dogruCevap"].ToString();
                        eksikler.Add(eksikSoru);
                    }
                }
                connection.Close();
            }
            return eksikler;
        }
    }
}

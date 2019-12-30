using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Data.SqlClient;
using CommonLibrary;

namespace DataLibrary
{
    public class BasariDB
    {
        public List<Basari> KonuBasarisi(int ogrNo,int secilenSinav)
        {
            using (var connection = Database.BaglantiGetir())
            {
                var cmd = new SqlCommand("exec basarilariHesapla @ogr,@sinavId ", connection);
                cmd.Parameters.AddWithValue("@ogr", ogrNo);
                cmd.Parameters.AddWithValue("@sinavId", secilenSinav);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            List<Basari> sonuclar = new List<Basari>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("select k.konu,b.basariOran from tbl_basari b join tbl_konular k on k.konuId = b.konuId WHERE b.ogrNo=@ogrNo and b.sinavId=@sinavId", connection);
                comm.Parameters.AddWithValue("@ogrNo", ogrNo);
                comm.Parameters.AddWithValue("@sinavId", secilenSinav);
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Basari konuIcerik = new Basari();
                        konuIcerik.konu = reader["konu"].ToString();
                        konuIcerik.basariOran = Convert.ToInt32(reader["basariOran"].ToString());
                        sonuclar.Add(konuIcerik);
                    }
                }
                connection.Close();
            }
            return sonuclar;
        }
    }
}

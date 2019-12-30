using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLibrary;
using CommonLibrary;

namespace DataLibrary
{
    public class OgrenciCevaplariDB
    {
        public OgrenciCevaplari OgrenciCevap(int idNo,string konuBilgi,bool cevap,int konuId)
        {
            OgrenciCevaplari cev = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("insert into tbl_ogrenciCevaplari (sinavId,soruId,ogrNo,konu,cevapNitelik,konuId) values('"+ GirisYapanBilgileri.sınavId + "','" + idNo + "','" + GirisYapanBilgileri.ogrninNosu + "','" + konuBilgi + "','" + cevap + "','" + konuId +"')", connection);
                comm.ExecuteNonQuery();
                connection.Close();
            }
            return cev;
        }


        
    }
}

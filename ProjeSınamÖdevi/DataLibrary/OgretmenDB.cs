using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CommonLibrary;

namespace DataLibrary
{
    public class OgretmenDB
    {
        public Ogretmen OgretmenGetir(string ogrtAd, string ogrtSifre)
        {
            Ogretmen ogrt = null;
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT * FROM tbl_ogretmen WHERE ogrtmnKulAdi = @kuladi AND ogrtmnSifre = @kulsifre", connection);
                comm.Parameters.Add(new SqlParameter("@kuladi", ogrtAd));
                comm.Parameters.Add(new SqlParameter("@kulsifre", ogrtSifre));
                comm.ExecuteNonQuery();
                using (var read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ogrt = new Ogretmen();
                        ogrt.ogretmenId = (int)read["ogretmenId"];
                        ogrt.ogrtmnKulAdi = read["ogrtmnKulAdi"].ToString();
                        ogrt.ogrtmnSifre = read["ogrtmnSifre"].ToString();
                    }
                }
                connection.Close();
            }
            return ogrt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace DataLibrary
{
    public class Database
    {
        public static SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OEAIEJR\SQLEXPRESS;Initial Catalog=SinavProjesi;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
        public static SqlCommand SorguOlustur(string sorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sorgu, BaglantiGetir());
            return sqlCommand;
        }
    }
}

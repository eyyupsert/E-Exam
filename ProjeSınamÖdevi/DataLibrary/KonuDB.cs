using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CommonLibrary;

namespace DataLibrary
{
    public class KonuDB
    {
        public List<Konular>  KonularıGetir()
        {
            List<Konular> konular = new List<Konular>();
            using (var connection = Database.BaglantiGetir())
            {
                var comm = new SqlCommand("SELECT konu FROM tbl_konular ", connection);
                comm.ExecuteNonQuery();
                using (var read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Konular konu = new Konular();
                        konu.konu = read["konu"].ToString();
                        konular.Add(konu);
                    }
                }
                connection.Close();
            }
            return konular;
        }
    }
}

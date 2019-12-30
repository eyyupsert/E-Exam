using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using CommonLibrary;
namespace BusinessLibrary
{
    public class OgretmenBusiness
    {
        private OgretmenDB db = new OgretmenDB();

        public Ogretmen GetOgretmenler(string ad, string sifre)
        {
            return db.OgretmenGetir(ad, sifre);
        }
    }
}

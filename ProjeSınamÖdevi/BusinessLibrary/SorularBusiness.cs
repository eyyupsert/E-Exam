using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using DataLibrary;

namespace BusinessLibrary
{
    public class SorularBusiness
    {
        private SorularDB soruDB = new SorularDB();

        public Sorular SoruEklet(string konu,string soru,string a,string b, string c,string d,string cevap)
        {
            return soruDB.SoruEkle(konu,soru,a,b,c,d,cevap);
        }

        public List<Sorular> SoruGoruntule()
        {
            return soruDB.SoruGoruntule();
        }

        public List<Sorular> EksikKonuluSoru(int ogrNo)
        {
            return soruDB.EksikKonuluSorular(ogrNo);
        }
    }
}

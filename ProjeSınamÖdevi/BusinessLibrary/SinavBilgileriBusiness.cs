using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class SinavBilgileriBusiness
    {
        public SinavBilgileriDB sinav = new SinavBilgileriDB();

        public SinavBilgileri GecmisSinavlar(int yanlis ,int doru, int sinavId)
        {
            return sinav.GecmisSinavGoruntule(yanlis,doru,sinavId);
        }

        public List<SinavBilgileri> SinavIcerigi(int ogrNo)
        {
            return sinav.SinavIcerikleri(ogrNo);
        }

        public List<SinavBilgileri> OgretmenSonuclariGoruntule()
        {
            return sinav.OgretmenSonuclariGor();
        }
    }
}

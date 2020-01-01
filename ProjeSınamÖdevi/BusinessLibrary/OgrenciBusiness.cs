using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class OgrenciBusiness
    {
        private OgrencilerDB db = new OgrencilerDB();
        
        public Ogrenciler GetOgrenciler(string ad, string sifre)
        {
            return db.OgrenciGetir(ad, sifre);
        }

        public Ogrenciler GuncellemeSinav(int sinavId)
        {
            return db.OgrenciSinavIdsiGuncelle(sinavId);
        }

        public List<Ogrenciler> SinavIdBilgisiGetir()
        {
            return db.SinavIdBilgisi();
        }


    }
}

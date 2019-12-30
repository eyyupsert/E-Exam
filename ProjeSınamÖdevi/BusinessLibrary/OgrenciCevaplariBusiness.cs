using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class OgrenciCevaplariBusiness
    {
        private OgrenciCevaplariDB cevap = new OgrenciCevaplariDB();

        public OgrenciCevaplari CevapKontrol(int idNosu,string konusu,bool cevaplar, int konuId)
        {
            return cevap.OgrenciCevap(idNosu,konusu,cevaplar,konuId);
        }
    }
}

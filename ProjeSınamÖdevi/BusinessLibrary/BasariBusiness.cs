using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using DataLibrary;

namespace BusinessLibrary
{
    public class BasariBusiness
    {
        private BasariDB basariDB = new BasariDB();

        public List<Basari> KonularaGoreBasari(int ogrNo,int secilenSinav)
        {
            return basariDB.KonuBasarisi(ogrNo, secilenSinav);
        }
    }
}

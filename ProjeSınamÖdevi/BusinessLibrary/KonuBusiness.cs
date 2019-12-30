using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using DataLibrary;

namespace BusinessLibrary
{
    public class KonuBusiness
    {
        private KonuDB koruDB = new KonuDB();
        public List<Konular> Konular()
        {
            return koruDB.KonularıGetir();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class OgrenciCevaplari
    {
        public int sınavId { get; set; }
        public int soruId { get; set; }
        public int ogrNo { get; set; }
        public string konu { get; set; }
        public string cevapNitelik { get; set; }
        public int konuId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Sorular
    {
        public int soruId { get; set; }
        public int konuId { get; set; }
        public string konu { get; set; }
        public string soru { get; set; }
        public string cevapA { get; set; }
        public string cevapB { get; set; }
        public string cevapC { get; set; }
        public string cevapD { get; set; }
        public string dogruCevap { get; set; }
    }
}

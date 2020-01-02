using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLibrary;
using CommonLibrary;
using System.Collections.Generic;

namespace SinamaTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SoruGoruntulemeTest()
        {
            SorularBusiness soruBll = new SorularBusiness();
            List<Sorular> sorular = soruBll.SoruGoruntule();
            Assert.IsNotNull(sorular);
        }

        [TestMethod]
        public void SinavSonuclariTest()
        {
            SinavBilgileriBusiness sinavBll = new SinavBilgileriBusiness();
            List<SinavBilgileri> sinavlar = sinavBll.SinavIcerigi(0);
            Assert.IsNotNull(sinavlar);
        }

        [TestMethod]
        public void OgretmenSonucGorunmtulumeTesti()
        {
            SinavBilgileriBusiness sonuclarBLL = new SinavBilgileriBusiness();
            List<SinavBilgileri> sonuclar = sonuclarBLL.OgretmenSonuclariGoruntule();
            Assert.IsNotNull(sonuclar);
        }

    }
}

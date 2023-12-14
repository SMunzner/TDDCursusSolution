using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RechthoekTest
    {
        //OPPERVLAKTE

        [TestMethod("Lengte 3 * breedte 4 geeft oppervlakte 12")]
        public void Oppervlakte_GelijkAan_LengteEnBreedte()
        {
            Assert.AreEqual(12, new Rechthoek(3, 4).Oppervlakte());
        }

        [TestMethod]
        public void Oppervlakte_GelijkAan_PositiefGetal()
        {
            Assert.IsTrue(new Rechthoek(3, 4).Oppervlakte() > 0);
        }

        [TestMethod]
        public void Oppervlakte_NietGelijkAan_Null()
        {
            Assert.IsNotNull(new Rechthoek(3, 4).Oppervlakte());
        }


        //OMTREK

        [TestMethod("Lengte 3 + breedte 4 * 2 geeft omtrek 14")]
        public void Omtrek_GelijkAan_LengteEnBreedte()
        {
            Assert.AreEqual(14, new Rechthoek(3, 4).Omtrek());
        }

        [TestMethod]
        public void Omtrek_GelijkAan_PositiefGetal()
        {
            Assert.IsTrue(new Rechthoek(3, 4).Omtrek() > 0);
        }

        [TestMethod]
        public void Omtrek_NietGelijkAan_Null()
        {
            Assert.IsNotNull(new Rechthoek(3, 4).Omtrek());
        }

    }
}

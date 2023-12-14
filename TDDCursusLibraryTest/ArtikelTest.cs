using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{

    [TestClass]
    public class ArtikelTest
    {
        [TestMethod]
        public void PrijsInclusiefBtw_IsGelijkAan_PrijsMetBtw()
        {
            Assert.AreEqual( 15, new Artikel(10, 0.5m).PrijsInclusiefBtw());
        }

        [TestMethod]
        public void PrijsInclusiefBtw_IsNiet_Negatief()
        {
            Assert.IsFalse(new Artikel(10, 0.5m).PrijsInclusiefBtw() < 0);
        }

        [TestMethod]
        public void PrijsInclusiefBtw_IsNietGelijkAan_Null()
        {
            Assert.IsNotNull(new Artikel(10, 0.5m).PrijsInclusiefBtw());
        }

        [TestMethod]
        public void PrijsExclusiefBtw_IsNiet_Negatief()
        {
            Assert.IsFalse(new Artikel(10, 0.5m).PrijsExclusiefBtw < 0);
        }




    }
}

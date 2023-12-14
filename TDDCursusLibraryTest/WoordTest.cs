using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{

    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void IsPalindroom_GelijkAan_ReverseWoord()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }

        [TestMethod]
        public void IsPalindroom_NietGelijkAan_Null() 
        {
            Assert.IsNotNull(new Woord("lepel").IsPalindroom());
        }


    }
}

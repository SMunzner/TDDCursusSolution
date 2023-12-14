using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void InchesNaarCentimeters_IsGelijkAan_InchesMaal254()
        {
            Assert.AreEqual(2.54m, Converter.InchesNaarCentimeters(1));
        }

        [TestMethod]
        public void InchesNaarCentimeters_IsNiet_Negatief()
        {
            Assert.IsFalse(Converter.InchesNaarCentimeters(1) < 0);
        }

        [TestMethod]
        public void InchesNaarCentimeters_IsNiet_Null()
        {
            Assert.IsNotNull(Converter.InchesNaarCentimeters(1));
        }
    }
}

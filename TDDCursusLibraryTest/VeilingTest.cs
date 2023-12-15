using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;

        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }

        [TestMethod]
        public void HoogsteBod_NieuweVeiling_IsNul()
        {
            //Arrange
            //var veiling = new Veiling();

            //Act

            //Assert
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }

        [TestMethod]
        public void HoogsteBod_NaEersteBod_IsBod()
        {
            //Arrange
            //var veiling = new Veiling();
            var bod = 1000;
            
            //Act
            veiling.DoeBod(bod);
            var hoogste = veiling.HoogsteBod;

            //Assert
            Assert.AreEqual(bod, hoogste);
        }

        [TestMethod]
        public void HoogsteBod_NaMeerdereBoden_IsHoogsteBod()
        {
            //Arrange
            //var veiling = new Veiling();
            var bod = 1000;
            var bod2 = 2000;

            //Act
            veiling.DoeBod(bod2);
            veiling.DoeBod(bod);
            var hoogste = veiling.HoogsteBod;

            //Assert
            Assert.IsTrue(bod2 == hoogste);
        }

        [TestMethod]
        public void HoogsteBod_IsNiet_Negatief()
        {
            //Arrange
            //var veiling = new Veiling();
            var bod = -1000;

            //Act
            veiling.DoeBod(bod);

            //Assert
            Assert.IsFalse(veiling.HoogsteBod < 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class IsbnTest
    {
        [DataTestMethod]
        [DataRow(9789027439642L)]
        [TestMethod]
        public void New_MetCorrectNummer_IsOK(long nummer)
        {
            // Arrange
            // Act
            // Assert
            Isbn isbn = new Isbn(nummer);
            Assert.AreEqual(nummer, isbn.GetIsbn());
        }

        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        ////nummer met 12 cijfers Is niet OK
        //public void New_MetTeKortNummer_IsNietOK()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new Isbn(978902743964L);
        //}

        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        ////nummer met 14 cijfers Is niet OK
        //public void New_MetTeLangNummer_IsNietOK()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new Isbn(97890274396422L);
        //}

        ////normaal ook testen voor geldige eerste drie nummers 978, 979

        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        ////nummer waar 3 eerste cijfers niet beginnen met 978
        //public void New_MetOngeldigeEersteCijfers_IsNietOK()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new Isbn(9889027439642L);
        //}

        [DataTestMethod]
        [DataRow(978902743964L)]
        [DataRow(97890274396422L)]
        [DataRow(9889027439642L)]

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void New_MetVerkeerdNummer_IsNietOK(long nummer)
        {
            new Isbn (nummer);
        }


    }
}

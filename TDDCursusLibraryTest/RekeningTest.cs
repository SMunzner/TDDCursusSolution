﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningTest
    {
        //een keer rekening object aanmaken
        private Rekening rekening = null!;

        [TestInitialize] 
        public void Initialize() 
        {           
            rekening = new Rekening();
        }



        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Het Bedrag Van Een Storting Mag Niet Nul Zijn
        public void Storten_NulEuroStorten_Exception()
        {
            // Arrange
            // Act
            // Assert
            rekening.Storten(decimal.Zero);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Het Bedrag Van Een Storting Mag Niet Negatief Zijn
        public void Storten_NegatiefBedragStorten_Exception()
        {
            // Arrange
            // Act
            // Assert
            rekening.Storten(-1m);
        }



        // Het Saldo Van Een Nieuwe Rekening Is Nul
        [TestMethod]
        public void Saldo_NieuwRekening_IsNul()
        {
            // Arrange
            //rekening = new Rekening();
            // Act
            // Assert
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }
        // Het Saldo Na Een Eerste Storting Is Het Bedrag Van Die Storting
        [TestMethod]
        public void Saldo_NaEersteStorting_BedragVanDeStorting()
        {
            // Arrange
            //var rekening = new Rekening();
            var bedrag = 2.5m;
            // Act
            rekening.Storten(bedrag);
            // Assert
            Assert.AreEqual(bedrag, rekening.Saldo);
        }
        // Het Saldo Na Twee Stortingen Is De Som Van De Bedragen Van Die Stortingen
        [TestMethod]
        public void Saldo_NaTweeStortingen_SomVanDeStortingen()
        {
            // Arrange
            //var rekening = new Rekening();
            // Act
            rekening.Storten(2.5m);
            rekening.Storten(1.2m);
            // Assert
            Assert.AreEqual(3.7m, rekening.Saldo);
        }


        //METHOD DIE COLLECTION TERUGGEEFT
        [TestMethod]
        public void Stortingen_NieuweRekening_GeenStortingen()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(rekening.Stortingen().Count, 0);
        }
        [TestMethod]
        public void Stortingen_Stort10Euro_1StortingVan10Euro()
        {
            // Arrange
            rekening.Storten(10m);
            // Act
            // Assert
            Assert.AreEqual(rekening.Stortingen().Count, 1);
            Assert.IsTrue(rekening.Stortingen().Contains(10m));
        }
        [TestMethod]
        public void Stortingen_Stort10EuroEn1Euro_2StortingVan10EuroEn1Euro()
        {
            // Arrange
            rekening.Storten(10m);
            rekening.Storten(1m);
            // Act
            // Assert
            Assert.AreEqual(rekening.Stortingen().Count, 2);
            Assert.IsTrue(rekening.Stortingen().Contains(10m));
            Assert.IsTrue(rekening.Stortingen().Contains(1m));
        }
        [TestMethod]
        public void StortingenGesorteerd_Stort10EuroEn1EuroEn2Euro_StortingenGesorteerd1EuroEn2EuroEn10Euro()
        {
            // Arrange
            rekening.Storten(10m);
            rekening.Storten(1m);
            rekening.Storten(2m);
            // Act
            var stortingenGesorteerd = rekening.StortingenGesorteerd();
            // Assert
            Assert.AreEqual(stortingenGesorteerd.IndexOf(1m), 0);
            Assert.AreEqual(stortingenGesorteerd.IndexOf(2m), 1);
            Assert.AreEqual(stortingenGesorteerd.IndexOf(10m), 2);
        }

    }
}

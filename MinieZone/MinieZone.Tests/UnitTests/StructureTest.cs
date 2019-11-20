using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MinieZone.Tests;

namespace MinieZone.Tests.UnitTests
{
    [TestClass]
    public class StructureTest
    {
        [TestMethod]
        public void FirstTest()
        {
            //AAA
            //ARRANGE
            var Voiture = new Voiture();
            Voiture.Couleur = "rouge";
            //ACT
            Voiture.Peindre("Vert");
            //ASSERT
            Assert.AreEqual(Voiture.Couleur, "Vert");
        }

        [TestMethod]
        public void InputOutput()
        {
            //ARRANGE
            var Voiture = new Voiture();

            //Act
            var nouvelleCoulleur = Voiture.Peindre2("Rouge");

            //ASSERT
            Assert.AreEqual(nouvelleCoulleur, "Vert");
        }
    }

}

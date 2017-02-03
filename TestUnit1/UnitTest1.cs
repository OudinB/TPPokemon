using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnit1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckConnexionUser()
        {
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();
            bool result = bm.CheckConnexionUser("toto", "pouet");

            Assert.AreEqual(false, result);

            result = bm.CheckConnexionUser("", "");

            Assert.AreEqual(true, result);

        }


        //[TestMethod]
        //public void TestgetPokemonByElem()
        //{
        //    BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

        //    var liste = bm.getPokemonByElem("Feu");
        //    Assert.AreEqual("Salameche", liste);

        //    liste = bm.getPokemonByElem("Eau");
        //    Assert.AreNotEqual("Salameche", liste);

        //}

        [TestMethod]
        public void TestgetPokemonForceVie()
        {
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

            var liste = bm.getPokemonForceVie();

            Assert.AreEqual(3, liste.Count);
            Assert.AreNotEqual(9, liste.Count);
        }


        [TestMethod]
        public void TestGetUtilisateurByLogin()
        {
            StubDataAccessLayer.DalManager dm = new StubDataAccessLayer.DalManager();

            var liste = bm.getPokemonForceVie();

            Assert.AreEqual(3, liste.Count);
            Assert.AreNotEqual(9, liste.Count);
        }
    }

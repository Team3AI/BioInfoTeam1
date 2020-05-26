
using LibreriaStringheTeam1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestStringheTeam1
{
    [TestClass]
    public class TestStringhe
    {
        [TestMethod]
        public void TestLunghezza()
        {
            int r = MetodiStringhe.LunghezzaStringa();
            Assert.AreEqual(3901, r);

        }
        [TestMethod]
        public void TestConfronto()
        {
            int r = MetodiStringhe.ConfrontoStringhe();
            Assert.AreEqual(1603, r);

        }
        [TestMethod]
        public void TestIdentico()
        {
            string identico = File.ReadAllText("testo_identico.txt");
            string r = MetodiStringhe.DNAidentico();
            Assert.AreEqual(identico, r);

        }
        [TestMethod]
        public void TestDifferenti()
        {
            int r = MetodiStringhe.CaratteriDifferenti();
            Assert.AreEqual(1, r);

        }
    }
}

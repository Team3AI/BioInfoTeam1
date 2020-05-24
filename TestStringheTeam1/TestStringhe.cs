using LibreriaStringheTeam1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestStringheTeam1
{
    [TestClass]
    public class TestStringhe
    {
        [TestMethod]
        public void TestMethod1()
        {
            int r = MetodiStringhe.LunghezzaStringa();
            Assert.AreEqual(3901, r);

        }
    }
}

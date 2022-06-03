using Microsoft.VisualStudio.TestTools.UnitTesting;
using SebasApp;

namespace SebasAppTests
{
    [TestClass]
    public class UnitTest1
    {
        Sebastian sebas = new Sebastian();

        [TestMethod]
        public void TestearSaludos()
        {
            string q1 = sebas.Quejas[0];             
            Assert.AreEqual(q1,"No parce eso esta muy dificil");
        }
    }
}

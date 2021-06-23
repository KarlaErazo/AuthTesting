using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]  
        public void TestMethod1()
        {
            string result = AuthTesting.Program.Something();
            Assert.AreEqual("Algo",result);
        }
        [TestMethod]
        public void TestLoginTrue()
        {
            bool result = AuthTesting.Program.Login("karla", "12345");
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestLoginFalse()
        {
            bool result = AuthTesting.Program.Login("karla12", "1234567");
            Assert.AreEqual(false, result);

        }

    }
}

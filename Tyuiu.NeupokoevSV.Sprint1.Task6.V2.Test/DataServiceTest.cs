using System.Collections.Specialized;
using Tyuiu.NeupokoevSV.Sprint1.Task6.V2.Lib;
namespace Tyuiu.NeupokoevSV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string s = "Hello world";

            bool res = ds.CheckHello(s);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}

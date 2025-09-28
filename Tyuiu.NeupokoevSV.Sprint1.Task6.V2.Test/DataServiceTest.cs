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
            string s = "Hello world";
            string v = "Hello";
            bool res = s.Contains(v);
            Assert.IsTrue(res);
        }
    }
}

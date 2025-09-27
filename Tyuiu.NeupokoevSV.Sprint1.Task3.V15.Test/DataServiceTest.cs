using Tyuiu.NeupokoevSV.Sprint1.Task3.V15.Lib;
namespace Tyuiu.NeupokoevSV.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double s = 1;
            double t = 2;
            var res = ds.DistanceOverTime(x, y, s, t);
            Assert.AreEqual(5, res);
        }
    }
}

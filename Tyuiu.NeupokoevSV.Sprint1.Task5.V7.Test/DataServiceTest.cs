using Tyuiu.NeupokoevSV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.NeupokoevSV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 75.5;
            double res = ds.AngleToHoursMinutes(f);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}

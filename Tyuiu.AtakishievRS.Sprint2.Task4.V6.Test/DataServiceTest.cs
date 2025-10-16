using Tyuiu.AtakishievRS.Sprint2.Task4.V6.Lib;
namespace Tyuiu.AtakishievRS.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 1);

            Assert.AreEqual(0.667, res, 0.001);
        }
    }
}

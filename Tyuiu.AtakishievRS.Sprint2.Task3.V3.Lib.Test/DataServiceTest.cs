using Tyuiu.AtakishievRS.Sprint2.Task3.V3.Lib;
namespace Tyuiu.AtakishievRS.Sprint2.Task3.V3.Lib.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void Meth()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 486;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Meth2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Meth3()
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = 0.951;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Meth4()
        {
            DataService ds = new DataService();
            double x = -34;
            double wait = -373.971;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}

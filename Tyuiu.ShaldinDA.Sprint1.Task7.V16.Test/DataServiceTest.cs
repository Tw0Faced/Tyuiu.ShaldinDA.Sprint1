using Tyuiu.ShaldinDA.Sprint1.Task7.V16.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 2;
            double wait = -0.105;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
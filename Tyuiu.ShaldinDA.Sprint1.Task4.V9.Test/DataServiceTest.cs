using Tyuiu.ShaldinDA.Sprint1.Task4.V9.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 1.183;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
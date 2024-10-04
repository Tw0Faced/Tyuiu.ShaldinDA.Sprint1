using Tyuiu.ShaldinDA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DayOfWeek()
        {
            DataService ds = new DataService();
            int res = ds.Calculate(1);
            Assert.AreEqual(1, res);
        }
    }
}
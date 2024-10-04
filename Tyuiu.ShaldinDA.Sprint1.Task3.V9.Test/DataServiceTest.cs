using Tyuiu.ShaldinDA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 150;
            
            var res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(2,3, res);
        }
    }
}
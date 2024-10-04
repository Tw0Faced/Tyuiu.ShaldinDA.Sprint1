using Tyuiu.ShaldinDA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "привеТ неделИ минутУ";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string result = "ТИУ";
            Assert.AreEqual(result, res);
        }
    }
}
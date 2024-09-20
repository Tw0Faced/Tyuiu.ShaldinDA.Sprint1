using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaldinDA.Sprint1.Task0.V2.Lib;


namespace Tyuiu.ShaldinDA.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaldinDA.Sprint1.Task1.V23.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double a = 1.0;
            double x = 2.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(0.785, res);
        }
    }
}
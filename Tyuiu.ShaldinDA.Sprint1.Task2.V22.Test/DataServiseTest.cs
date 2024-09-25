using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaldinDA.Sprint1.Task2.V22.Lib;

namespace Tyuiu.ShaldinDA.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            int x, y, z;
            x = 1;
            y = 2;
            z = 3;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(2, res);
        }
    }
}
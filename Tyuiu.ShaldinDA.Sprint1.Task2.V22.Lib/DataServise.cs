using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaldinDA.Sprint1.Task2.V22.Lib

{
    public class DataServise : ISprint1Task2V22
    {
        public int Calculate(double value, int valueTwo, int valueThree)
        {
            return (int)((value + valueTwo + valueThree) / 3);
        }
    }
}

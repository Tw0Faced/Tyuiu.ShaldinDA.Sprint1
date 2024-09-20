using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.ShaldinDA.Sprint1.Task1.V23.Lib
{
    public class DataServise : ISprint1Task1V23
    {
        public double Calculate(double a, double x)
        {
            double Pi = 3.14;
            return (x * Pi) / (2 * a);
            
        }
    }
}

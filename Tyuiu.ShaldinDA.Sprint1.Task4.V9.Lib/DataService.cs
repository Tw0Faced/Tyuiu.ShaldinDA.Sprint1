using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaldinDA.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Log(x * y) / (x - Math.Sqrt(y + y * y));
            return Math.Round(res, 3);
        }
    }
}
    
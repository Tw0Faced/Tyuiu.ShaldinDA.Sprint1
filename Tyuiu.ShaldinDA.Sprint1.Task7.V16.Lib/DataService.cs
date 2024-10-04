using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaldinDA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double a)
        {
            double z = Math.Sin(Math.Sqrt(a * a)) + (Math.Cos(a * a)) / (3 * a * a * a)- Math.Sin(Math.Sqrt(a * a - 1));
            return Math.Round(z, 3);
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaldinDA.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
            return Math.Round(minutes / 60.0, 3);
        }
    }
}


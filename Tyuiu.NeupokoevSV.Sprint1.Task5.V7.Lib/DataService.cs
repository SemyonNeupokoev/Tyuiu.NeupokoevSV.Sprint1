using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NeupokoevSV.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double t = f / 30;
            int h = (int)Math.Floor(t);
            return h;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NeupokoevSV.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            var res = x - y - 0.062;
            return Math.Round(res, 3);
        }
    }
}

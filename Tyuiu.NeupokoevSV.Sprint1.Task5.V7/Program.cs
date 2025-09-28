using Tyuiu.NeupokoevSV.Sprint1.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();
        Console.WriteLine("Введите значение F:");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = Convert.ToInt32(ds.AngleToHoursMinutes(f));
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
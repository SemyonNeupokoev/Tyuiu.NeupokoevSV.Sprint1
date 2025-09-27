using Tyuiu.NeupokoevSV.Sprint1.Task3.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Неупокоев С. В.| ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #15                                                              *");
        Console.WriteLine("* Выполнил: Неупокоев С. В.| ПИНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
        Console.WriteLine("* одинаковых массивов по длинне.                                                             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());
        int y;
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());
        int s;
        Console.WriteLine("Введите значение S:");
        s = Convert.ToInt32(Console.ReadLine());
        int t;
        Console.WriteLine("Введите значение T:");
        t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Площадь треугольника = " + ds.DistanceOverTime(x, y, s, t));
        Console.ReadKey();
    }
}
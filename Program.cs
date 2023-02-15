using System;
public class MainClass
{
    public static void Main()
    {
        double angh, angm, hour, min;
        Console.WriteLine("Введите значение угла y");
        angh = double.Parse(Console.ReadLine());
        if (angh >= 0 && angh <= 360)
        {
            angm = angh % 30;
            hour = (angh - angm) / 30;
            angm = angm * 2;
            min = angm / 6;
            Console.WriteLine($"Градус минутной стрелки={angm},Количество полных часов= {hour},Количество полных минут={min}");
        }
        else
        {
            Console.WriteLine("Введённые данные не верные");
        }
    }
}
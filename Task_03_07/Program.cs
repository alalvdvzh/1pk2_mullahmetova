namespace Task_03_07
{
    using System;

    class Program
    {//Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
    //где 2 g = 9,8 м/с2 – ускорение свободного падения.
        static void Main()
        {
            const double g = 9.8; // Ускорение свободного падения
            double tStart = 0.0;   // Начальное время
            double tEnd = 10.0;    // Конечное время (10 секунд)
            double step = 0.5;     // Шаг времени

            Console.WriteLine("-----------------------");
            Console.WriteLine("| Время (с) | Скорость (м/с) |");
            Console.WriteLine("-----------------------");

            for (double t = tStart; t <= tEnd; t += step)
            {
                double v = g * t;
                Console.WriteLine($"| {t,7:F1}  | {v,11:F2}      |");
            }

            Console.WriteLine("-----------------------");
        }
    }
}

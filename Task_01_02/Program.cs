namespace Task_01_02
{
    using System;

    class Program
    {//Найти значение выражения при a = 8, b = 14, с = π/4
        static void Main()
        {
            // Заданные значения
            int a = 8;
            int b = 14;
            double c = Math.PI / 4; // π/4

            // Вычисление первого выражения
            double cubeRoot = Math.Pow(a - 1, 1.0 / 3);     // Кубический корень из (a-1)
            double firstExpression = Math.Pow(b + cubeRoot, 1.0 / 4); // Корень 4-й степени

            // Вычисление второго выражения
            double absDiff = Math.Abs(a - b);                // |a - b|
            double sinC = Math.Sin(c);                       // sin(c)
            double tanC = Math.Tan(c);                       // tg(c)
            double secondExpression = absDiff * (Math.Pow(sinC, 2) + tanC);

            // Вывод результатов
            Console.WriteLine($"Первое выражение: {firstExpression:F4}");
            Console.WriteLine($"Второе выражение: {secondExpression:F4}");
        }
    }
}

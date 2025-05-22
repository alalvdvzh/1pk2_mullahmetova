namespace Task_03_06
{
    using System;

    class Program
    {//Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.
        static void Main()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("|   x   |   y    |");
            Console.WriteLine("-------------------");

            for (double x = -4.0; x <= 4.0; x += 0.5)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"| {x,5:F1} | {y,6:F1} |");
            }

            Console.WriteLine("-------------------");
        }
    }
}

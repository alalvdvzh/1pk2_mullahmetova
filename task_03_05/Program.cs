namespace task_03_05
{
    using System;

    class Program
    {
        static void Main()
        {//Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
        //Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
        //время работы программы
            try
            {
                // Ввод диапазона и шага
                Console.Write("Введите начальную температуру (°C): ");
                double start = double.Parse(Console.ReadLine());

                Console.Write("Введите конечную температуру (°C): ");
                double end = double.Parse(Console.ReadLine());

                Console.Write("Введите шаг (°C): ");
                double step = double.Parse(Console.ReadLine());

                // Проверка корректности данных
                if (step <= 0)
                    throw new ArgumentException("Шаг должен быть больше нуля.");

                if (start > end)
                    throw new ArgumentException("Начальная температура не может быть больше конечной.");

                // Заголовок таблицы
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("|  Цельсий  |  Фаренгейт  |");
                Console.WriteLine("-----------------------------");

                // Вывод данных
                for (double celsius = start; celsius <= end; celsius += step)
                {
                    double fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine($"| {celsius,8:F1}° | {fahrenheit,10:F1}° |");
                }

                Console.WriteLine("-----------------------------");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введены некорректные данные.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

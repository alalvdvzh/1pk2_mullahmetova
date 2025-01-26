namespace Task_03_FunctionTable
{
    internal class Program
    {
        /*
         * Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥| для -4≤x≤4, с шагом h = 0,5
         */
        static void Main(string[] args)
        {
            // Задаем начальное значение x
            double startX = -4;

            // Задаем конечное значение x
            double endX = 4;

            // Задаем шаг изменения x
            double stepH = 0.5;

            // Выводим заголовок таблицы
            Console.WriteLine("--------------------");
            Console.WriteLine("|      x     |      y     |");
            Console.WriteLine("--------------------");

            // Цикл для перебора значений x в заданном диапазоне с заданным шагом
            for (double x = startX; x <= endX; x += stepH)
            {
                // Вычисляем значение функции y = |x| (модуль x)
                double y = Math.Abs(x);

                // Выводим строку таблицы со значениями x и y
                // Используем форматирование для выравнивания колонок
                Console.WriteLine($"| {x,9:F1}   | {y,9:F1}   |");
            }

            Console.WriteLine("--------------------"); // Завершающая линия таблицы
            Console.ReadKey(); // Ожидание нажатия клавиши перед закрытием консоли
        }
    }
}
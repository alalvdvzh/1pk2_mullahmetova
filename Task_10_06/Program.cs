namespace Task_10_06
{
    using System;

    public class Program
    {//Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит наконсоль сгенерированный массив размерности n*n//
        public static void Main()
        {
            ArrayGeneration(5); // Пример вызова метода с n = 5
        }

        // Метод генерирует и выводит массив n x n
        public static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];
            Random rand = new Random();

            // Заполнение массива случайными числами от 1 до 100
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(1, 101);
                }
            }

            // Вывод массива на консоль
            Console.WriteLine($"Массив {n}xn:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(4) + " "); // Форматирование вывода
                }
                Console.WriteLine();
            }
        }
    }
}

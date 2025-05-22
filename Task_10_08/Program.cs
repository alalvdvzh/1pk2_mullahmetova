namespace Task_10_08
{
    using System;

    public class Program
    {//Создайте метод, который на вход принимает одномерный массив и число для поиска, верните индекс искомогоэлемента в массиве. Если элемента нет – верните индекс = -1//
        public static void Main()
        {
            int[] numbers = { 5, 3, 8, 1, 9 };
            int target = 8;

            int index = FindElementIndex(numbers, target);
            Console.WriteLine($"Индекс элемента {target}: {index}"); // Вывод: 2

            target = 10;
            index = FindElementIndex(numbers, target);
            Console.WriteLine($"Индекс элемента {target}: {index}"); // Вывод: -1
        }

        // Метод для поиска индекса элемента в одномерном массиве
        public static int FindElementIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Возвращаем индекс при совпадении
                }
            }
            return -1; // Элемент не найден
        }
    }
}

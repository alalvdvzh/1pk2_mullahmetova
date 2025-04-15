namespace Task_21_10
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        { /*Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммироватьихзначения.*/
            // Создаем новый словарь для результата
            Dictionary<string, int> result = new Dictionary<string, int>();

            // Добавляем все элементы из первого словаря
            foreach (var pair in dict1)
            {
                result[pair.Key] = pair.Value;
            }

            // Добавляем элементы из второго словаря
            foreach (var pair in dict2)
            {
                // Если ключ уже есть в результате, суммируем значения 
                if (result.ContainsKey(pair.Key))
                {
                    result[pair.Key] += pair.Value;
                }
                else // Или просто добавляем новую пару ключ-значение
                {
                    result[pair.Key] = pair.Value;
                }
            }

            return result;
        }

        static void Main()
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            {"кефир", 3},
            {"ряженка", 5},
            {"снежок", 4}
        };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            {"кефир", 2},
            {"бифидок", 6},
            {"ряженка", 1}
        };

            // Объединяем словари
            Dictionary<string, int> mergedDict = MergeDictionaries(dict1, dict2);

            // Выводим результат
            Console.WriteLine("Объединенный словарь:");
            foreach (var pair in mergedDict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}

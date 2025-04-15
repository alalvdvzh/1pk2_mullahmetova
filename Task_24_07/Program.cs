namespace Task_24_07
{
    using System;
    using System.Collections.Generic;

    class Program
    {/*Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащиеэтослово (регистронезависимо).*/
        static void Main()
        {
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Введите слово для поиска:");
            string searchWord = Console.ReadLine();

            // Получаем все строки, содержащие слово
            List<string> foundLines = FindWordInFile(filePath, searchWord);

            Console.WriteLine("\nНайденные строки:");
            foreach (string line in foundLines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }

        // Метод для поиска слова в файле (без учета регистра)
        static List<string> FindWordInFile(string filePath, string word)
        {
            List<string> result = new List<string>();

            // Проверяем существует ли файл
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден!");
                return result;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Проверяем содержит ли строка наше слово (без учета регистра)
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(line);
                    }
                }
            }

            return result; // Возвращаем все найденные строки
        }
    }
}

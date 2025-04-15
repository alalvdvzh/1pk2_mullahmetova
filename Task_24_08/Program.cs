namespace Task_24_08
{
    using System;

    class Program
    {/*реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенныепользователем*/
        static void Main()
        {
            Console.WriteLine("=== Простая замена текста в файле ===");

            //Запрашиваем у пользователя нужные данные
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();

            //Вызываем функцию замены
            ReplaceTextInFile(filePath, searchText, replaceText);

            Console.WriteLine("Готово! Нажмите Enter...");
            Console.ReadLine();
        }

        static void ReplaceTextInFile(string filePath, string searchText, string replaceText)
        {
            //Проверяем существует ли файл
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Ошибка: файл не найден");
                return;
            }
            string fileContent = File.ReadAllText(filePath);

            //Заменяем текст (без учета регистра)
            fileContent = fileContent.Replace(searchText, replaceText, StringComparison.OrdinalIgnoreCase);
            File.WriteAllText(filePath, fileContent);

            Console.WriteLine($"Заменили '{searchText}' на '{replaceText}'");
        }
    }
}

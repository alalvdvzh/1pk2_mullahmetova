namespace Task_24_06
{
    using System;
    using System.IO;

    class Program
    {/*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. ИспользуйтеStreamReader.*/
        static void Main()
        {
            //  Путь к файлу
            string filePath = @"C:\test\example.txt";
            int lineCount = CountLinesInFile(filePath);
            Console.WriteLine($"The file has {lineCount} line(s)");
            Console.ReadLine();
        }

        // Метод для подсчёта строк в файле
        static int CountLinesInFile(string path)
        {
            int counter = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
namespace Task_23_06
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {/*Напишите программу со следующими функциями:
1. Выведите информации о всех дисках в системе
2. Выведите содержимое каталога C:\Users (названия папок)
3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
a) Создание вложенного каталога “temp”
b) Вывод информации о текущем каталоге (имя, родитель и тд)
c) Вывод информации о вложенном каталоге
4. Переместите каталог “temp” по пути “D:\work\newTemp”
a) Реализуйте вывод информационного сообщения об успешном (или нет)
перемещении
5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
удалении.*/
            // Показываем все диски
            Console.WriteLine("1. Вот какие диски есть в компьютере:");
            string[] всеДиски = Directory.GetLogicalDrives();
            foreach (string диск in всеДиски)
            {
                Console.WriteLine($"- {диск}");
            }

            //Показываем папки в C:\Users
            Console.WriteLine("\n2. Вот какие папки есть в C:\\Users:");
            string[] папкиПользователей = Directory.GetDirectories(@"C:\Users");
            foreach (string папка in папкиПользователей)
            {
                Console.WriteLine($"- {Path.GetFileName(папка)}");
            }

            //Создаем папку work на диске D
            Console.WriteLine("\n3. Создаем папку D:\\work");
            string основнаяПапка = @"D:\work";
            Directory.CreateDirectory(основнаяПапка);
            Console.WriteLine("- Папка создана!");

            //Создаем папку temp внутри work
            Console.WriteLine("\n3a. Создаем папку temp внутри work");
            string временнаяПапка = @"D:\work\temp";
            Directory.CreateDirectory(временнаяПапка);
            Console.WriteLine("- Папка temp создана!");

            //Информация о папке work
            Console.WriteLine("\n3b. Информация о папке work:");
            Console.WriteLine($"- Имя: work");
            Console.WriteLine($"- Где находится: D:\\");
            Console.WriteLine($"- Полный путь: {основнаяПапка}");

            //Информация о папке temp
            Console.WriteLine("\n3c. Информация о папке temp:");
            Console.WriteLine($"- Имя: temp");
            Console.WriteLine($"- Где находится: D:\\work");
            Console.WriteLine($"- Полный путь: {временнаяПапка}");

            //Перемещаем папку temp в newTemp
            Console.WriteLine("\n4. Перемещаем папку temp в newTemp");
            string новаяПапка = @"D:\work\newTemp";
            Directory.Move(временнаяПапка, новаяПапка);
            Console.WriteLine("- Перемещение выполнено!");

            //Пробуем удалить старую папку temp
            Console.WriteLine("\n5. Пробуем удалить старую папку temp:");
            if (Directory.Exists(временнаяПапка))
            {
                Directory.Delete(временнаяПапка);
                Console.WriteLine("- Папка temp удалена!");
            }
            else
            {
                Console.WriteLine("- Папки temp уже нет (мы её переместили)");
            }

            Console.WriteLine("\nВсё сделано! Нажмите Enter чтобы выйти...");
            Console.ReadLine();
        }
    }
}

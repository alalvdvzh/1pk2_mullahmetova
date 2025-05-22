namespace Task_10_07
{
    using System;

    public class Program
    {//Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерный массив(состоящийиз символов русского алфавита) и выведите на консоль данный массив с помощью другого метода(который принимает данный массив в качестве параметра)//
        public static void Main()
        {
            // Генерация массива 3x4
            char[,] charArray = GenerateRussianCharArray(3, 4);
            // Вывод массива
            PrintCharArray(charArray);
        }

        // Генерация двумерного массива с русскими буквами
        public static char[,] GenerateRussianCharArray(int rows, int columns)
        {
            char[] russianLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[,] array = new char[rows, columns];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Выбор случайного символа из массива русских букв
                    int index = rand.Next(russianLetters.Length);
                    array[i, j] = russianLetters[index];
                }
            }
            return array;
        }

        // Вывод двумерного массива на консоль
        public static void PrintCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            Console.WriteLine("Символьный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

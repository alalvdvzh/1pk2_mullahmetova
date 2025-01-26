namespace Task_03_DivisibleNumbers
{
    internal class Program
    {
        /*
         * Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.
         */
        static void Main(string[] args)
        {
            // Задаем диапазон чисел
            int startNumber = 20;
            int endNumber = 50;

            // Выводим сообщение о результате
            Console.WriteLine($"Числа от {startNumber} до {endNumber}, делящиеся на 3, но не делящиеся на 5:");

            // Цикл для перебора чисел в заданном диапазоне
            for (int number = startNumber; number <= endNumber; number++)
            {
                // Проверяем, делится ли число на 3 и не делится на 5
                if (number % 3 == 0 && number % 5 != 0)
                {
                    // Если условие выполняется, выводим число на консоль
                    Console.WriteLine(number);
                }
            }

            Console.ReadKey(); // Ожидание нажатия клавиши перед закрытием консоли
        }
    }
}
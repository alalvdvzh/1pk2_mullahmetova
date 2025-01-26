namespace Task_03_InputCounter
{
    internal class Program
    {
        /*
         * Пользователь вводит в консоли произвольный текст. После каждого ввода консоль очищается.
         * Когда пользователь вводит слово «exit» или пустую строку – ввод останавливается и выводиться
         * количество строк введенных пользователем
         */
        static void Main(string[] args)
        {
            int lineCount = 0; // Счетчик введенных строк
            string userInput;   // Переменная для хранения ввода пользователя

            Console.WriteLine("Введите текст построчно. Для завершения введите 'exit' или пустую строку.");

            do
            {
                userInput = Console.ReadLine(); // Считываем ввод пользователя

                if (!string.IsNullOrEmpty(userInput) && userInput.ToLower() != "exit") // Проверяем, что ввод не пустой и не "exit"
                {
                    lineCount++; // Увеличиваем счетчик строк
                }

                Console.Clear(); // Очищаем консоль после каждого ввода
            }
            while (!string.IsNullOrEmpty(userInput) && userInput.ToLower() != "exit"); // Продолжаем цикл, пока ввод не пустой и не "exit"

            Console.WriteLine($"Введено строк: {lineCount}"); // Выводим общее количество введенных строк
            Console.ReadKey(); // Ожидаем нажатия клавиши перед закрытием консоли
        }
    }
}
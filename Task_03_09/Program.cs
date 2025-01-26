namespace Task_03_BankDeposit
{
    internal class Program
    {
        /*
         * Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
         * отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
         * менее y рублей.
         *  Примеры
         *  входные данные
         *  100
         *  10
         *  200
         *  выходные данные
         *  8
         */
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя начальную сумму вклада
            Console.WriteLine("Введите начальную сумму вклада (руб.):");
            double initialDeposit = double.Parse(Console.ReadLine());

            // Запрашиваем у пользователя годовой процент
            Console.WriteLine("Введите годовой процент (%):");
            double interestRate = double.Parse(Console.ReadLine());

            // Запрашиваем у пользователя желаемую сумму вклада
            Console.WriteLine("Введите желаемую сумму вклада (руб.):");
            double targetDeposit = double.Parse(Console.ReadLine());

            double currentDeposit = initialDeposit; // Текущая сумма вклада, начинается с начальной
            int years = 0; // Счетчик лет

            // Цикл, пока текущая сумма вклада меньше желаемой
            while (currentDeposit < targetDeposit)
            {
                years++; // Увеличиваем счетчик лет
                double interestEarned = currentDeposit * (interestRate / 100.0); // Вычисляем проценты
                currentDeposit += interestEarned; // Добавляем проценты к текущей сумме
                currentDeposit = Math.Truncate(currentDeposit); // Отбрасываем дробную часть (копейки)
            }

            // Выводим результат - количество лет
            Console.WriteLine($"Вклад составит не менее {targetDeposit} рублей через {years} лет.");

            Console.ReadKey(); // Ожидание нажатия клавиши перед закрытием консоли
        }
    }
}
namespace Task_02_AgeCheck
{
    internal class Program
    {
        /*
         * Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату)
         * произведите расчет является ли пользователь совершеннолетним на текущую дату и выведите
         * соответствующее сообщение об этом
         */
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя год рождения
            Console.WriteLine("Введите год рождения:");
            int birthYear = int.Parse(Console.ReadLine()); // Преобразуем ввод в целое число

            // Запрашиваем у пользователя месяц рождения
            Console.WriteLine("Введите месяц рождения:");
            int birthMonth = int.Parse(Console.ReadLine()); // Преобразуем ввод в целое число

            // Запрашиваем у пользователя день рождения
            Console.WriteLine("Введите день рождения:");
            int birthDay = int.Parse(Console.ReadLine());   // Преобразуем ввод в целое число

            // Создаем объект DateTime для даты рождения пользователя
            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);

            // Получаем текущую дату
            DateTime currentDate = DateTime.Now;

            // Вычисляем возраст пользователя
            int age = currentDate.Year - birthDate.Year;

            // Проверяем, наступил ли уже день рождения в текущем году
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--; // Если день рождения еще не наступил, уменьшаем возраст на 1
            }

            // Проверяем, является ли пользователь совершеннолетним (18 лет и старше)
            if (age >= 18)
            {
                Console.WriteLine($"Вам {age} лет, Вы совершеннолетний."); // Выводим сообщение для совершеннолетнего
            }
            else
            {
                Console.WriteLine($"Вам {age} лет, Вы несовершеннолетний."); // Выводим сообщение для несовершеннолетнего
            }

            Console.ReadKey(); // Ожидание нажатия клавиши перед закрытием консоли
        }
    }
}
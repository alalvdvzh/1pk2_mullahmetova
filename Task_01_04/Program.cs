namespace Task_01_04
{
    using System;

    class Program
    {
        static void Main()
        {//Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
            //расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
            //этом
            // Ввод данных пользователем
            Console.Write("Введите год рождения: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());

            // Создание даты рождения
            DateTime birthDate = new DateTime(year, month, day);

            // Текущая дата
            DateTime today = DateTime.Today;

            // Проверка совершеннолетия
            DateTime adultDate = birthDate.AddYears(18);
            bool isAdult = adultDate <= today;

            // Вывод результата
            Console.WriteLine(isAdult
                ? "Пользователь совершеннолетний."
                : "Пользователь несовершеннолетний.");
        }
    }
}

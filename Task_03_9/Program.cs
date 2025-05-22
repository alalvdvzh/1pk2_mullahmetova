namespace Task_03_9
{
    using System;

    class Program
    {//Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
       // отбрасывается.Каждый год сумма вклада становится больше.Определите, через сколько лет вклад составит не
       // менее y рублей.
       // Примеры
       // входные данные
       //100
       //10
       //200
        выходные данные
        8                               
        static void Main()
        {
            // Ввод данных
            int x = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int current = x;
            int years = 0;

            // Расчет лет
            while (current < y)
            {
                current = current * (100 + p) / 100; // Увеличение вклада с отбрасыванием дробной части
                years++;
            }

            // Вывод результата
            Console.WriteLine(years);
        }
    }
}

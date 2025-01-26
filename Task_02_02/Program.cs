namespace Task_02_MathExpression
{
    internal class Program
    {
        /*
         * Найти значение выражения при a = 8, b = 14, c = π/4
         *
         *        ⁴√(b + ³√a - 1)
         * ---------------------------
         *   |a - b| * (sin²c + tg c)
         */
        static void Main(string[] args)
        {
            // Заданные значения переменных
            double a = 8;
            double b = 14;
            double c = Math.PI / 4; // π/4 радиан

            // Вычисляем корень третьей степени из 'a'
            double cubeRootA = Math.Pow(a, 1.0 / 3.0);

            // Вычисляем подкоренное выражение для корня четвертой степени
            double underFourthRoot = b + cubeRootA - 1;

            // Вычисляем корень четвертой степени
            double fourthRoot = Math.Pow(underFourthRoot, 1.0 / 4.0);

            // Вычисляем модуль разности 'a' и 'b'
            double absDiffAB = Math.Abs(a - b);

            // Вычисляем синус от 'c'
            double sinC = Math.Sin(c);

            // Вычисляем квадрат синуса от 'c'
            double sinSquaredC = Math.Pow(sinC, 2);

            // Вычисляем тангенс от 'c'
            double tanC = Math.Tan(c);

            // Вычисляем знаменатель выражения
            double denominator = absDiffAB * (sinSquaredC + tanC);

            // Вычисляем числитель выражения
            double numerator = fourthRoot; // в коде примера корень 4й степени это весь числитель

            // Вычисляем итоговое значение выражения
            double result = numerator / denominator;

            // Выводим результат на консоль
            Console.WriteLine($"Значение выражения при a = {a}, b = {b}, c = {c} равно: {result}");

            Console.ReadKey();
        }
    }
}
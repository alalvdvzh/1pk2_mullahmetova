namespace Task_14_03
{
    using System;

    public static class MathOperations
    { //Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал.Сделайтетак, чтобы метод работал только для не отрицательных чисел.
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Число не может быть отрицательным.");

            if (n == 0)
                return 1;

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

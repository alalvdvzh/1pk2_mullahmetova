namespace Task_13_03
{
    using System;

    public class Car
    {//создайте класс автомобиля
    //свойства:
    //номер авто, марка, цвет, текущая скорость
    //методы:
    //езда(симитировать равномерное ускорение скорости автомобиля)
    //торможение(при превышении скорости автомобиля свыше допустимой - он должен остановиться)
    //конструторы
    //предусмотрите разные варианты инициализации объектов
        // Свойства класса
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int CurrentSpeed { get; private set; }

        // Конструкторы
        // По умолчанию
        public Car()
        {
            LicensePlate = "Неизвестно";
            Brand = "Неизвестно";
            Color = "Неизвестно";
            CurrentSpeed = 0;
        }

        // С основными параметрами (без скорости)
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0;
        }

        // С полными параметрами (включая скорость)
        public Car(string licensePlate, string brand, string color, int currentSpeed)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

        // Методы
        // Ускорение
        public void Accelerate(int acceleration)
        {
            if (acceleration > 0)
            {
                CurrentSpeed += acceleration;
                Console.WriteLine($"Скорость увеличена на {acceleration} км/ч. Текущая скорость: {CurrentSpeed} км/ч");
            }
            else
            {
                Console.WriteLine("Ускорение должно быть положительным!");
            }
        }

        // Торможение
        public void Brake(int maxAllowedSpeed)
        {
            if (CurrentSpeed > maxAllowedSpeed)
            {
                CurrentSpeed = 0;
                Console.WriteLine("Автомобиль остановлен из-за превышения скорости!");
            }
            else
            {
                Console.WriteLine("Скорость в допустимых пределах.");
            }
        }

        // Вывод информации
        public void PrintInfo()
        {
            Console.WriteLine(
                $"Номер: {LicensePlate}\n" +
                $"Марка: {Brand}\n" +
                $"Цвет: {Color}\n" +
                $"Текущая скорость: {CurrentSpeed} км/ч\n"
            );
        }
    }
}

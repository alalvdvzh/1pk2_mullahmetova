namespace Task_13_02
{
    using System;

    public class Pet
    {//создать класс питомца свойства:
    //кличка, вид животного, возраст, вес, отметка о состонии здоровья(здоров/нездоров)
    //методы:
    //вывод информации об объекте
    //изменение значения веса животного
    //изменение отметки о состоянии здоровья
    //конструторы:
    //предусмотрите разные варианты инициализации объектов
        // Свойства класса
        public string Nickname { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; }

        // Конструкторы
        // Конструктор по умолчанию
        public Pet()
        {
            Nickname = "Неизвестно";
            Species = "Неизвестно";
            Age = 0;
            Weight = 0.0;
            IsHealthy = false; // По умолчанию "нездоров"
        }

        // Конструктор с кличкой и видом
        public Pet(string nickname, string species)
        {
            Nickname = nickname;
            Species = species;
            Age = 0;
            Weight = 0.0;
            IsHealthy = true; // Предположим, что новый питомец здоров
        }

        // Конструктор со всеми параметрами
        public Pet(string nickname, string species, int age, double weight, bool isHealthy)
        {
            Nickname = nickname;
            Species = species;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }

        // Методы
        // Вывод информации о питомце
        public void PrintInfo()
        {
            string healthStatus = IsHealthy ? "здоров" : "нездоров";
            Console.WriteLine(
                $"Кличка: {Nickname}\n" +
                $"Вид: {Species}\n" +
                $"Возраст: {Age} лет\n" +
                $"Вес: {Weight} кг\n" +
                $"Состояние здоровья: {healthStatus}\n"
            );
        }

        // Изменение веса
        public void ChangeWeight(double newWeight)
        {
            if (newWeight >= 0)
            {
                Weight = newWeight;
                Console.WriteLine($"Вес изменён на {newWeight} кг");
            }
            else
            {
                Console.WriteLine("Вес не может быть отрицательным!");
            }
        }

        // Изменение состояния здоровья
        public void ToggleHealthStatus()
        {
            IsHealthy = !IsHealthy;
            Console.WriteLine($"Состояние здоровья изменено: {(IsHealthy ? "здоров" : "нездоров")}");
        }
    }
}

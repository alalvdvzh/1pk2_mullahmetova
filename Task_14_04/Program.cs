namespace Task_14_04
{
    public class User
    {//Определите класс User, который будет иметь статическое свойство Current User, представляющее текущего пользователя, и метод для его установки   
        // Статическое свойство для хранения текущего пользователя
        public static User CurrentUser { get; private set; }

        // Обычные свойства пользователя
        public string Name { get; set; }
        public int Id { get; set; }

        // Статический метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

        // Конструктор для удобного создания объектов User
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}

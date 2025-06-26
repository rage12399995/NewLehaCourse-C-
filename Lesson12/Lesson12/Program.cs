using System.Text.Json;
class Program
{
    public const string FilePath = "users.json";

    static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить пользователя");
            Console.WriteLine("2. Показать всех пользователей");
            Console.WriteLine("3. Сохранить изменения в файл");
            Console.WriteLine("4. Загрузить данные из файла");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    ShowUsers(LoadUsersFromFile());
                    break;
                case "3":
                    SaveUsersToFile(GetUsersFromConsole());
                    break;
                case "4":
                    ShowUsers(LoadUsersFromFile());
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте ещё раз.");
                    break;
            }
        }
    }

    static List<User> GetUsersFromConsole()
    {
        var users = new List<User>();
        bool adding = true;

        while (adding)
        {
            Console.Write("Введите ('str' для завершения): ");
            string name = Console.ReadLine();

            if (name.ToLower() == "str")
            {
                adding = false;
                continue;
            }

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите email: ");
            string email = Console.ReadLine();

            users.Add(new User { Name = name, Age = age, Email = email });
        }

        return users;
    }

    static void AddUser()
    {
        var users = LoadUsersFromFile();

        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите email: ");
        string email = Console.ReadLine();

        users.Add(new User { Name = name, Age = age, Email = email });
        SaveUsersToFile(users);
        Console.WriteLine("Пользователь добавлен и сохранен в файл!");
    }

    static void ShowUsers(List<User> users)
    {
        if (users.Count == 0)
        {
            Console.WriteLine("Список пользователей пуст.");
            return;
        }

        Console.WriteLine("\nСписок пользователей:");
        foreach (var user in users)
        {
            Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}, Email: {user.Email}");
        }
    }

    static void SaveUsersToFile(List<User> users)
    {
        try
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Данные сохранены в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении: {ex.Message}");
        }
    }

    static List<User> LoadUsersFromFile()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузке: {ex.Message}");
            return new List<User>();
        }
    }
}
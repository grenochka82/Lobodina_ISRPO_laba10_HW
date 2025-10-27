//class Program
//{
//    static void Task1_AnonymousTypes()
//    {
//        Console.WriteLine();
//        var student = new { Name = "Иван Петров", Age = 20, Group = "ИТ-21" };
//        Console.WriteLine("1. Отдельный студент:");
//        Console.WriteLine($"   Имя: {student.Name}");
//        Console.WriteLine($"   Возраст: {student.Age}");
//        Console.WriteLine($"   Группа: {student.Group}");
//        var students = new[]
//        {
//            new { Name = "Анна Сидорова", Age = 19, Group = "ИТ-21" },
//            new { Name = "Петр Иванов", Age = 21, Group = "ИТ-22" },
//            new { Name = "Мария Козлова", Age = 20, Group = "ИТ-21" },
//            new { Name = "Алексей Смирнов", Age = 22, Group = "ИТ-23" },
//            new { Name = "Елена Волкова", Age = 20, Group = "ИТ-22" }
//        };
//        Console.WriteLine("\n2. Список студентов (таблица):");
//        Console.WriteLine(new string('═', 50));
//        Console.WriteLine("│ {0,-20} │ {1,-5} │ {2,-8} │", "Имя", "Возраст", "Группа");
//        Console.WriteLine(new string('═', 50));
//        foreach (var s in students)
//        {
//            Console.WriteLine("│ {0,-20} │ {1,-5} │ {2,-8} │", s.Name, s.Age, s.Group);
//        }
//        Console.WriteLine(new string('═', 50));
//    }
//}
//static void Task2()
//{
//    Console.WriteLine("\n=== ЗАДАНИЕ 2: ЛЯМБДА-ВЫРАЖЕНИЯ ===\n");
//    List<int> numbers = Enumerable.Range(1, 20).ToList();
//    Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
//    Console.WriteLine("\n2.1 Четные числа:");
//    List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);
//    Console.WriteLine("   Результат: " + string.Join(", ", evenNumbers));
//    Console.WriteLine("\n2.2 Числа, кратные 3:");
//    List<int> multiplesOfThree = numbers.FindAll(n => n % 3 == 0);
//    Console.WriteLine("   Результат: " + string.Join(", ", multiplesOfThree));
//    Console.WriteLine("\n2.3 Дополнительно - числа больше 10 и меньше 15:");
//    var filteredNumbers = numbers.Where(n => n > 10 && n < 15);
//    Console.WriteLine("   Результат: " + string.Join(", ", filteredNumbers));
//    Console.WriteLine("\n2.4 Числа, квадрат которых больше 50:");
//    var squaredFilter = numbers.Where(n => n * n > 50);
//    Console.WriteLine("   Результат: " + string.Join(", ", squaredFilter));
//}
//static void Task3()
//{
//    Console.WriteLine();


//    List<IPrintable> printables = new List<IPrintable>
//        {
//            new Book("Война и мир", "Лев Толстой", 1869),
//            new Magazine("National Geographic", "Наука", 245),
//            new Book("Преступление и наказание", "Федор Достоевский", 1866),
//            new Magazine("Forbes", "Бизнес", 156),
//            new Book("Мастер и Маргарита", "Михаил Булгаков", 1967)
//        };
//    Console.WriteLine("Коллекция печатных изданий:");
//    Console.WriteLine(new string('─', 40));
//    foreach (var item in printables)
//    {
//        item.PrintInfo();
//        Console.WriteLine();
//    }
//}
//static void Task4()
//{
//    Console.WriteLine();
//    string[] cities = {
//            "Москва", "Санкт-Петербург", "Казань", "Краснодар",
//            "Новосибирск", "Калининград", "Красноярск", "Владивосток",
//            "Сочи", "Екатеринбург", "Кемерово"
//        };
//    Console.WriteLine("Все города: " + string.Join(", ", cities));
//    Console.WriteLine("\n2.1 Города, начинающиеся на букву 'К':");
//    var citiesStartingWithK = cities.Where(city => city.StartsWith("К"));
//    Console.WriteLine("   Результат: " + string.Join(", ", citiesStartingWithK));
//    Console.WriteLine("\n2.2 Отсортированные по длине названия:");
//    var sortedByLength = cities.OrderBy(city => city.Length);
//    Console.WriteLine("   Результат: " + string.Join(", ", sortedByLength));
//    Console.WriteLine("\n2.3 Города длиной более 6 символов:");
//    var longCities = cities.Where(city => city.Length > 6);
//    Console.WriteLine("   Результат: " + string.Join(", ", longCities));
//    Console.WriteLine("\n2.4 Первые 3 города в алфавитном порядке:");
//    var firstThreeAlphabetical = cities.OrderBy(city => city).Take(3);
//    Console.WriteLine("   Результат: " + string.Join(", ", firstThreeAlphabetical));
//    Console.WriteLine("\n2.5 Самый длинный город:");
//    var longestCity = cities.OrderByDescending(city => city.Length).First();
//    Console.WriteLine("   Результат: " + longestCity);
//    Console.WriteLine("\n2.6 Группировка по первой букве:");
//    var groupedByFirstLetter = cities.GroupBy(city => city[0])
//                                    .OrderBy(g => g.Key);
//    foreach (var group in groupedByFirstLetter)
//    {
//        Console.WriteLine($"   {group.Key}: {string.Join(", ", group)}");
//    }
//}
//static async Task<int> GetDataAsync()
//{
//    Console.WriteLine("   Начинаем загрузку данных...");
//    await Task.Delay(2000);
//    Random rnd = new Random();
//    int result = rnd.Next(1, 100);
//    Console.WriteLine($"    Данные получены: {result}");
//    return result;
//}
//static async Task Task5_AsyncProgramming()
//{
//    Console.WriteLine();
//    Console.WriteLine(" Запуск асинхронной операции:");
//    Console.WriteLine("1. Ждём данные...");
//    int result = await GetDataAsync();
//    Console.WriteLine($"2. Данные получены! Результат: {result}");
//    Console.WriteLine("3. Продолжаем работу...");
//    Console.WriteLine("\n Параллельная загрузка нескольких данных:");
//    var task1 = GetDataAsync();
//    var task2 = GetDataAsync();
//    var task3 = GetDataAsync();
//    Console.WriteLine("  Ожидаем завершения всех задач...");
//    int[] results = await Task.WhenAll(task1, task2, task3);
//    Console.WriteLine($"  Все данные загружены: {string.Join(", ", results)}");
//    Console.WriteLine($"  Сумма: {results.Sum()}, Среднее: {results.Average():F1}");
//}
//static async Task Task6()
//{
//    Console.WriteLine();
//    List<IPerson> people = new List<IPerson>
//        {
//            new Student("Анна Иванова", 20, "Информатика", 4.5),
//            new Teacher("Петр Сидоров", 45, "Факультет информатики", "Программирование"),
//            new Student("Максим Петров", 22, "Математика", 4.2),
//            new Student("Елена Козлова", 19, "Физика", 4.8),
//            new Teacher("Мария Васильева", 38, "Факультет математики", "Алгебра"),
//            new Student("Алексей Смирнов", 21, "Информатика", 4.1),
//            new Teacher("Дмитрий Попов", 52, "Факультет физики", "Квантовая механика"),
//            new Student("Ольга Новикова", 23, "Математика", 4.6)
//        };
//    Console.WriteLine(" Все люди в университете:");
//    Console.WriteLine(new string('─', 60));
//    foreach (var person in people)
//    {
//        Console.WriteLine(person.GetDescription());
//    }
//    Console.WriteLine("\n Студенты старше 20 лет:");
//    var olderStudents = people.OfType<Student>().Where(s => s.Age > 20);
//    foreach (var student in olderStudents)
//    {
//        Console.WriteLine(student.GetDescription());
//    }
//    Console.WriteLine("\n Преподаватели факультета информатики:");
//    var itTeachers = people.OfType<Teacher>().Where(t => t.Department == "Факультет информатики");
//    foreach (var teacher in itTeachers)
//    {
//        Console.WriteLine(teacher.GetDescription());
//    }
//    Console.WriteLine("\n Загрузка данных студентов...");
//    var students = await LoadStudentsAsync();
//    Console.WriteLine("\n Загруженные студенты:");
//    foreach (var student in students)
//    {
//        Console.WriteLine(student.GetDescription());
//    }
//    Console.WriteLine("\n Сортировка людей по имени (лямбда):");
//    var sortedPeople = people.OrderBy(p => p.Name);
//    foreach (var person in sortedPeople)
//    {
//        Console.WriteLine($"   {person.Name}");
//    }
//    Console.WriteLine("\n Дополнительная статистика:");
//    var averageStudentAge = people.OfType<Student>().Average(s => s.Age);
//    Console.WriteLine($"   Средний возраст студентов: {averageStudentAge:F1} лет");
//    var averageTeacherAge = people.OfType<Teacher>().Average(t => t.Age);
//    Console.WriteLine($"   Средний возраст преподавателей: {averageTeacherAge:F1} лет");
//    var bestStudent = people.OfType<Student>().OrderByDescending(s => s.GPA).First();
//    Console.WriteLine($"  Лучший студент: {bestStudent.Name} (GPA: {bestStudent.GPA:F2})");
//    Console.WriteLine("\n Студенты по специальностям:");
//    var studentsByMajor = people.OfType < Student()
//                                .GroupBy(s => s.Major)
//                                .OrderBy(g => g.Key);
//    foreach (var group in studentsByMajor)
//    {
//        Console.WriteLine($"   {group.Key}: {string.Join(", ", group.Select(s => s.Name))}");
//    }
//}
//static async Task<List<Student>> LoadStudentsAsync()
//{
//    Console.WriteLine("   ⏳ Имитация загрузки данных студентов...");
//    await Task.Delay(3000);
//    return new List<Student>
//        {
//            new Student("Новый Студент 1", 20, "Информатика", 4.3),
//            new Student("Новый Студент 2", 21, "Математика", 4.7),
//            new Student("Новый Студент 3", 19, "Физика", 4.4)
//        };
//}

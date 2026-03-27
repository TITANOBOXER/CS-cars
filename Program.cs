using CS_cars;

Console.WriteLine("Автосалон запущен. Введите марку автомобиля или done для выхода");
Console.WriteLine("Доступные марки:");
foreach (var type in Enum.GetValues<CarType>())
{
    Console.WriteLine($"- {type}");
}

while (true)
{
    Console.Write("Введите марку автомобиля или done: ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        continue;
    }

    if (input.Equals("done", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (!Enum.TryParse<CarType>(input, true, out var type))
    {
        Console.WriteLine($"Неизвестная марка '{input}'. Попробуйте еще раз.");
        continue;
    }

    try
    {
        ICar car = CarFactory.Create(type);
        Console.WriteLine(car.GetDescription());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}

Console.WriteLine("Выход.");

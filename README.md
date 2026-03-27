# CS-cars

Приложение реализует автосалон, который по марке автомобиля выводит описание модели.

## Задача

- Получать марку автомобиля от пользователя.
- Возвращать описание через `GetDescription()`.
- Сделать фабрику, которая по `enum CarType` возвращает `ICar`.
- Определить интерфейсы `IElectric`, `IGas`.
- Определить интерфейсы коробки передач `IMechanical`, `IAutomatical`.
- Сделать абстрактный класс `ACar` с общей реализацией.
- Каждый автомобиль должен быть отдельным классом.

## Архитектура реализации

- `Interfaces.cs`
  - `ICar` с методом `string GetDescription()`.
  - `IElectric` с `BatteryKilowattHours`.
  - `IGas` с `EngineType` и `Horsepower`.
  - `ITransmission` с `GetTransmissionInfo()`.
  - `IMechanical` и `IAutomatical` наследуются от `ITransmission`.

- `ACar.cs`
  - Абстрактный класс `ACar` реализует `ICar`.
  - Хранит общие свойства: `Make`, `Model`, `Seats`, `Year`, `Color`, `Transmission`.
  - Содержит общий `GetDescription()`.
  - Декларирует абстрактные методы `GetMaxSpeed()`, `GetSafetyRating()`, `GetEngineType()`.

- `CarStructure.cs`
  - `ElectricCar : ACar, IElectric`
    - добавляет `BatteryKilowattHours`.
    - дополняет `GetDescription()`.
    - реализует `GetMaxSpeed()`, `GetSafetyRating()`, `GetEngineType()`.
  - `GasCar : ACar, IGas`
    - добавляет `EngineType`, `Horsepower`.
    - дополняет `GetDescription()`.
    - реализует `GetMaxSpeed()`, `GetSafetyRating()`, `GetEngineType()`.

- `Gears.cs`
  - `MechanicalGear : IMechanical`.
  - `AutomaticalGear : IAutomatical`.
  - Хранит и возвращает информацию о коробке передач.

- `ConcreteCars.cs`
  - Отдельный класс для каждой марки автомобиля из `CarTypes.cs`.
  - Пример: `TeslaModelS`, `Zeekr`, `BMW`, `LadaGranta`, `Lamborghini` и др.

- `CarFactory.cs`
  - `CarFactory.Create(CarType type)` возвращает нужный `ICar`.

- `Program.cs`
  - Запуск CLI-программы.
  - Выводит список доступных марок.
  - Читает ввод пользователя.
  - При `done` завершает работу.

## Как запустить

```powershell
dotnet run --project .\CS-cars.csproj
```

## Пример работы

```
Автосалон запущен. Введите марку автомобиля или done для выхода
Доступные марки:
- Lamborghini
- Porsche
- Ferrari
- Bugatti
- Maibach
- Lixiang
- Zeekr
- Tesla
- BMW
- Mercedes
- Toyota
- Lada
Введите марку автомобиля или done: Tesla
Tesla: Model S model, 2024 year, white color, 5 seats, automatic transmission with sport mode, electrical car with 100 kWh battery
```

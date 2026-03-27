namespace CS_cars
{ 
  public static class CarFactory
  {
    public static ICar Create(CarType type)
    {
      return type switch
      {
        CarType.Lamborghini => new Lamborghini(),
        CarType.Porsche => new Porsche(),
        CarType.Ferrari => new Ferrari(),
        CarType.Bugatti => new Bugatti(),
        CarType.Maibach => new Maibach(),
        CarType.Lixiang => new Lixiang(),
        CarType.Zeekr => new Zeekr(),
        CarType.Tesla => new Tesla(),
        CarType.BMW => new BMW(),
        CarType.Mercedes => new Mercedes(),
        CarType.Toyota => new Toyota(),
        CarType.Lada => new LadaGranta(),
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unknown car type")
      };
    }
  }
}
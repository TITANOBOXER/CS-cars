namespace CS_cars
{
  public abstract class ElectricCar : ACar, IElectric
  {
    public int BatteryKilowattHours { get; init; }

    protected ElectricCar(string make, string model, int seats, ITransmission transmission, int year, string color, int battery)
      : base(make, model, seats, transmission, year, color)
    {
      BatteryKilowattHours = battery;
    }

    public override int GetMaxSpeed()
    {
      return (int)(BatteryKilowattHours * 2.5);
    }

    public override string GetSafetyRating()
    {
      if (BatteryKilowattHours > 90) return "5 stars";
      if (BatteryKilowattHours > 60) return "4 stars";
      return "3 stars";
    }

    public override string GetDescription()
    {
      return base.GetDescription() + $", electrical car with {BatteryKilowattHours} kWh battery";
    }

    public override string GetEngineType() => "Electric";
  }

  public abstract class GasCar : ACar, IGas
  {
    public string EngineType { get; init; }
    public int Horsepower { get; init; }

    protected GasCar(string make, string model, int seats, ITransmission transmission, int year, string color, string engineType, int hp)
      : base(make, model, seats, transmission, year, color)
    {
      EngineType = engineType;
      Horsepower = hp;
    }

    public override string GetDescription()
    {
      return base.GetDescription() + $", gas car with {EngineType}, {Horsepower} HP";
    }

    public override int GetMaxSpeed()
    {
      return (int)(Math.Cbrt(Horsepower) * 3.5);
    }

    public override string GetSafetyRating()
    {
      if (Horsepower > 400) return "5 stars";
      if (Horsepower > 200) return "4 stars";
      return "3 stars";
    }

    public override string GetEngineType() => EngineType;
  }
}
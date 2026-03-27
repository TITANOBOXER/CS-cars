namespace CS_cars
{
  public abstract class ACar : ICar
  {
    public string Make { get; init; }
    public string Model { get; init; }  
    public int Seats { get; init; }
    public int Year { get; init; }
    public string Color { get; init; }
    public ITransmission Transmission { get; init; }

    protected ACar(string make, string model, int seats, ITransmission transmission, int year, string color)
    {
      Make = make;
      Model = model;
      Seats = seats;
      Transmission = transmission;
      Year = year;
      Color = color;
    }

    public virtual string GetDescription()
    {
      return $"{Make}: {Model} model, {Year} year, {Color} color, {Seats} seats, {Transmission.GetTransmissionInfo()}";
    }

    public virtual void Start()
    {
      Console.WriteLine($"{Make} {Model} is starting...");
    }

    public virtual void Stop()
    {
      Console.WriteLine($"{Make} {Model} is stopping...");
    }

    public abstract int GetMaxSpeed();

    public abstract string GetSafetyRating();

    public abstract string GetEngineType();

    public string GetTransmissionInfo()
    {
      return Transmission.GetTransmissionInfo();
    }
  }
}
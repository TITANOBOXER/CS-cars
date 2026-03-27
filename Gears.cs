namespace CS_cars
{
  public class MechanicalGear : IMechanical
  {
    public int Gears { get; init; }

    public MechanicalGear(int gears)
    {
      Gears = gears;
    }

    public string GetTransmissionInfo() => $"{Gears}-speed mechanical transmission";
  }

  public class AutomaticalGear : IAutomatical
  {
    public bool HasSportMode { get; init; }

    public AutomaticalGear(bool sport)
    {
      HasSportMode = sport;
    }

    public string GetTransmissionInfo() => HasSportMode ? "automatic transmission with sport mode" : "automatic transmission";
  }
}
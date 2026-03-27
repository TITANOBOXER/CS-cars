namespace CS_cars
{
  public interface ICar
  {
    string GetDescription();
  }

  public interface IElectric
  {
    int BatteryKilowattHours { get; }
  }

  public interface IGas
  {
    string EngineType { get; }
    int Horsepower { get; }
  }

  public interface ITransmission
  {
    string GetTransmissionInfo();
  }

  public interface IMechanical : ITransmission
  {
    int Gears { get; }
  }

  public interface IAutomatical : ITransmission
  {
    bool HasSportMode { get; }
  }
}
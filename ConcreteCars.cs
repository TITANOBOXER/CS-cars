namespace CS_cars
{
  public class Lamborghini : GasCar
  {
    public Lamborghini()
      : base("Lamborghini", "Huracan", 2, new MechanicalGear(6), 2024, "yellow", "5.2L V10", 630)
    {
    }
  }

  public class Porsche : GasCar
  {
    public Porsche()
      : base("Porsche", "911", 2, new MechanicalGear(7), 2024, "red", "3.0L twin-turbo flat-6", 443)
    {
    }
  }

  public class Ferrari : GasCar
  {
    public Ferrari()
      : base("Ferrari", "F8", 2, new MechanicalGear(7), 2024, "rosso", "3.9L V8", 710)
    {
    }
  }

  public class Bugatti : GasCar
  {
    public Bugatti()
      : base("Bugatti", "Chiron", 2, new MechanicalGear(7), 2024, "blue", "8.0L W16", 1479)
    {
    }
  }

  public class Maibach : GasCar
  {
    public Maibach()
      : base("Maibach", "S-Class", 5, new AutomaticalGear(true), 2024, "black", "6.0L V12", 621)
    {
    }
  }

  public class Lixiang : ElectricCar
  {
    public Lixiang()
      : base("Lixiang", "L7", 5, new AutomaticalGear(true), 2024, "white", 100)
    {
    }
  }

  public class Zeekr : ElectricCar
  {
    public Zeekr()
      : base("Zeekr", "001", 5, new AutomaticalGear(false), 2024, "silver", 86)
    {
    }
  }

  public class Tesla : ElectricCar
  {
    public Tesla()
      : base("Tesla", "Model S", 5, new AutomaticalGear(true), 2024, "white", 100)
    {
    }
  }

  public class BMW : GasCar
  {
    public BMW()
      : base("BMW", "X5", 5, new AutomaticalGear(true), 2024, "blue", "3.0L inline-6", 380)
    {
    }
  }

  public class Mercedes : GasCar
  {
    public Mercedes()
      : base("Mercedes", "S-Class", 5, new AutomaticalGear(true), 2024, "black", "3.0L inline-6", 429)
    {
    }
  }

  public class Toyota : GasCar
  {
    public Toyota()
      : base("Toyota", "Camry", 5, new MechanicalGear(6), 2024, "white", "2.5L I4", 203)
    {
    }
  }

  public class LadaGranta : GasCar
  {
    public LadaGranta()
      : base("Lada", "Granta", 5, new MechanicalGear(5), 2024, "red", "1.6L V4", 106)
    {
    }
  }
}

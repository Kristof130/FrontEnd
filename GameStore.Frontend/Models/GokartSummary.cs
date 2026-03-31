namespace GameStore.Frontend.Models;

public class GokartSummary
{
public int Id { get; set; }
public required string Gyarto { get; set; }
public required string Tipus { get; set; }
public  DateOnly Evjarat { get; set; }
public required string VazTipusa { get; set; }
public int Tomeg { get; set; }

public int Hossz { get; set; }

public int Szelesseg { get; set; }

public int Tengelytav { get; set; }

public required string MotorTipusa { get; set; }
public int Teljesitmeny { get; set; }

public required string HajtasModja { get; set; }

public required string ValtoTipusa { get; set; }

public int Foglalt_e { get; set; }

public int NapiAr { get; set; }
}

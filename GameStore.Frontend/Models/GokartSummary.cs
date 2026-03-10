namespace GameStore.Frontend.Models;

public class GokartSummary
{
public int Id { get; set; }
public  string Gyarto { get; set; }
public string Tipus { get; set; }
public  DateOnly Evjarat { get; set; }
public string VazTipusa { get; set; }
public int Tomeg { get; set; }

public int Hossz { get; set; }

public int Szelesseg { get; set; }

public int Tengelytav { get; set; }

public string MotorTipusa { get; set; }

public string HajtasModja { get; set; }

public string ValtoTipusa { get; set; }

public bool Foglalt_e { get; set; }

public int NapiAr { get; set; }
}

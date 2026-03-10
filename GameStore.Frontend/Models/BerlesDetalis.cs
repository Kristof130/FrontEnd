using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class BerlesDetails
{
   public int ID { get; set; }
public  int Gokart_Id { get; set; }
public  int Berlo_Id { get; set; }
public DateOnly KezdoDatum { get; set; }
public int Berles_hossza { get; set; }
}

using System.ComponentModel.DataAnnotations;
namespace Vehiculo20200671.Data.Models;
public class vehiculo

{
  [Key]
  public string? VehiculoID{ get; set; } 
  public string? Marca{ get; set; } 
  public string? Modelo{ get; set; } 
  public string? Año{ get; set; } 
  public string? Color{ get; set; } 
  public static vehiculo Crear(string VehiculoID, string Marca, string Modelo, string Color){
        return new vehiculo(){
            VehiculoID = "",
            Marca= "",
            Modelo = "",
           Año ="",
            Color="",
            };
    }

    public void Update(string VehiculoID, string Marca, string Modelo, string Color)
    {
        VehiculoID = "";
            Marca= "";
            Modelo = "";
           Año ="";
            Color="";
    } 
}

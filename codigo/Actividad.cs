namespace Parcial1.codigo;

/*
Cada actividad tiene un código, un nombre y una cuota base mensual.
*/
public abstract class Actividad
{
  public int Codigo { get; set; }
  public string Nombre { get; set; }
  public decimal CuotaBase { get; set; }

  public Actividad(int codigo, string nombre, decimal cuotaBase)
  {
    Codigo = codigo;
    Nombre = nombre;
    CuotaBase = cuotaBase;
  }

  public abstract decimal AdicionalMensual();
  public virtual decimal CalcularCostoMensual(int sesionesRealizadas)
  {
    return CuotaBase + AdicionalMensual();
  }
}
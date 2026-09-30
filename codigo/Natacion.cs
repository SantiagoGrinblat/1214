namespace Parcial1.codigo;

public class Natacion : Actividad, ITurno
{
  public int SessionesIncluidas { get; set; }
  public int CupoMaximo { get; set; }
  public string DescripcionHorarioDisponible;

  public Natacion(int codigo, string nombre, decimal cuotaBase, int sessionesIncluidas, int cupoMaximo, string descripcionHorarioDisponible) : base(codigo, nombre, cuotaBase)
  {
    SessionesIncluidas = sessionesIncluidas;
    CupoMaximo = cupoMaximo;
    DescripcionHorarioDisponible = descripcionHorarioDisponible;
  }

  public override decimal AdicionalMensual() => 6000m;

  public string ObtenerDescripcionHorario() => DescripcionHorarioDisponible;

  public override decimal CalcularCostoMensual(int sesionesRealizadas)
  {
    decimal costo = base.CalcularCostoMensual(sesionesRealizadas);
    if (sesionesRealizadas > SessionesIncluidas) {
      int excedentes = sesionesRealizadas - SessionesIncluidas;
      costo += excedentes * 1500m;
    }

    return costo;
  }
}
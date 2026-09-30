// ClaseGrupal.cs
namespace Parcial1.codigo;

public class ClaseGrupal : Actividad, ITurno {
  public int CupoMaximo { get; set; }
  private string DescripcionHorario;

  public ClaseGrupal(int codigo, string nombre, decimal cuotaBase, int cupoMaximo, string descripcionHorario) : base(codigo, nombre, cuotaBase) {
    CupoMaximo = cupoMaximo;
    DescripcionHorario = descripcionHorario;
  }

  public override decimal AdicionalMensual() => 2000m;

  public string ObtenerDescripcionHorario() => DescripcionHorario;
}
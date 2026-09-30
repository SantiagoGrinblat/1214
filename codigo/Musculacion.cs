namespace Parcial1.codigo;

public class Musculancion : Actividad {
  public Musculancion(int codigo, string nombre, decimal cuotaBase) :base(codigo, nombre, cuotaBase) {
    
  }
  public override decimal AdicionalMensual() => 3000;

  public virtual decimal CalcularCostoMensual(int sessionesRealizadas) {
    return CuotaBase + AdicionalMensual();
  }
}
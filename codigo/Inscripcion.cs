// Inscripcion.cs
namespace Parcial1.codigo;

public class Inscripcion {
  public Socio Socio { get; }
  public Actividad Actividad { get; }
  public int SesionesRealizadas { get; }

  public Inscripcion(Socio socio, Actividad actividad, int sesionesRealizadas) {
    Socio = socio;
    Actividad = actividad;
    SesionesRealizadas = sesionesRealizadas;
  }
  public decimal CalcularCosto() {
    return Actividad.CalcularCostoMensual(SesionesRealizadas);
  }
}
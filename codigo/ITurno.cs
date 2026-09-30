namespace Parcial1.codigo;
/*
Las actividades con turno deben cumplir un contrato que permita conocer el cupo máximo por turno y una descripción del horario disponible.
*/
public interface ITurno {
  int CupoMaximo {get;}
  string ObtenerDescripcionHorario();
}
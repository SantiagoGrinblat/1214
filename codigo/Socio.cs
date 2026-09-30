namespace Parcial1.codigo;

//Un socio se inscribe a una actividad y, al cierre del mes, se registra en esa inscripción cuántas sesiones realizó efectivamente.
public class Socio {
  public string Documento {get;}
  public string Nombre  {get; set;}

  public Socio(string document, string nombre) {
    Documento = document;
    Nombre = nombre;
  }
}
using Parcial1.codigo;


class Program
{
  static void Main(string[] args) {

    var socio1 = new Socio("211185", "silva santiago");

    var musculacion = new Musculancion(01, "muscculo", 8000m);
    var natacion = new Natacion(02, "nado", 10000m, sessionesIncluidas: 8, cupoMaximo: 6, "Lunes a miercoles 19 a 20hs");
    var claseGrupal = new ClaseGrupal(02, "Funcional", 7000m, cupoMaximo: 12, "Martes 19hs");
    var inscMusculacion = new Inscripcion(socio1, musculacion, 0);
    var inscNatacionOk = new Inscripcion(socio1, natacion, 5);
    var inscNatacionExcedida = new Inscripcion(socio1, natacion, 12);
    var inscClaseGrupal = new Inscripcion(socio1, claseGrupal, 0);

    Console.WriteLine($"musculo ${inscMusculacion.CalcularCosto()}");
    Console.WriteLine($" natacion ${inscNatacionOk.CalcularCosto()}");
    Console.WriteLine($"naracion excedente ${inscNatacionExcedida.CalcularCosto()}");
    Console.WriteLine($"Clase grupal${inscClaseGrupal.CalcularCosto()}");
    
    Actividad[] actividades = { musculacion, natacion, claseGrupal };
    foreach (Actividad a in actividades) {
      Console.WriteLine($"{a.Nombre} ({a.GetType().Name}) - Adicional: ${a.AdicionalMensual()}");
    }

    try {
      throw new DocumentoDuplicadoException("43574988");
    }
    catch (DocumentoDuplicadoException ex) {
      Console.WriteLine($"bein: {ex.Message}");
    }

    try {
      int cantidadPersonas = 10;
      if (cantidadPersonas > natacion.CupoMaximo) {
        throw new CupoExcedidoException(natacion.CupoMaximo, cantidadPersonas);
      }
    }
    catch (CupoExcedidoException ex) {
      Console.WriteLine($"se rompio: {ex.Message}");
    }

  }
}
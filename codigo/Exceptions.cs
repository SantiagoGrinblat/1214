namespace Parcial1.codigo;


public class DocumentoDuplicadoException : Exception
{
  public DocumentoDuplicadoException(string documento) : base($"Ya existe un socio registrado con el documento '{documento}'.") { }
}

public class CupoExcedidoException : Exception
{
  public CupoExcedidoException(double cupoMaximo, int cantidadSolicitada) : base($"El turno tiene un cupo máximo de {cupoMaximo} personas y se intentó reservar para {cantidadSolicitada}.") { }
}
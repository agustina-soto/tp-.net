namespace Aseguradora.Aplicacion;

class Poliza
{
    public int Id { get; private set; } 
    public double ValorAsegurado { get; set; }
    public double Franquicia { get; set; }
    public string TipoCobertura { get; set; }
    public DateTime InicioVigencia { get; set; }
    public DateTime FinVigencia { get; set; }
    public int VehiculoId { get; private set; }

    public Poliza(double valorAsegurado, double franquicia, string tipoCobertura, DateTime inicioVigencia, DateTime finVigencia, int idVehiculo){
        ValorAsegurado = valorAsegurado;
        Franquicia = franquicia;
        TipoCobertura = tipoCobertura;
        InicioVigencia = inicioVigencia;
        FinVigencia = finVigencia;
        VehiculoId = idVehiculo;
    }

    public void actualizarId (int id) => Id = id;

    public override string ToString () => Id + " " + ValorAsegurado + " " + Franquicia + " " + TipoCobertura + " " + InicioVigencia + " " + FinVigencia + " " + VehiculoId;

}

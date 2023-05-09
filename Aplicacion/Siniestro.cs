namespace Aseguradora.Aplicacion;

class Siniestro {

    public int Id { get; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaOcurrencia { get; set; }
    public string Direccion { get; set; }
    public string Descripcion { get; set; }
    public int PolizaId { get; set; }

    public Siniestro(DateTime fechaIngreso, DateTime fechaOcurrencia, string direccion, string descripcion, int idPoliza){
        FechaIngreso = fechaIngreso;
        FechaOcurrencia = fechaOcurrencia;
        Direccion = direccion;
        Descripcion = descripcion;
        PolizaId = idPoliza;
    }    
}

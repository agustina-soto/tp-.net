namespace Aseguradora.Aplicacion;

class Vehiculo 
{
    public int Id { get; private set;}
    public string Dominio { get; set; }
    public string Marca { get; set; }
    public DateTime FechaFabricacion { get; set; }
    public int TitularId { get; set; }

    public Vehiculo(string dominio, string marca, DateTime fechaFabricacion, int titularId){
        Dominio = dominio;
        Marca = marca;
        FechaFabricacion = fechaFabricacion;
        TitularId = titularId;
    }

    public void actualizarId (int id) => Id = id;


    public override string ToString () => Id + " " + Dominio + " " + Marca + " " + FechaFabricacion + " " + TitularId;

}

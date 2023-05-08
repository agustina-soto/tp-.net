namespace Entrega.Aplicacion;

interface IRepositorioVehiculo
{
    public void agregarVehiculo(Vehiculo v);
    public void eliminarVehiculo(int id);
    public void modificarVehiculo(Vehiculo v);
    public List<Vehiculo> listarVehiculos();
}

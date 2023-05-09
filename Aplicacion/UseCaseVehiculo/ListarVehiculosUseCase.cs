namespace Aseguradora.Aplicacion;

class ListarVehiculosUseCase
{
    private readonly IRepositorioVehiculo _repoVehiculo;

    public ListarVehiculosUseCase (IRepositorioVehiculo repoV)
    {
        _repoVehiculo = repoV;
    }

    public List<Vehiculo> Ejecutar ()
    {
        return _repoVehiculo.listarVehiculos();
    } 
}

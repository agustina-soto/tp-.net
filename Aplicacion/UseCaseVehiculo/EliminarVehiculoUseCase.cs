namespace Aseguradora.Aplicacion;

class EliminarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repoVehiculo;

    public EliminarVehiculoUseCase (IRepositorioVehiculo repoV)
    {
        _repoVehiculo = repoV;
    }

    public void Ejecutar (int id)
    {
        _repoVehiculo.eliminarVehiculo(id);
    } 
}

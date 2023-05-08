namespace Entrega.Aplicacion;

class ModificarVehiculoUseCase
{
    private readonly IRepositorioTitular _repoTitular;
    private readonly IRepositorioVehiculo _repoVehiculo;

    public ModificarVehiculoUseCase (IRepositorioVehiculo repoV, IRepositorioTitular repoT)
    {
        _repoTitular = repoT;
        _repoVehiculo = repoV;
    }

    public void Ejecutar (Vehiculo v)
    {
        _repoVehiculo.modificarVehiculo(v);
        //puede modificar el titular, como?
    } 
}

namespace Entrega.Aplicacion;

class AgregarVehiculoUseCase
{
    private readonly IRepositorioTitular _repoTitular;
    private readonly IRepositorioVehiculo _repoVehiculo;

    public AgregarVehiculoUseCase (IRepositorioVehiculo repoV, IRepositorioTitular repoT)
    {
        _repoTitular = repoT;
        _repoVehiculo = repoV;
    }

    public void Ejecutar (Vehiculo v)
    {
        _repoVehiculo.agregarVehiculo(v);
        //tambien se debe moficar la lista de vehiculos en titular
    } 
}

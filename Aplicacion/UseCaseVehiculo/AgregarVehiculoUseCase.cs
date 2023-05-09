namespace Aseguradora.Aplicacion;

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
        try
        {
            int pos = _repoTitular.listarTitulares().FindIndex(x => x.Id == v.TitularId);
            if (pos >= 0)
            {
                _repoVehiculo.agregarVehiculo(v);
            }
            else
            {
                throw new Exception("No existe el titular con Id = " + v.TitularId);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    } 
}

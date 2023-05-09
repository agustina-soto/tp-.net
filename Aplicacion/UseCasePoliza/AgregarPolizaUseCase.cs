namespace Entrega.Aplicacion;

class AgregarPolizaUseCase
{
    private readonly IRepositorioPoliza _repoPoliza;
    private readonly IRepositorioVehiculo _repoVehiculo;

    public AgregarPolizaUseCase (IRepositorioPoliza repoP, IRepositorioVehiculo repoV)
    {
        _repoPoliza = repoP;
        _repoVehiculo = repoV;
    }

    public void Ejecutar (Poliza p)
    {
        try
        {
            int pos = _repoVehiculo.listarVehiculos().FindIndex(x => x.Id == p.VehiculoId);
            if (pos >= 0)
            {
                _repoPoliza.agregarPoliza(p);
            }
            else
            {
                throw new Exception("No existe el vehiculo con Id = " + p.VehiculoId);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    } 
}

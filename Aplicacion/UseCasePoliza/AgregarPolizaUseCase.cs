namespace Entrega.Aplicacion;

class AgregarPolizaUseCase
{
    private readonly IRepositorioPoliza _repoPoliza;

    public AgregarPolizaUseCase (IRepositorioPoliza repoP)
    {
        _repoPoliza = repoP;
    }

    public void Ejecutar (Poliza p)
    {
        _repoPoliza.agregarPoliza(p);
        
    } 
}

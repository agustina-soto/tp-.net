namespace Aseguradora.Aplicacion;

class ModificarPolizaUseCase
{
    private readonly IRepositorioPoliza _repoPoliza;

    public ModificarPolizaUseCase (IRepositorioPoliza repoP)
    {
        _repoPoliza = repoP;
    }

    public void Ejecutar (Poliza p)
    {
        _repoPoliza.modificarPoliza(p);
    } 
}

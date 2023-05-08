namespace Entrega.Aplicacion;

class ListarPolizasUseCase
{
    private readonly IRepositorioPoliza _repoPoliza;

    public ListarPolizasUseCase (IRepositorioPoliza repoR)
    {
        _repoPoliza = repoR;
    }

    public List<Poliza> Ejecutar ()
    {
        return _repoPoliza.listarPolizas();
    } 
}

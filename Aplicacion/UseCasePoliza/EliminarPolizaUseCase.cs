namespace Entrega.Aplicacion;

class EliminarPolizaUseCase
{
    private readonly IRepositorioPoliza _repoPoliza;

    public EliminarPolizaUseCase (IRepositorioPoliza repoP)
    {
        _repoPoliza = repoP;
    }

    public void Ejecutar (int id)
    {
        _repoPoliza.eliminarPoliza(id);
    } 
}

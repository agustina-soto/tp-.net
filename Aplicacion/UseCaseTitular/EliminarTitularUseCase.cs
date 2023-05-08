namespace Entrega.Aplicacion;

class EliminarTitularUseCase
{
    private readonly IRepositorioTitular _repoTitular;

    public EliminarTitularUseCase (IRepositorioTitular repoT)
    {
        _repoTitular = repoT;
    }

    public void Ejecutar (int id)
    {
        _repoTitular.eliminarTitular(id);
    } 
}

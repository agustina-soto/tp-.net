namespace Entrega.Aplicacion;

class ListarTitularesUseCase
{
    private readonly IRepositorioTitular _repoTitular;

    public ListarTitularesUseCase (IRepositorioTitular repoT)
    {
        _repoTitular = repoT;
    }

    public List<Titular> Ejecutar ()
    {
        return _repoTitular.listarTitulares();
    } 
}

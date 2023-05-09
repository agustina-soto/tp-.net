namespace Aseguradora.Aplicacion;

class ModificarTitularUseCase
{
    private readonly IRepositorioTitular _repoTitular;

    public ModificarTitularUseCase (IRepositorioTitular repoT)
    {
        _repoTitular = repoT;
    }

    public void Ejecutar (Titular t)
    {
        _repoTitular.modificarTitular(t);
    } 
}

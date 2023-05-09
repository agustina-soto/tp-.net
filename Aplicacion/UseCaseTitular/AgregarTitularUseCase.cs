namespace Aseguradora.Aplicacion;

class AgregarTitularUseCase
{
    private readonly IRepositorioTitular _repoTitular;
    
    public AgregarTitularUseCase (IRepositorioTitular repoT)
    {
        _repoTitular = repoT;
    }

    public void Ejecutar (Titular t)
    {
        _repoTitular.agregarTitular(t);
        
    } 
}

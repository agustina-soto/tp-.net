namespace aseguradora;

class AgregarPolizaUseCase 
{
    private readonly IRepositorioPoliza _repo; //es readonly xq es inmutable???

    public AgregarPolizaUseCase (IRepositorioPoliza repo)
    {
        _repo = repo; //inyeccion por constructor
    }
    
    // Aca no tiene que ir el metodo "void Ejecutar(Poliza p){}" ???
    // Segun la consigna en la carilla 2
}

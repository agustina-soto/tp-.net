namespace Aseguradora.Aplicacion;

interface IRepositorioTitular
{
    public void agregarTitular(Titular t);
    public void eliminarTitular(int id);
    public void modificarTitular(Titular t);
    public List<Titular> listarTitulares();
    public void listarTitularesConSusVehiculos(); //chequear como implementarlo
}

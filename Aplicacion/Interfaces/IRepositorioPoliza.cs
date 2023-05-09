namespace Aseguradora.Aplicacion;

interface IRepositorioPoliza
{
    public void agregarPoliza(Poliza p); 
    public void eliminarPoliza(int Id);
    public void modificarPoliza(Poliza p);
    public List<Poliza> listarPolizas();
}

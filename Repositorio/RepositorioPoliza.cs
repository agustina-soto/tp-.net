namespace Entrega.Aplicacion; //va en entrega.repositorios


class RepositorioPoliza : IRepositorioPoliza
{
    private static int s_id = 0;
    private List<Poliza> listaPolizas = new List<Poliza>();
    private StreamWriter archivo_polizas;

    public RepositorioPoliza ()
    {
        archivo_polizas = File.CreateText("C:\\archivo_repositorio_polizas.txt");
        archivo_polizas.Close();
    }
    
    public void actualizarArchivo ()
    {
        using (StreamWriter sw = new StreamWriter ("C:\\archivo_repositorio_polizas.txt", true))
        {
            foreach (Poliza p in listaPolizas)
            {
                sw.WriteLine(p.ToString());
            }
        }
    }

    public void agregarPoliza(Poliza p)
    {
        try
        {
            int pos = listaPolizas.FindIndex(x => x.Id == p.Id);
            if (pos == -1)
            {
                p.actualizarId(++s_id);
                listaPolizas.Add(p);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("Ya existe una poliza con Id = " + p.Id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    } 

    public void eliminarPoliza(int id)
    {
        try
        {
            int pos = listaPolizas.FindIndex(x => x.Id == id); 
            if (pos >= 0) 
            {
                listaPolizas.RemoveAt(pos);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("No existe la poliza con Id = " + id); 
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void modificarPoliza(Poliza p)
    {
        try
        {
            int pos = listaPolizas.FindIndex(x => x.Id == p.Id);
            if (pos >= 0) 
            {
                listaPolizas.Insert(pos, p);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("No existe la poliza con Id = " + p.Id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public List<Poliza> listarPolizas() => listaPolizas;
}

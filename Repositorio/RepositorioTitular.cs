namespace Entrega.Aplicacion; //no va aca sino en entrega.repositorio

class RepositorioTitular : IRepositorioTitular
{
    private static int s_id = 0;
    private List<Titular> listaTitulares = new List<Titular>();
    private StreamWriter archivo_titulares;

    public RepositorioTitular ()
    {
        archivo_titulares = File.CreateText("C:\\archivo_repositorio_titulares.txt");
        archivo_titulares.Close();
    }

    public void actualizarArchivo ()
    {
        using (StreamWriter sw = new StreamWriter ("C:\\archivo_repositorio_titulares.txt", true))
        {
            foreach (Titular t in listaTitulares)
            {
                sw.WriteLine(t.Id + " " + t.ToString());
            }
        }
    }

    public void agregarTitular(Titular t)
    {
        try
        {
            int pos = listaTitulares.FindIndex(x => x.DNI == t.DNI);
            if (pos == -1) //si no lo encontre lo agrego al archivo
            {
                t.actualizarId(++s_id);
                listaTitulares.Add(t);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("Ya existe un titular con DNI = " + t.DNI);
            }
        }
        catch
        {
            throw; //relanza la excepcion, los objetos que llamen a "agregarTitular" deben manejar la excepcion
        }
    } 

    public void eliminarTitular(int id)
    {
        try
        {
            int pos = listaTitulares.FindIndex(x => x.Id == id); //devuelve -1 si no lo encuntra 
            if (pos >= 0) //encontre el titular
            {
                listaTitulares.RemoveAt(pos);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("No existe un titular con Id = " + id); 
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void modificarTitular(Titular t)
    {
        try
        {
            int pos = listaTitulares.FindIndex(x => x.DNI == t.DNI);
            if (pos >= 0) 
            {
                listaTitulares.Insert(pos, t);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("No existe un titular con DNI = " + t.DNI);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public List<Titular> listarTitulares() => listaTitulares;

    public void listarTitularesConSusVehiculos()
    {

    }
}
}

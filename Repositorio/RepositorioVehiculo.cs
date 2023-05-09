namespace Entrega.Aplicacion; //va en entrega.repositorios


class RepositorioVehiculo : IRepositorioVehiculo
{
    private static int s_id = 0;
    private List<Vehiculo> listaVehiculos = new List<Vehiculo>();
    private StreamWriter archivo_vehiculos;

    public RepositorioVehiculo ()
    {
        archivo_vehiculos = File.CreateText("C:\\archivo_repositorio_vehiculos.txt");
        archivo_vehiculos.Close();
    }
    
    public void actualizarArchivo ()
    {
        using (StreamWriter sw = new StreamWriter ("C:\\archivo_repositorio_vehiculos.txt", true))
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                sw.WriteLine(v.ToString());
            }
        }
    }

    public void agregarVehiculo(Vehiculo v)
    {
        try
        {
            int pos = listaVehiculos.FindIndex(x => x.Id == v.Id);
            if (pos == -1)
            {
                v.actualizarId(++s_id);
                listaVehiculos.Add(v);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("Ya existe un vehiculo con Id = " + v.Id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    } 

    public void eliminarVehiculo(int id)
    {
        try
        {
            int pos = listaVehiculos.FindIndex(x => x.Id == id); 
            if (pos >= 0) 
            {
                listaVehiculos.RemoveAt(pos);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("No existe el vehiculo con Id = " + id); 
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void modificarVehiculo(Vehiculo v)
    {
        try
        {
            int pos = listaVehiculos.FindIndex(x => x.Id == v.Id);
            if (pos >= 0) 
            {
                listaVehiculos.Insert(pos, v);
                actualizarArchivo();
            }
            else
            {
                throw new Exception("No existe el vehiculo con Id = " + v.Id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public List<Vehiculo> listarVehiculos() => listaVehiculos;
}

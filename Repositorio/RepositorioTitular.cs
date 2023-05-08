namespace Entrega.Aplicacion; //no va aca sino en entrega.repositorio

class RepositorioTitular : IRepositorioTitular
{
    private static int s_id = 0;

    //abre el archivo y devuelve true si se encuntre, caso contrario devuelve false
    public bool existe (Titular t)
    {
        StreamReader sr = new StreamReader ("C:\\Users\\Maite\\Desktop\\archivoDeTexto.txt"); //abre el archivo que se encuntra en la rura indicada
        int result;
        bool found = false;

        while (! sr.EndOfStream) //mientras no sea el final del archivo sigo procesando
        { 
            string[] word = sr.ReadLine().Split(' ');

            int.TryParse(word[1], out result); //en la pos 1 esta el dni, chequea que no haya incopatibilidad de tipos
            if (t.DNI == result) //si encuentro el titular
            {
                found = true; // y devuelvo true
            }
        }

        sr.Close();
        return found; //si llego a este punto es xq se proceso todo el archivo y no lo encontro y devuelve false 
    }

    public void agregarTitular(Titular t)
    {
        try
        {
            if (! existe(t)) //si no lo encontre lo agrego al archivo
            {
                StreamWriter sw = new StreamWriter ("C:\\Users\\Maite\\Desktop\\archivoDeTexto.txt", true); //uso el stream writer para abrir, escribir y cerrar archivos
                t.Id = ++s_id; //deberia de cambiar el alcance de id
                sw.WriteLine(t.Id + " " + t.ToString()); //agrego la info en el archivo
                sw.Close();
            }
            else
            {
                throw new Exception("Ya existe un titular con DNI = " + t.DNI);
            }
        }
        catch
        {
            throw; //relanza la excepcion, los objtos que llamen a "agregarTitular" deben manejar la excepcion
        }
    }

    public void eliminarTitular(int id)
    {

    }
    public void modificarTitular(Titular t)
    {

    }
    public List<Titular> listarTitulares()
    {
        List<Titular> list = new List<Titular>();
        return list;
    }

    public void listarTitularesConSusVehiculos()
    {
        
    }
}

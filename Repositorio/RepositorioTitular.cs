namespace Entrega.Aplicacion; //no va aca sino en entrega.repositorio

class RepositorioTitular : IRepositorioTitular
{
    //abre el archivo y devuelve true si se encuntre, caso contrario devuelve false
    public bool existe (Titular t)
    {
        StreamReader sr = new StreamReader ("C:\\Users\\Maite\\Desktop\\archivoDeTexto.txt"); //abre el archivo que se encuntra en la rura indicada
        //int result; 

        while (! sr.EndOfStream) //mientras no sea el final del archivo sigo procesando
        { 
            string[] word = sr.ReadLine().Split(' ');

            //int.TryParse(word[0], out result);
            if (t.Id == Int32.Parse(word[0])) //si encuentro el titular
            {
                sr.Close(); //cierro el archivo
                return true; // y devulvo true
            }
        }

        sr.Close();
        return false; //si llego a este punto es xq se proceso todo el archivo y no lo encontro y devuelve false 
    }

    public void agregarTitular(Titular t)
    {
        if (! existe(t)) //si no lo encontre lo agrego al archivo
        {
            StreamWriter sw = new StreamWriter ("C:\\Users\\Maite\\Desktop\\archivoDeTexto.txt", true); //uso el stream writer para abrir, escribir y cerrar archivos
            //t.Id = t.Id++; //deberia de cambiar el alcance de id
            sw.WriteLine(t.Id + " " + t.ToString()); //agrego la info en el archivo
            sw.Close();
        }
        else { Console.WriteLine("El titular a agregar ya existe en el sistema"); }
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

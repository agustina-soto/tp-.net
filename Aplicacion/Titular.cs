namespace aplicacion;

class Titular : Persona {

    private static int s_id = 0;
    public string? Direccion { get; set; }
    public string? Correo { get; set; }

    /*
    public Titular(string dni, string apellido, string nombre, string telefono, string direccion, string correo) : base(dni, apellido, nombre, telefono){
        Id = ++s_id;
        Direccion = direccion;
        Correo = correo;
    }
    */
    
    public Titular (int dni, string apellido, string nombre) : base(dni, apellido, nombre){ /* Siempre se instancia con este en console --> deberiamos dejar el otro
                                                                                                tambien? para mi conceptualmente es mejor, pero evidentemente no les
                                                                                                importa mucho ese tema asiq no se que preferis hacer vos */
        Id = ++s_id;
    }

    public override string ToString() => base.ToString() + " " + this.Direccion + " " + base.Telefono + " " + this.Correo;
    
    /*
    //puse los "?" para que no me tire warning --> que tiene que nos tire el warning? si le ponemos a estos el ? se lo tenemos que poner a todos
    private static int s_id = 0;
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public List<Vehiculo>? Vehiculos { get; private set; } //esta bien el modificador de acceso??? --> calculo que si, depende de como implementemos las interfaces q comunican un vehiculo y un titular

    public Titular (int dni, string apellido, string nombre) : base(dni, apellido, nombre){ //siempre se instancia con este en console
        Id = ++s_id;
    }

    //imprime de dos maneras :( --> claro... como lo hice arriba y en la clase Persona (cuando imprima con mas info usa el toString de Titular, cuando imprima con menos info usa el toString de Persona)
    public override string ToString() => DNI + " " + Apellido + ", " + Nombre + " " + Direccion + " " + Telefono + " " + Email;

    public override string ToString() => DNI + " " + Apellido + ", " + Nombre; //solucionar
    */
}

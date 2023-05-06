namespace aplicacion;

class Titular : Persona {

    private static int s_id = 0;
    public string Direccion { get; set; }
    public string Email { get; set; }
    public List<Vehiculo>? Vehiculos { get; private set; } //esta bien el modificador de acceso??? --> calculo que si, depende de como implementemos las interfaces q comunican un vehiculo y un titular

    public Titular(int dni, string apellido, string nombre, string telefono, string direccion, string email) : base(dni, apellido, nombre, telefono){
        Id = ++s_id;
        Direccion = direccion;
        Email = email;
    }
    
    public Titular (int dni, string? apellido, string? nombre) : base(dni, apellido, nombre){
        Id = ++s_id;
    }

    public override string ToString() => base.ToString() + " " + this.Direccion + " " + base.Telefono + " " + this.Email;

}
    
    /*
    //puse los "?" para que no me tire warning --> que tiene que nos tire el warning? si le ponemos a estos el ? se lo tenemos que poner a todos
    private static int s_id = 0;
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public List<Vehiculo>? Vehiculos { get; private set; } //esta bien el modificador de acceso??? --> calculo que si, depende de como implementemos las interfaces q comunican un vehiculo y un titular

    // Siempre se instancia con este en console --> deberiamos dejar el otro tambien? para mi conceptualmente
    // es mejor, pero evidentemente no les importa mucho ese tema asiq no se que preferis hacer vos
    //yo les dejaria los dos, es como decis vos conceptualmente es mejor y podemos ir con el chamuyo que es mejor para el matenimiento del proyecto 
    public Titular (int dni, string apellido, string nombre) : base(dni, apellido, nombre){
        Id = ++s_id;
    }
    
    public Titular (int dni, string apellido, string nombre, string telefono, string direccion, string correo) : base(dni, apellido, nombre, telefono){
        Id = ++s_id;
        Direccion = direccion;
        Email = correo;
    }

    //imprime de dos maneras :( --> claro... como lo hice arriba y en la clase Persona (cuando imprima con mas info usa el toString de Titular, cuando imprima con menos info usa el toString de Persona)
    public override string ToString() => DNI + " " + Apellido + ", " + Nombre + " " + Direccion + " " + Telefono + " " + Email;

    public override string ToString() => DNI + " " + Apellido + ", " + Nombre; //solucionar
    */

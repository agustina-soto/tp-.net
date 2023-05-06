namespace aplicacion;

class Titular : Persona {

    private static int s_id = 0;
    public string Direccion { get; set; }
    public string Correo { get; set; }

    public Titular(string dni, string apellido, string nombre, string telefono, string direccion, string correo) : base(dni, apellido, nombre, telefono){
        Id = ++s_id;
        Direccion = direccion;
        Correo = correo;
    }

    public override string ToString() => base.ToString() + " " + this.Direccion + " " + base.Telefono + " " + this.Correo;
    
    /*
    //puse los "?" para que no me tire warning
    private static int s_id = 0;
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public List<Vehiculo>? Vehiculos { get; private set; } //esta bien el modificar de acceso???

    public Titular (int dni, string apellido, string nombre) : base(dni, apellido, nombre){ //siempre se instancia con este en console
        Id = ++s_id;
    }

    //imprime de dos maneras :(
    public override string ToString() => DNI + " " + Apellido + ", " + Nombre + " " + Direccion + " " + Telefono + " " + Email;

    public override string ToString() => DNI + " " + Apellido + ", " + Nombre; //solucionar
    */
}

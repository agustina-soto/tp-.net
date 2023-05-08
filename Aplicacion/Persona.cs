namespace aplicacion;

abstract class Persona {

    public int Id { get; protected set; }
    public int DNI { get; set; }
    public string? Apellido { get; set; }
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }

    protected Persona(int dni, string apellido, string nombre, string telefono){
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        Telefono = telefono;
    }

    protected Persona(int dni, string apellido, string nombre){
        Id = -1;
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
    }

    public override string ToString() => this.DNI + " " + this.Apellido + ", " + this.Nombre;
}

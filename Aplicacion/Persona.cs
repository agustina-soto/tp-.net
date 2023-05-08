namespace aplicacion;

abstract class Persona {

    public int Id { get; protected set; } 
    public int DNI { get; set; } 
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string? Telefono { get; set; }

    protected Persona (int dni, string apellido, string nombre)
    {
        Id = -1;
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
    }

    protected Persona(int dni, string apellido, string nombre, string telefono): this (dni, apellido, nombre)
    {  
        Telefono = telefono;
    }

    public void actualizarId (int id) => Id = id;


    public override string ToString() => this.DNI + " " + this.Apellido + ", " + this.Nombre; 

}

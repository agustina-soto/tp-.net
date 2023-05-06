namespace aplicacion;

abstract class Persona {

    public int Id { get; protected set; }
    public int DNI { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string? Telefono { get; set; }

    protected Persona(int dni, string apellido, string nombre, string telefono){
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        Telefono = telefono;
    }

    protected Persona(int dni, string apellido, string nombre){
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
    }

    public override string ToString() => this.DNI + " " + this.Apellido + ", " + this.Nombre;

}

    
    /*public int Id { get; protected set; } //en console se accede a esta propiedad --> por qué el set es publico???????????? xq me confundi yo :(
    public int DNI { get; set; } //en el trabajo lo declaran como entero
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string? Telefono { get; set; }


    protected Persona (int dni, string apellido, string nombre)
    {
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
    }
    
     protected Persona(int dni, string apellido, string nombre, string telefono): this (dni, apellido, nombre) //agrege el otro constructor 
    {  
        Telefono = telefono;
    }
    
    */
    
    
}

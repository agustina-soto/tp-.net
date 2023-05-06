namespace aplicacion;

class Titular : Persona {

    //chequear si agregar "?" a los tipo referencia, xq tira warning?? justificar en el tp explicativo en caso de ponerlos
    private static int s_id = 0;
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public List<Vehiculo>? Vehiculos { get; private set; } //esta bien el modificador de acceso??? --> calculo que si, depende de como implementemos las interfaces q comunican un vehiculo y un titular

    public Titular(int dni, string apellido, string nombre, string telefono, string direccion, string email) : base(dni, apellido, nombre, telefono){
        Id = ++s_id;
        Direccion = direccion;
        Email = email;
    }
    
    // Siempre se instancia usando este constructor en Console, pero dejamos el otro tambien porque conceptualmente nos parece que tiene que estar codificado
    // Despues vemos como lo justificamos bien en el documento sjsjs sacaremos la varita magica llamada <3 chamuyo <3
    public Titular (int dni, string apellido, string nombre) : base(dni, apellido, nombre){
        Id = ++s_id;
    }

    public override string ToString() => base.ToString() + " " + this.Direccion + " " + base.Telefono + " " + this.Email;

}

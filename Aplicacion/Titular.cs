namespace Aseguradora.Aplicacion;

class Titular : Persona
{
    //puse los "?" para que no me tire warning
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public List<Vehiculo>? Vehiculos { get; private set; }

    public Titular (int dni, string apellido, string nombre) : base(dni, apellido, nombre){} //siempre se instancia con este en console

    public override string ToString() => base.ToString() + " " + this.Direccion + " " + base.Telefono + " " + this.Email;

    public Titular (int dni, string apellido, string nombre, string telefono, string direccion, string email) : base(dni, apellido, nombre, telefono){
        Direccion = direccion;
        Email = email;
    }

}

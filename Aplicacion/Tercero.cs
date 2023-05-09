namespace Aseguradora.Aplicacion;

class Tercero : Persona {

    public string? Aseguradora { get; set; }
    public int SiniestroId { get; private set; } // chequear los accesos

    public Tercero(int dni, string apellido, string nombre, string telefono, string aseguradora, int idSiniestro) : base(dni, apellido, nombre, telefono){
        Aseguradora = aseguradora;
        SiniestroId = idSiniestro;
    }

    public Tercero (int dni, string apellido, string nombre) : base(dni, apellido, nombre){}

}

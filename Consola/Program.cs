namespace Consola; // no se como tenemos q hacer con los namespaces, despues lo vemos bien xd
// Se usa para interacturar con las otras partes de la solucion y verificar el correcto funcionamiento de las mismas.

// Creamos los casos de uso inyectando dependencias
    RepositorioTitular repoTitular = new RepositorioTitular();
    AgregarTitularUseCase agregarTitular = new AgregarTitularUseCase(repoTitular);
    ListarTitularesUseCase listarTitulares = new ListarTitularesUseCase(repoTitular);
    ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
    EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular);

// Instanciamos un titular
    Titular titular = new Titular(33123456, "García", "Juan")
    {
        Direccion = "13 nro. 546",
        Telefono = "221-456456",
        Email = "joseGarcia@gmail.com"
    };
    Console.WriteLine($"Id del titular recién instanciado: {titular.Id}");

// Agregamos el titular utilizando un método local
        PersistirTitular(titular);

// El id que corresponde al titular es establecido por el repositorio
    Console.WriteLine($"Id del titular una vez persistido: {titular.Id}");

// Agregamos unos titulares más
    PersistirTitular(new Titular(20654987, "Rodriguez", "Ana"));
    PersistirTitular(new Titular(31456444, "Alconada", "Fermín"));
    PersistirTitular(new Titular(12345654, "Perez", "Cecilia"));

// Listamos los titulares utilizando un método local
    ListarTitulares();

// No debe ser posible agregar un titular con igual DNI que uno existente
    Console.WriteLine("Intentando agregar un titular con DNI 20654987");
    titular = new Titular(20654987, "Alvarez", "Alvaro");

    PersistirTitular(titular); //este titular no pudo persistirse

// Entonces vamos a modificar el titular existente
    Console.WriteLine("Modificando el titular con DNI 20654987");
    modificarTitular.Ejecutar(titular);
    ListarTitulares();

// Eliminando un titular
    Console.WriteLine("Eliminando al titular con id 1");
    eliminarTitular.Ejecutar(1);
    ListarTitulares();

// Métodos locales
    void PersistirTitular(Titular t)
    {
        try
        {
            agregarTitular.Ejecutar(t);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    void ListarTitulares()
    {
        Console.WriteLine("Listando todos los titulares de vehículos");
        List<Titular> lista = listarTitulares.Ejecutar();
        foreach (Titular t in lista)
        {
            Console.WriteLine(t);
        }
    }

/*
Salida por consola:

Id del titular recién instanciado: -1
Id del titular una vez persistido: 1
Listando todos los titulares de vehículos
1: 33123456 García, Juan 13 nro. 546 221-456456 joseGarcia@gmail.com
2: 20654987 Rodriguez, Ana
3: 31456444 Alconada, Fermín
4: 12345654 Perez, Cecilia
Intentando agregar un titular con DNI 20654987
Ya existe un titular con DNI = 20654987
Modificando el titular con DNI 20654987
Listando todos los titulares de vehículos
1: 33123456 García, Juan 13 nro. 546 221-456456 joseGarcia@gmail.com
2: 20654987 Alvarez, Alvaro
3: 31456444 Alconada, Fermín
4: 12345654 Perez, Cecilia

Eliminando al titular con id 1
Listando todos los titulares de vehículos
2: 20654987 Alvarez, Alvaro
3: 31456444 Alconada, Fermín
4: 12345654 Perez, Cecilia
*/

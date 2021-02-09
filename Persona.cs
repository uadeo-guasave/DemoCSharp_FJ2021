class Persona
{
    // atributos
    // ojos, boca, piernas, brazos, etc
    // nombre, apellidos, curp, domicilio, telefono
    string nombre;
    string apellidos;
    string curp;
    string domicilio;
    int edad;

    // métodos
    void imprimirNombreCompleto()
    {
        System.Console.WriteLine(nombre + " " + apellidos);
    }
}
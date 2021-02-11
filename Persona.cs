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

    public static void Main()
    {
      System.Console.WriteLine("Creando un objeto Persona");
      // crear objeto
      Persona alumno1 = new Persona();
      // modificar atributos
      alumno1.nombre = "Jesus";
      alumno1.apellidos = "Avila";
      // llamar métodos
      alumno1.imprimirNombreCompleto();
    }
}

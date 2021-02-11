// Proyectos en C#
// La clase principal en C# se llama Program
class Program
{
  // la clase Program es la que debe contener el método Main
  public static void Main(string[] args)
  {
    // este metodo se va a ejecutar al inicio del programa
    System.Console.WriteLine("Creando una escuela");
    Escuela uadeo = new Escuela();
    uadeo.nombre = "Universidad Autónoma de Occidente";
    uadeo.municipio = "Guasave";
    uadeo.estado = "Sinaloa";
    uadeo.nivel = "Universidad";
    System.Console.WriteLine("Se ha creado la escuela " + uadeo.nombre);
  }
}

// Escuela
class Escuela
{
  string nombre;
  string municipio;
  string estado;
  string nivel; // secundaria, prepa, uni, etc

  void iniciarLabores() {}
  void finalizarLabores() {}
}

// Alumno
class Alumno
{
  string matricula;
  string nombre;
  string apellidos;

  void tomarClase() {}
  void hacerTarea() {}
  void exponer() {}
}

// Docente
class Docente
{
  string rfc;
  string nombre;
  string apellidos;

  void impartirClase() {}
  void prepararClase() {}
}

// Asignatura
class Asignatura
{
  string clave;
  string nombre;
  float horas;

  void imprimirDetalle() {}
}
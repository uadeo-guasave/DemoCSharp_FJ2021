using System;
// Proyectos en C#
// La clase principal en C# se llama Program
class Program
{
  // la clase Program es la que debe contener el método Main
  public static void Main(string[] args)
  {
    // este metodo se va a ejecutar al inicio del programa
    Console.WriteLine("Creando un objeto de escuela");
    Escuela uadeo = new Escuela();
    uadeo.nombre = "Universidad Autónoma de Occidente";
    uadeo.municipio = "Guasave";
    uadeo.estado = "Sinaloa";
    uadeo.nivel = "Universidad";
    Console.WriteLine("Se ha creado la escuela " + uadeo.nombre);

    Console.WriteLine("Creando un objeto de alumno");
    // tipo de dato por inferencia
    var alumno1 = new Alumno();
    alumno1.nombre = "Juan";
    alumno1.apellidos = "Lopez";
    alumno1.matricula = "19030001";
    Console.WriteLine($"El alumno {alumno1.nombre} {alumno1.apellidos} tiene la matricula {alumno1.matricula}");

    Console.WriteLine("Creando un objeto de docente");
    // tipo de dato por inferencia + inicialización inmediata
    var docente1 = new Docente()
    {
      rfc = "abcd010101xyz",
      nombre = "Jesus",
      apellidos = "Lopez"
    };
    Console.WriteLine($"Docente {docente1.nombre} {docente1.apellidos}");
  }
}

// Escuela
class Escuela
{
  public string nombre;
  public string municipio;
  public string estado;
  public string nivel; // secundaria, prepa, uni, etc

  void iniciarLabores() {}
  void finalizarLabores() {}
}

// Alumno
class Alumno
{
  public string matricula;
  public string nombre;
  public string apellidos;

  void tomarClase() {}
  void hacerTarea() {}
  void exponer() {}
}

// Docente
class Docente
{
  public string rfc;
  public string nombre;
  public string apellidos;

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
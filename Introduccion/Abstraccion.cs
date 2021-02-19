class Program
{
  public static void Main(string[] args)
  {
    // TODO: código a ejecutar
    var alumno1 = new Alumno();
    var docente1 = new Docente();
    alumno1.Nombre = "Bidkar";
    docente1.Nombre = "Jose Luis";
    // alumno1.rfc = "sjhfkdsjhfkls";
    // docente1.matricula = "87946384";
    // var persona1 = new Persona(); no se puede instancia una clase acstracta
    var paradigmas = new Calificacion();
    // paradigmas.alumno = alumno1;
    paradigmas.setAlumno(alumno1);
    paradigmas.setDocente(docente1);
    System.Console.WriteLine($"Alumno: {paradigmas.getAlumno().Nombre}");
    paradigmas.Parcial1 = 10;
    System.Console.WriteLine($"Calificacion: {paradigmas.Parcial1}");
    System.Console.WriteLine($"Alumno: {paradigmas.getAlumno().NombreCompleto}");
  }
}

// las clases abstractas solo pueden ser heredadas
// no se pueden crear instancias de estas
abstract class Persona
{
  public string Nombre;
  public string Apellidos;
  public string NombreCompleto
  {
    get { return $"{Nombre} {Apellidos}"; }
  }
}

class Alumno : Persona
{
  // string nombre;
  // string apellidos;
  string matricula;

  // methods
}

class Docente : Persona
{
  string rfc;
  string curp;
}

class Calificacion
{
  Alumno alumno;
  Docente docente;
  // Full Property
  float parcial1;
  public float Parcial1
  {
    get { return parcial1; }
    set { parcial1 = value; }
  }
  
  float parcial2;
  public float Parcial2 { get; set; }
  // float parcial3;
  public float Parcial3;

  // setters y getters
  public Alumno getAlumno()
  {
    return this.alumno;
  }

  public void setAlumno(Alumno alumno)
  {
    this.alumno = alumno;
  }

  public void setDocente(Docente docente)
  {
    this.docente = docente;
  }
}
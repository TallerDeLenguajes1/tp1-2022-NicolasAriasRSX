// public enum cargo
// {
//     Auxiliar,
//     Administracion,
//     Ingeniero,
//     Especialista,
//     Investigador,
//     Limpieza,
//     Mantenimiento,
//     Logistica
// }
public class empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiento;
    private string DNI;
    private string Genero;
    private string EstadoCivil;
    private string Direccion;
    private DateTime FechaIngreso;
    private string Cargo;
    private float SueldoBasico;
    private int Hijos;

    public empleado(string nombre, string apellido, DateTime fechaNacimiento, string dNI, string genero, string estadoCivil, string direccion, DateTime fechaIngreso, string cargo, float sueldoBasico, int hijos)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        DNI = dNI;
        Genero = genero;
        EstadoCivil = estadoCivil;
        Direccion = direccion;
        FechaIngreso = fechaIngreso;
        Cargo = cargo;
        SueldoBasico = sueldoBasico;
        Hijos = hijos;
    }

    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
    public string DNI1 { get => DNI; set => DNI = value; }
    public string Genero1 { get => Genero; set => Genero = value; }
    public string EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
    public string Direccion1 { get => Direccion; set => Direccion = value; }
    public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
    public string Cargo1 { get => Cargo; set => Cargo = value; }
    public float SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value; }
    public int Hijos1 { get => Hijos; set => Hijos = value; }

    public int Edad()
    {
        DateTime fechaActual= DateTime.Now;
        int edad;
        edad= fechaActual.Year - FechaNacimiento.Year;
        if (FechaIngreso.Month > fechaActual.Month && FechaIngreso.Day > fechaActual.Day)
        {
            edad--;
        }
        return edad;
    }
    public int Antiguedad()
    {
        DateTime fechaActual= DateTime.Now;
        int antiguedad;
        antiguedad= fechaActual.Year - FechaIngreso.Year;
        if (FechaIngreso.Month > fechaActual.Month && FechaIngreso.Day > fechaActual.Day)
        {
            antiguedad--;
        }
        return antiguedad;
    }
    public float Sueldo()
    {
        float salario= SueldoBasico - (SueldoBasico * 0.15f);

        if(Antiguedad() >= 20)
        {
            salario= salario + (Antiguedad() / 10);
        }
        else
        {
            salario= salario + (salario * 0.25f);
        }

        return salario;
    }
    public void MostrarInfo()
    {
        Console.WriteLine("Informacion del empleado");
        Console.WriteLine("Nombre y Apellido:" + Nombre + " " + Apellido);
        Console.WriteLine("Edad: " + Edad());
        Console.WriteLine("Antiguedad: " + Antiguedad());
        Console.WriteLine("Sueldo: " + Sueldo());
    }
}
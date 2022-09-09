int cantidadEmpleados= 1;
Console.WriteLine("Hola mundo!!");
Console.WriteLine("Cuantos empleados desea cargar?");
try
{
    cantidadEmpleados= Convert.ToInt32(Console.ReadLine());
    
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}

var listaEmpleado= new List<empleado>();
empleado nuevoEmpleado;

for (int i = 0; i < cantidadEmpleados; i++)
{
    try
    {
        Console.WriteLine("Empleado N°: " + i +1);
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nomb= Console.ReadLine();
        Console.WriteLine("Ingrese el apellido del empleado: ");
        string ape= Console.ReadLine();
        Console.WriteLine("Ingrese el DNI del empleado: ");
        string doc= Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento del empleado: aaaa-mm-dd");
        DateTime fechaNac= Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingrese la direccion del empleado: ");
        string direc= Console.ReadLine();
        Console.WriteLine("Ingrese el genero del empleado (m: masculino; f: femenino): ");
        string gen= Console.ReadLine();
        Console.WriteLine("ingrese el estado civil del empleado (c: casado; s: soltero; d: divorciado) : ");
        string estadoCiv= Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad de hijos que tiene: ");
        int cantHijos= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la fecha de ingreso del empleado: aaaa-mm-dd");
        DateTime fechaIng= Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingrese el cargo del empleado: ");
        string carg= Console.ReadLine();
        Console.WriteLine("Ingrese el suldo basico del empleado: ");
        float sueldoBas= float.Parse(Console.ReadLine());

        nuevoEmpleado= new empleado(nomb,ape,fechaNac,doc,gen,estadoCiv,direc,fechaIng,carg,sueldoBas,cantHijos);

        listaEmpleado.Add(nuevoEmpleado);
    }
    catch (System.Exception ex)
    {
        Console.WriteLine("\nError:" + ex.Message + "\n");
    }

    foreach (var emplead in listaEmpleado)
    {
        emplead.MostrarInfo();
    }
}

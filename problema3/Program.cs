using System;

Console.WriteLine("Rendimiento Kilomentros por Litros\n");

try
{
    int consumo;
    consumo= Rendimento();
    Console.WriteLine("Rendimiento= " + consumo + " km/lts");
}
catch (System.FormatException)
{
    Console.WriteLine("\n- - - - - - - - - -\nError: Formato incorrecto.\n");
}
catch (System.DivideByZeroException)
{
    Console.WriteLine("\n- - - - - - - - - -\nError: No esta definida la divicion por 0 (cero).\n");
}
catch (System.OverflowException)
{
    Console.WriteLine("\n- - - - - - - - - -\nError: El valor era demasiado grande o demasiado pequeño para un Int32..\n");
}
catch (System.Exception ex)
{
    Console.WriteLine("\n- - - - - - - - - -\nError: " + ex.Message + "\n");
}




//-------------->Funcion<----------------------
int Rendimento()
{
    int kilomentros, litros;
    Console.WriteLine("Ingrese la cantidad de Kilometros realizados: ");
    kilomentros= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los litros consumidos: ");
    litros= Convert.ToInt32(Console.ReadLine());
    return kilomentros / litros;
}
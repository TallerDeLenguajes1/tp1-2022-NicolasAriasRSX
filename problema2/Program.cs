using System;

Console.WriteLine("Dividir.");

int divisor, dividendo, resultado;

try
{
    Console.WriteLine("Ingrese el dividendo: ");
    dividendo= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el divisor: ");
    divisor= Convert.ToInt32(Console.ReadLine());
    resultado= dividendo / divisor;

    Console.WriteLine("El resultado es: " + resultado);    
}
catch (System.FormatException)
{
    Console.WriteLine("\nError: Formato incorrecoto.\n");
}
catch (System.DivideByZeroException)
{
    Console.WriteLine("\nError: No esta definida la divicion por 0 (cero).\n");
}
catch (System.OverflowException)
{
    Console.WriteLine("\nError: Numero demasiado grande o demasiado pequeño.\n");
}
catch (System.Exception ex)
{
    Console.WriteLine("\n" + ex.Message + "\n");
}
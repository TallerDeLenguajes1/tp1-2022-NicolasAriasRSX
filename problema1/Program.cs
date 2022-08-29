using System;
int numero;
Console.WriteLine("Ingrese un numero para calcular su cuadrado: ");
try
{
    numero= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Su cuadrado es: " + Cuadrado(numero));
}
catch (System.Exception ex)
{
    Console.WriteLine("\nError: " + ex.Message + "\n");
}

int Cuadrado(int num)
{
    return num * num;
}
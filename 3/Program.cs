// Crear una función que reciba un número y devuelva su doble.
int numero = 0;
Console.Write("Ingrese un numero: ");
numero=int.Parse(Console.ReadLine());
int devolver (int numero)
{
    return numero * 2;
}
int resultado = devolver(numero);
Console.WriteLine($"El doble del numero es: {resultado}");
int numero = 0;
Console.Write("Ingrese un número: ");
numero = int.Parse(Console.ReadLine());

int Cuadrado(int numero)
{
    return numero * numero;
}
int resultado = Cuadrado(numero);
Console.WriteLine($"El cuadrado del número es: {resultado}");
int numero = 0;
Console.WriteLine("Ingrese un numero: ");
numero=int.Parse(Console.ReadLine());
int cuboNumero (int numero)
{
    return numero * numero * numero;
}
int resultado=cuboNumero(numero);
Console.WriteLine($"El cubo del numero ingresado es: {resultado}");
double radio = 0;
Console.WriteLine("Ingrese el radio del circulo: ");
radio=double.Parse(Console.ReadLine());
double area (double radio)
{
    return Math.PI * radio * radio;
}
double resultado=area(radio);
Console.WriteLine($"El area del circulo es: {resultado}");
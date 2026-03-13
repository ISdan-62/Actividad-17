int vase = 0;
int altura = 0;
Console.WriteLine("Ingrese la base del triangulo: ");
vase=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo: ");
altura=int.Parse(Console.ReadLine());
double area(double vase, double altura)
{
    return (vase*altura)/2;
}
double resultado=area(vase, altura);
Console.WriteLine($"El area del triangulo es: {resultado}");
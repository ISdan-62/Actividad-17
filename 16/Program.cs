double minutos = 0;
Console.Write("Ingrese la cantidad de minutos: ");
minutos = double.Parse(Console.ReadLine());
double horas(double minutos)
{
    return minutos / 60;
}
double resultado = horas(minutos);
Console.WriteLine($"El equivalente en horas es: {resultado}");
double kilogramos = 0;
Console.Write("Ingrese el peso en kilogramos: ");
kilogramos = double.Parse(Console.ReadLine());
double ConvertirALibras(double kilogramos)
{
    return kilogramos * 2.20462;
}

double resultado = ConvertirALibras(kilogramos);

Console.WriteLine($"El peso en libras es: {resultado}");
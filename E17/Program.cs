double suma = 0;
Console.Write("Ingrese la cantidad de estudiantes: ");
int cantidad = int.Parse(Console.ReadLine());
double promedio(int cantidad)
{
    for (int repetir = 1; repetir <= cantidad; repetir++)
    {
        Console.Write($"Ingrese la nota del estudiante {repetir}: ");
        double nota = double.Parse(Console.ReadLine());
        suma += nota;
    }
    return suma / cantidad;
}
double resultado = promedio(cantidad);
Console.WriteLine($"El promedio del grupo es: {resultado}");
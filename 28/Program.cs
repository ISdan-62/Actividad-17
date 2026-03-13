void promedioEstudiante()
{
    Console.WriteLine("Ingrese nombre del estudiante: ");
    string nombre=Console.ReadLine();
    Console.WriteLine("Ingrese la primer calificacion: ");
    int Uno = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la segundo calificacion: ");
    int Dos = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese ela tercer calificacion: ");
    int Tres = int.Parse(Console.ReadLine());
    double promedio(int Uno, int Dos, int oTres)
    {
        return (Uno + Dos + Tres) / 3;
    }
    double resultado = promedio(Uno, Dos, Tres);
    Console.WriteLine($"El promedio del estudiante {nombre} es de: {resultado}");
}
promedioEstudiante();
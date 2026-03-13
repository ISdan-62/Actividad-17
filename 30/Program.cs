void reporte()
{
    Console.Write("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();
    Console.Write("Ingrese el curso: ");
    string curso = Console.ReadLine();
    Console.Write("Ingrese la primera calificación: ");
    double nota1 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la segunda calificación: ");
    double nota2 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la tercera calificación: ");
    double nota3 = double.Parse(Console.ReadLine());
    Console.WriteLine("REPORTE DEL ESTUDIANTE");
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Curso: {curso}");
    Console.WriteLine($"Calificación 1: {nota1}");
    Console.WriteLine($"Calificación 2: {nota2}");
    Console.WriteLine($"Calificación 3: {nota3}");
}
reporte();
void CantidadEstudiantes()
{
    Console.Write("Ingrese la cantidad de estudiantes del curso: ");
    int estudiantes = int.Parse(Console.ReadLine());
    Console.WriteLine($"En la clase hay {estudiantes} estudiantes.");
}
CantidadEstudiantes();
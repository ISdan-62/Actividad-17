Console.WriteLine("Ingrese el nombre del estudiante: ");
string nombre= Console.ReadLine();
Console.Write("Ingrese la primera calificacion del estudiante: ");
double calificacion1=double.Parse(Console.ReadLine());
Console.Write("Ingrese la segunda calificacion del estudiante: ");
double calificacion2=double.Parse(Console.ReadLine());
Console.Write("Ingrese la tercera calificacion del estudiante: ");
double calificacion3=double.Parse(Console.ReadLine());
double promedio(double calificacion1, double calificacion2, double calificacion3)
{
    return (calificacion1 + calificacion2 + calificacion3) / 3;
}
double resultado=promedio(calificacion1, calificacion2, calificacion3);
Console.WriteLine($"El promedio de las calificaciones del estudiante {nombre} es de: {resultado}");
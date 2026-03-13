double distancia = 0;
double tiempoEmpleado = 0;
Console.WriteLine("Ingrese la distancia recorrida: ");
distancia=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tiempo empleado: ");
tiempoEmpleado=int.Parse(Console.ReadLine());
double velocidad (double distancia, double tiempoEmpleado)
{
    return distancia/tiempoEmpleado;
}
double resultado=velocidad(distancia, tiempoEmpleado);
Console.WriteLine($"La velocidad es: {velocidad}");
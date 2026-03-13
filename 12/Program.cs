int edad = 0;
Console.Write("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());
string MostrarEdad(int edad)
{
    return $"La edad ingresada es: {edad}";
}
string resultado = MostrarEdad(edad);
Console.WriteLine($"{resultado}");
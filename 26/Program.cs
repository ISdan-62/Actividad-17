void Nacimiento()
{
    Console.Write("Ingrese su edad: ");
    int edad = int.Parse(Console.ReadLine());
    int añoActual = 2026;
    int añoNacimiento = añoActual - edad;
    Console.WriteLine($"Su año aproximado de nacimiento es: {añoNacimiento}");
}
Nacimiento();
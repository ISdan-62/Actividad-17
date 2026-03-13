void Saludar()
{
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}, ¡bienvenido!");
}
Saludar();
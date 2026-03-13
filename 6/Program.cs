double celsius = 0;
Console.Write("Ingrese la temperatura en grados Celsius: ");
celsius = double.Parse(Console.ReadLine());
double fahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}
double resultado = fahrenheit(celsius);

Console.WriteLine($"La temperatura en Fahrenheit es: {resultado}");
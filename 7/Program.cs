double precio = 0;
double descuento = 0;
Console.Write("Ingrese el precio del producto: ");
precio = double.Parse(Console.ReadLine());
Console.Write("Ingrese el porcentaje de descuento: ");
descuento = double.Parse(Console.ReadLine());
double precioFinal(double precio, double descuento)
{
    return precio - (precio * descuento / 100);
}
double resultado = precioFinal(precio, descuento);
Console.WriteLine($"El precio final es: {resultado}");
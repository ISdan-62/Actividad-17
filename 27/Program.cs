void precioDescuento()
{
    Console.Write("Ingrese el precio del producto: ");
    double precio = double.Parse(Console.ReadLine());
    double descuento = precio * 0.10;
    double precioFinal = precio - descuento;
    Console.WriteLine($"El precio con descuento es: {precioFinal}");
}
precioDescuento();
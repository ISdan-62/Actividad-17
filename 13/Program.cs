Console.Write("¿Cuántos productos desea ingresar?: ");
int cantidad = int.Parse(Console.ReadLine());
double TotalCompra(int cantidad)
{
    double total = 0;
    for (int i = 1; i <= cantidad; i++)
    {
        Console.Write($"Ingrese el precio del producto {i}: ");
        double precio = double.Parse(Console.ReadLine());
        total += precio;
    }
    return total;
}
double resultado = TotalCompra(cantidad);
Console.WriteLine($"El total de la compra es: {resultado}");
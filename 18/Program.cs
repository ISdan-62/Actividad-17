Console.Write("Ingrese la cantidad de productos comprados: ");
int productos=int.Parse(Console.ReadLine());
double sumaTotal (int productos)
{
    double suma = 0;
    for (int repetir = 1; repetir <= productos; repetir++)
    {
        Console.Write($"El precio del producto {productos} ");
        double precio = double.Parse(Console.ReadLine());
        suma += precio;
    }
    return suma;
}
double resultado=sumaTotal(productos);
Console.WriteLine($"La suma total de los productos ingresadoes es de: {resultado}");
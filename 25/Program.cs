void areaRectangulo ()
{
    int altura = 0;
    int vase = 0;
    Console.WriteLine("Ingrese la altura del rectangulo: ");
    altura = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la base del rectangulo: ");
    vase = int.Parse(Console.ReadLine());
    int area(int altura, int vase)
    {
        return altura * vase;
    }
    int resultado = area(altura, vase);
    Console.WriteLine($"El area del rectangulo es {resultado}");
}
areaRectangulo();
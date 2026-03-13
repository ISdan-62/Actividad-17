void SUMA()
{
    Console.WriteLine("Ingrese el primer numero: ");
    int numeroUno=int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    int numeroDos = int.Parse(Console.ReadLine());
    int suma = 0;
    suma = numeroUno + numeroDos;
    Console.WriteLine($"La suma es de: {suma}");
}
SUMA();
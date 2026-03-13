int numeroUno = 0;
int numeroDos = 0;
Console.Write("Ingrese un número: ");
numeroUno = int.Parse(Console.ReadLine());
Console.Write("Ingrese un número: ");
numeroDos = int.Parse(Console.ReadLine());
int Sumar(int numeroUno, int NumeroDos)
{
    return numeroUno + numeroDos;
}
int resultado = Sumar(numeroUno, numeroDos);
Console.WriteLine("La suma es: " + resultado);
return 0;
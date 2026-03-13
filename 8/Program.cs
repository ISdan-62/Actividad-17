int numeroUno = 0;
int numeroDos = 0;
int numeroTres = 0;
Console.WriteLine("Ingrese el primer numero: ");
numeroUno=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
numeroDos=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero: ");
numeroTres=int.Parse(Console.ReadLine());
double promedio(int numeroUno, int numeroDos, int numeroTres)
{
    return (numeroUno + numeroDos + numeroTres) / 3;
}
double resultado=promedio(numeroUno, numeroDos, numeroTres);
Console.WriteLine($"El promedio de los numero ingresados es: {resultado}");
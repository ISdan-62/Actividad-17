Console.WriteLine("Ingrese la cantidad de días trabajados: ");
int dias = int.Parse(Console.ReadLine());
Console.Write("Ingrese el pago diario: ");
double pagoDiario = double.Parse(Console.ReadLine());
double salarioTotal(int dias, double pagoDiario)
{
    return dias * pagoDiario;
}
double resultado = salarioTotal(dias, pagoDiario);
Console.WriteLine($"El salario total del empleado es: {resultado}");
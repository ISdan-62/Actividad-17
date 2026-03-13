double salarioHora = 0;
double horasTrabajadas = 0;
Console.Write("Ingrese el salario por hora: ");
salarioHora = double.Parse(Console.ReadLine());
Console.Write("Ingrese las horas trabajadas: ");
horasTrabajadas = double.Parse(Console.ReadLine());
double SalarioTotal(double salarioHora, double horasTrabajadas)
{
    return salarioHora * horasTrabajadas;
}
double resultado = SalarioTotal(salarioHora, horasTrabajadas);
Console.WriteLine($"El salario total es: {resultado}");
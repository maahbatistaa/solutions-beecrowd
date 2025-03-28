string nomeVendedor = Console.ReadLine();
double salarioFixo = double.Parse(Console.ReadLine());
double totalVendas = double.Parse(Console.ReadLine());

double salarioFinal = salarioFixo + totalVendas * 0.15;

Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2"));
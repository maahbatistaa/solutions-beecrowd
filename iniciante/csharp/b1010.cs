string[] linha1 = Console.ReadLine().Split(' ');
string[] linha2 = Console.ReadLine().Split(' ');

int cod1 = int.Parse(linha1[0]);
int qte1 = int.Parse(linha1[1]);
double valor1 = double.Parse(linha1[2]);

int cod2 = int.Parse(linha2[0]);
int qte2 = int.Parse(linha2[1]);
double valor2 = double.Parse(linha2[2]);

double total = (qte1 * valor1) + (qte2 * valor2);

Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
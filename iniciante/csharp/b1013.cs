string[] linha = Console.ReadLine().Split(' ');

int a = int.Parse(linha[0]);
int b = int.Parse(linha[1]);
int c = int.Parse(linha[2]);

int maiorAB = (a + b + Math.Abs(a - b)) / 2;
int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

Console.WriteLine($"{maior} eh o maior");
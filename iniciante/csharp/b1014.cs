int distancia = int.Parse(Console.ReadLine());
double combustivelLitro = double.Parse(Console.ReadLine());

double media = (double)distancia / combustivelLitro;
Console.WriteLine($"{media:F3} km/l");
string[] linha = Console.ReadLine().Split(' ');
double a = double.Parse(linha[0]);
double b = double.Parse(linha[1]);
double c = double.Parse(linha[2]);

double areaTriangulo = (a * c) / 2.0;
double areaCirculo = 3.14159 * c * c;
double areaTrapezio = ((a + b) * c) / 2.0;
double areaQuadrado = b * b;
double areaRetangulo = a * b;

Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");

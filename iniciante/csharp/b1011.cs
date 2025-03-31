const double pi = 3.14159;
double raio, volume;

raio = double.Parse(Console.ReadLine());
volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);

Console.WriteLine($"VOLUME = {volume:F3}");
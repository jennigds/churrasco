int AdultosbebemAlcool, AdultosSemAlcool, criancas, adultos, pessoas;
double cerveja, carne , refrigerante, acompanhamentos, agua;

Console.WriteLine("--- churrasco ---\n");
Console.Write("adultos que consomem bebidas alcoólicas)........: ");
adultosComAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("adultos que não consomem bebidas alcoólicas)....: ");
adultosSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("crianças........................................: ");
criancas = Convert.ToInt32(Console.ReadLine());

adultos = AdultosbebemAlcool + AdultosSemAlcool;
pessoas = adultos + criancas;
carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * AdultosbebemAlcool;
refrigerante = 0.5 * (AdultosSemAlcool + criancas);
agua = 0.4 * pessoas;

Console.WriteLine();
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
Console.WriteLine($"carne.............: {carne:N1}kg");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}l");
Console.WriteLine($"acompanhamentos...: {acompanhamentos:N1}kg");
Console.WriteLine($"Água..............: {agua:N1}l");
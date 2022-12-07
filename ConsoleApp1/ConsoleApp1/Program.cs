using System.Globalization;

string nome = "Nicoli";
int idade = 22;
double tamanho = 1.65;

Console.WriteLine($"O nome dela é {nome}, tem {idade} anos e mede {tamanho.ToString("F2", CultureInfo.InvariantCulture)}");
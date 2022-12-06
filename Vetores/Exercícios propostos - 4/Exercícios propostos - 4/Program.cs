using System.Globalization;

int N;
double[] vet;
double cont = 0.0;


N = int.Parse(Console.ReadLine());
vet = new double[N];

string[] dados = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(dados[i], CultureInfo.InvariantCulture);
    cont += vet[i];
}
double media = cont / N;

Console.WriteLine(media.ToString("f3", CultureInfo.InvariantCulture));

for(int i = 0; i < N; i++)
{
    if (vet[i] < media)
    {
        Console.WriteLine(vet[i]);
    }
}
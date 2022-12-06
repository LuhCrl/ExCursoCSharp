using System.Globalization;

int N;
double[] vet;

double maior = 0.0;
int position = 0;

N = int.Parse(Console.ReadLine());
vet = new double[N];

string[] dados = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(dados[i], CultureInfo.InvariantCulture);

    if (vet[i] > maior)
    {
        maior = vet[i];
        position = i;
    }
}

Console.WriteLine(maior.ToString("f1", CultureInfo.InvariantCulture));
Console.WriteLine(position);
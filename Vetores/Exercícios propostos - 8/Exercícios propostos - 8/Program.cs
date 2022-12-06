using System.Globalization;

int N;
double maior = 0.0;
double menor = 2.0;
double tamanhoF = 0.0;
int totalF = 0;
int totalM = 0;
double media;
double[] tamanhos;
char[] sexo;

N = int.Parse(Console.ReadLine());
tamanhos = new double[N];
sexo    = new char[N]; 

for (int i = 0; i <N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');
    tamanhos[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);
    sexo[i]     = char.Parse(dados[1]);
}
for(int i = 0; i <N; i++)
{
    if (tamanhos[i] > maior)
    {
        maior = tamanhos[i];
    }
}

for (int i = 0; i < N; i++)
{
    if (tamanhos[i] < menor)
    {
        menor = tamanhos[i];
    }
}
for(int i = 0; i < N; i++)
{
    if (sexo[i] == 'f')
    {
        tamanhoF += tamanhos[i];
        totalF++;
    }
}
media = tamanhoF / totalF;

for(int i = 0; i < N; i++)
{
    if (sexo[i] == 'm')
    {
        totalM++;
    }
}


Console.WriteLine("Menor altura = " + menor.ToString("f2", CultureInfo.InvariantCulture));
Console.WriteLine("Maior altura = " + maior.ToString("f2", CultureInfo.InvariantCulture));
Console.WriteLine("Media das alturas das mulheres = " + media.ToString("f2", CultureInfo.InvariantCulture));
Console.WriteLine("Numero de homens = " + totalM);
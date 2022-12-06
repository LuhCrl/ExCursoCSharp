using System.Globalization;

int N;
double[] vet;

string[] nomes;
double[] Psem;
double[] Ssem;
double[] media;

N = int.Parse(Console.ReadLine());
nomes = new string[N];
Psem = new double[N];
Ssem = new double[N];
media = new double[N];

for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    nomes[i] = s[0];
    Psem[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
    Ssem[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
    
}
Console.WriteLine(" ");
Console.WriteLine("Alunos aprovaros: ");
for(int i = 0; i < N; i++)
{
    media[i] = (Psem[i] + Ssem[i]) / 2;
    if (media[i] >= 6)
    {
        Console.WriteLine(nomes[i]);
    }
}


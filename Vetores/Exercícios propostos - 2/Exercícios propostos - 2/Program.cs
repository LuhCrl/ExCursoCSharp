using System.Globalization;

int N;
int p1 = 0;
int cont = 0;
int[] vet;


N = int.Parse(Console.ReadLine());
vet = new int[N];

string[] dados = Console.ReadLine().Split(' ');



for (int i = 0; i < N; i++)
{
    vet[i] = int.Parse(dados[i]);
    p1 = vet[i] % 2;

    if (p1 == 0)
    {
        Console.Write(vet[i] + " ");
        cont++;
    }
}
Console.WriteLine(" ");
Console.WriteLine(cont);
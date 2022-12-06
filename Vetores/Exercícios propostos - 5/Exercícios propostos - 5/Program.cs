using System.Globalization;

int N;
int[] vet;

N = int.Parse(Console.ReadLine());
vet = new int[N];

string[] dados = Console.ReadLine().Split(' ');

int totalPar = 0;
int cont = 0;
for (int i = 0; i < N; i++)
{
    vet[i] = int.Parse(dados[i]);
    int par = vet[i] % 2;
    if(par == 0)
    {
         totalPar += vet[i];
        cont++; 
    }


}

int media = totalPar / cont;

Console.WriteLine(media);
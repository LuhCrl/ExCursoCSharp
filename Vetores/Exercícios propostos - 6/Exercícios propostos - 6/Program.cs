using System.Globalization;

int N;
string n1 = "null";
string[] nomes;
int[] idades;

N = int.Parse(Console.ReadLine());
nomes = new string[N];
idades = new int[N];


int cont = 0;
for(int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');
    nomes[i] = dados[0];
    idades[i] = int.Parse(dados[1]);
}
for(int i = 0; i < N; i++)
{
    if (idades[i] > cont)
    {
        cont = idades[i];
         n1= nomes[i];
    }
}
Console.WriteLine("A pessoa mais velha é: " + n1);
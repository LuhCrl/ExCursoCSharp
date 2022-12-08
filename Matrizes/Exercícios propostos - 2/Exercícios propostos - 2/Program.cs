using System.Globalization;

int N;
int[,] mat;
int[] soma;

N = int.Parse(Console.ReadLine());
mat = new int[N,N];
soma = new int[N];

for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split();
    for(int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(s[j]);
        soma[i] += mat[i, j];
    }

}
for(int i = 0; i < N; i++)
{
    Console.WriteLine(soma[i]);
}
